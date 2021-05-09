using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MIPS
{
    class Simulator
    {
        private CPU cpu;

        private RichTextBox editor;

        private List<string> lines;

        private ListBox parsedList;

        private static Regex register_regex = new Regex(@"\$[a-z0-9]+");

        private static Regex firstword_regex = new Regex(@"^([\S]+)");

        private static Regex offset_regex = new Regex(@"[0-9]+\s*\(\s*\$[a-z]*[0-9]*\s*\)");

        private static Regex imm_regex = new Regex(@"(?<![\)a-z0-9])[0-9]+(?!\s*\()");

        public Simulator(DataGridView int_register_grid, DataGridView fp_register_grid, DataGridView memory_grid, RichTextBox editor, ListBox parsedList)
        {
            this.cpu = new CPU(int_register_grid, fp_register_grid, memory_grid);

            this.editor = editor;

            this.lines = new List<string>();

            this.parsedList = parsedList;
        }

        public int Start()
        {
            if (editor.Text.Length == 0)
            {
                this.Error(0,-1);

                return -1;
            }

            this.cpu.CPU_Program = CreateProgramInstructions();

            this.parsedList.DataSource = this.cpu.CPU_Program;
            
            if(this.cpu.CPU_Program == null)
            {
                this.Error(0, -1);

                return -1;
            }

            return 0;
        }

        private List<CPU_Instruction> CreateProgramInstructions()
        {
            List<CPU_Instruction> prog_list = new List<CPU_Instruction>();

            List<string> lines = GetLines();

            if (lines == null)
                return null;

            string instruction_name = "";

            for(int i = 0; i < lines.Count; i++)
            {
                instruction_name = GetInstructionName(lines[i]);

                MatchCollection reg_operands;
                MatchCollection offset;
                MatchCollection imm;

                switch (GetInstructionType(lines[i], instruction_name))
                {
                    case Instruction_Type.R_Type: //add $rd, $rs, $rt
                        reg_operands = register_regex.Matches(lines[i]);
                        CPU_Instruction_R r_inst = new CPU_Instruction_R(instruction_name, reg_operands[0].Value, reg_operands[1].Value, reg_operands[2].Value,i);
                        prog_list.Add(r_inst);
                        break;

                    case Instruction_Type.I_Type: //addi $rt, $rs, imm
                        reg_operands = register_regex.Matches(lines[i]);
                        imm = imm_regex.Matches(lines[i]);
                        CPU_Instruction_I i_inst = new CPU_Instruction_I(instruction_name, reg_operands[0].Value, reg_operands[1].Value, imm[0].Value,i);
                        prog_list.Add(i_inst);
                        break;

                    case Instruction_Type.I_Type_Branch: //beq $rs, $rt, label
                        reg_operands = register_regex.Matches(lines[i]);
                        CPU_Instruction_I_Branch i_branch_inst = new CPU_Instruction_I_Branch(instruction_name, reg_operands[0].Value, reg_operands[1].Value, lines[i].Split(',').ToList().Last().Split(' ').Last().Trim(),i);
                        prog_list.Add(i_branch_inst);
                        break;

                    case Instruction_Type.I_Type_DataTransfer: //lw $rt, imm($rs)
                        reg_operands = register_regex.Matches(lines[i]);
                        offset = offset_regex.Matches(lines[i]);
                        CPU_Instruction_I_DataTransfer i_data_inst = new CPU_Instruction_I_DataTransfer(instruction_name, reg_operands[0].Value, offset[0].Value,i);
                        prog_list.Add(i_data_inst);
                        break;

                    case Instruction_Type.J_Type: //jal label
                        CPU_Instruction_J j_inst = new CPU_Instruction_J(instruction_name, lines[i].Split(' ').Last().Trim(),i);
                        prog_list.Add(j_inst);
                        break;

                    case Instruction_Type.J_Type_Register: //jr $s1
                        reg_operands = register_regex.Matches(lines[i]);
                        CPU_Instruction_J_Register j_register_inst = new CPU_Instruction_J_Register(instruction_name, reg_operands[0].Value,i);
                        prog_list.Add(j_register_inst);
                        break;

                    default:
                        prog_list.Clear();
                        prog_list.Add(new CPU_Instruction(i));
                        break;
                }

            }

            return prog_list;
        }

        private string GetInstructionName(string line)
        {
            MatchCollection mc = firstword_regex.Matches(line);

            return mc.Count == 1 ? mc[0].Value : null;
        }

        private Instruction_Type GetInstructionType(string line, string instruction_name)
        {
            MatchCollection register_matches = register_regex.Matches(line);

            Instruction_Type type;

            if (register_matches.Count == 3) //add $rd, $rs, $rt
            {
                type = line.Count(x => x == ',') == 2 ? Instruction_Type.R_Type : Instruction_Type.Invalid;
            }
            else if (register_matches.Count == 2)
            {
                MatchCollection offset_matches = offset_regex.Matches(line);            

                if (offset_matches.Count > 1)
                {
                    type = Instruction_Type.Invalid;
                }
                else if (offset_matches.Count == 1) //lw $rt, imm($rs)
                {
                    type = type = line.Count(x => x == ',') == 1 ? Instruction_Type.I_Type_DataTransfer : Instruction_Type.Invalid; 
                }
                else
                {
                    if (instruction_name[0] == 'b')
                        type = Instruction_Type.I_Type_Branch; //beq $rs, $rt, label
                    else
                    {
                        MatchCollection imm_matches = imm_regex.Matches(line);

                        type = imm_matches.Count == 1 ? Instruction_Type.I_Type : Instruction_Type.Invalid; //addi $rt, $rs, imm
                    }
                        
                    type = line.Count(x => x == ',') == 2 ? type : Instruction_Type.Invalid;
                }
            }
            else if(register_matches.Count == 1) //jr $s1
            {
                type = instruction_name[0] == 'j' ? Instruction_Type.J_Type_Register : Instruction_Type.Invalid;

                type = line.Split(' ').ToList().Count == 2 ? type : Instruction_Type.Invalid;
            }
            else //jal label
            {
                type = instruction_name[0] == 'j' ? Instruction_Type.J_Type : Instruction_Type.Invalid;

                type = line.Split(' ').ToList().Count == 2 ? type : Instruction_Type.Invalid;
            }

            if (instruction_name.Length == line.Length)
                type = Instruction_Type.Invalid;

            return type;
        }

        private List<string> GetLines()
        {
            List<string> lines = editor.Text.Split('\n').ToList();

            for (int i = 0; i < lines.Count; i++)
            {
                lines[i] = lines[i].Trim(' ');

                if (lines[i] == "")
                    lines.RemoveAt(i--);
            }

            return lines.Count != 0 ? lines : null;
        } 

        public void Reset()
        {
            this.cpu.Reset();

            this.cpu.UI_Manager.Update();

            this.parsedList.DataSource = null;
        }

        public void NextStep()
        {
            int cpuStatus = cpu.Tick();

            if (cpuStatus != 0)
                Error(0, -1);
        }

        public void Error(int code, int line_idx)
        {
            switch (code)
            {
                case 0:
                    MessageBox.Show("Editor Text Invalid");
                    break;

                default:
                    break;
            }
        }
    }
}
