using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MIPS
{
    class Parser
    {
        public static CPU_Instruction ParseNextInstruction(string line)
        {
            CPU_Instruction instruction = new CPU_Instruction(null, null);

            if (line.IndexOf('#') != -1) line = line.Remove(line.IndexOf('#')); //Handle comments

            line = line.Trim(' ');

            Parser.get_instruction_name(instruction, ref line);

            Parser.get_destination_reg(instruction, ref  line);

            Parser.get_operands(instruction, ref line);

            return instruction;
        }

        private static void get_instruction_name(CPU_Instruction instruction, ref string line)
        {
            char[] c1 = { ' ', ',' };
            char[] c2 = { ' ', ',', '(', ')'};

            var elements = line.Split(c1).ToList(); //Split the line into elements after each empty space

            elements.RemoveAll(x => System.Text.RegularExpressions.Regex.IsMatch(x, @"^[a-zA-Z0-9$()]+$") == false);

            instruction.instruction_name = String.Copy(elements[0].Trim(c2));

            elements.RemoveAt(0);    
        }

        private static void get_destination_reg(CPU_Instruction instruction, ref string line)
        {
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == instruction.instruction_name[0])
                {
                    line = line.Remove(i, instruction.instruction_name.Length);

                    line = line.Replace(" ", "");

                    break;
                }
            }

            MatchCollection matches = (new Regex(@"\$[a-z0-9]+").Matches(line));

            List<string> registerNames = new List<string>();

            foreach (Match match in matches)
            {
                registerNames.Add(match.Value);
            }

            instruction.destinationRegisterName = registerNames[0];

            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == instruction.destinationRegisterName[0])
                {
                    line = line.Remove(i, instruction.destinationRegisterName.Length);

                    line = line.Replace(" ", "");

                    break;
                }
            }
        }

        private static void get_operands(CPU_Instruction instruction, ref string line)
        {
            //Offset Operand

            CPU_Instruction_Operand offset_operand;

            Regex offset_operand_regex = new Regex(@"[0-9]+\s*\(\s*\$[a-z]+[0-9]+\s*\)");

            MatchCollection offset_operand_regex_matches = offset_operand_regex.Matches(line);

            if(offset_operand_regex_matches.Count > 1)
            {
                instruction = null;

                return;
            }

            if(offset_operand_regex_matches.Count != 0)
            {
                Regex offset_val_regex = new Regex(@"^[0-9]+");
                Regex offset_reg_regex = new Regex(@"\$[a-z0-9]+");

                offset_operand = new CPU_Instruction_Operand(
                    CPU_Instruction_Operand.OperandType.Offset,
                    offset_reg_regex.Match(offset_operand_regex_matches[0].Value).Value, 
                    Convert.ToInt32(offset_val_regex.Match(offset_operand_regex_matches[0].Value).Value)    
                );

                line = offset_operand_regex.Replace(line, "");
            }

            //Register Operands

            List<CPU_Instruction_Operand> reg_operand_list = new List<CPU_Instruction_Operand>();

            Regex register_operand_regex = new Regex(@"\$[a-z0-9]+");

            MatchCollection register_operand_regex_matches = register_operand_regex.Matches(line);

            foreach (Match match in register_operand_regex_matches)
            {
                reg_operand_list.Add(
                    new CPU_Instruction_Operand(
                        CPU_Instruction_Operand.OperandType.Register,
                        match.Value,                    
                        0
                ));
            }

            //Immidiate Operand

            List<CPU_Instruction_Operand> im_operand_list = new List<CPU_Instruction_Operand>();

            Regex im_operand_regex = new Regex(@"(?<![a-z])[0-9]+(?!\()");

            MatchCollection im_operand_regex_matches = im_operand_regex.Matches(line);

            foreach (Match match in im_operand_regex_matches)
            {
                im_operand_list.Add(
                    new CPU_Instruction_Operand(
                        CPU_Instruction_Operand.OperandType.Immediate,
                        null,
                        Convert.ToInt32(match.Value)
                ));
            }



        }
    }
}
//\$[a-z0-9]+ register

//\$[a-zA-Z0-9]* register regex

//[0-9]+\s*\(\s*\$[a-z]+[0-9]+\s*\) offset

//only number (?<![a-z])[0-9]+(?!\()
