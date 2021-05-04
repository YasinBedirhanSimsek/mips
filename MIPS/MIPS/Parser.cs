using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MIPS
{
    //???.add ($s4),$s5,43 ( $a0 ) --> return null

    //add ($s4), $s5, 43 ( $a0 )

    //add ($s4), 3, $t5

    class Parser
    {
        public static CPU_Instruction Fetch(string line)
        {
            line = line.Trim();

            if (Char.IsLetter(line[0]) == false && line[0] != '.')
                return null;

            CPU_Instruction instruction = new CPU_Instruction(null, null);

            get_instruction_name(ref instruction, ref line);

            if (instruction == null)
                return null;

            get_destination_reg(ref instruction, ref line);

            if (instruction == null)
                return null;

            get_operands(ref instruction, ref line);

            if (instruction == null)
                return null;

            instruction.destinationRegisterName = instruction.destinationRegisterName.ToLower();
            instruction.instruction_name = instruction.instruction_name.ToLower();
            return instruction;
        }

        private static void get_instruction_name(ref CPU_Instruction instruction, ref string line)
        {
            string instruction_name = "";

            for (int i = 0; i < line.Length; i++)
            {
                if (Char.IsLetter(line[i]))
                {
                    instruction_name += line[i];
                }
                else if (Char.IsWhiteSpace(line[i]))
                {
                    instruction.instruction_name = String.Copy(instruction_name);

                    return;
                }
                else if(line[i] == '.')
                {
                    if (i+1 < line.Length)
                    {
                        if(line[i+1] == 's')
                        {
                           instruction.instruction_name = String.Copy(instruction_name + ".s");

                           return;
                        }
                    }

                    instruction = null;

                    return;
                }
                else
                {
                    instruction = null;

                    return;
                }
            }
        }

        private static void get_destination_reg(ref CPU_Instruction instruction, ref string line)
        {
            int dolar_index = line.IndexOf('$');

            if (dolar_index == -1)
            {
                instruction = null;

                return;
            }

            string destination_register_name = "";

            for (int i = dolar_index; i < line.Length; i++)
            {
                if (i == dolar_index)
                {
                    destination_register_name += "$";

                    continue;
                }

                if (Char.IsLetterOrDigit(line[i]))
                {
                    destination_register_name += line[i];
                }
                else if (Char.IsWhiteSpace(line[i]) || line[i] == ',')
                {
                    instruction.destinationRegisterName = String.Copy(destination_register_name);

                    return;
                }
                else
                {
                    instruction = null;

                    return;
                }
            }
        }

        private static void get_operands(ref CPU_Instruction instruction, ref string line)
        {
            line = line.Replace(" ", "");

            List<string> elements = line.Split(',').ToList();

            if(instruction.instruction_name == "move")
            {
                string str = String.Copy(elements[1].ToLower()); ;

                //First element in the elements list

                Regex regex = new Regex(@"\$[a-z0-9]+");

                var matches = regex.Matches(str);

                if (matches.Count != 1)
                {
                    instruction = null;
                    return;
                }
                else
                {
                    instruction.operands.Add(new CPU_Instruction_Operand(CPU_Instruction_Operand.OperandType.Register, matches[0].Value, 0));
                    instruction.instructionType = instruction.instructionType == CPU_Instruction.InstructionType.Immidiate ? instruction.instructionType : CPU_Instruction.InstructionType.Register;

                }

                return;
            }

            switch (elements.Count())
            {
                case 2:
                    string offset_value = "";
                    string register = "";
                    string str = String.Copy(elements[1].ToLower());
                    bool paranthesis = false;
                    for (int i = 0; i < str.Length; i++)
                    {
                        if (paranthesis)
                        {
                            Regex regex = new Regex(@"\$[a-z0-9]+");

                            var matches = regex.Matches(str);

                            if (matches.Count != 1)
                            {
                                instruction = null;
                                return;
                            }
                            else
                            {
                                register = matches[0].Value;
                            }
                        }
                        else
                        {
                            if (Char.IsDigit(str[i]))
                            {
                                offset_value += str[i];
                            }
                            else if (str[i] == '(')
                            {
                                paranthesis = true;
                            }
                            else
                            {
                                instruction = null;
                                return;
                            }
                        }
                    }

                    instruction.operands.Add(new CPU_Instruction_Operand(CPU_Instruction_Operand.OperandType.Offset, register, Convert.ToInt32(offset_value)));
                    instruction.instructionType = CPU_Instruction.InstructionType.Memory;

                    break;

                case 3:
                    string str2 = String.Copy(elements[1].ToLower());
                    string str3 = String.Copy(elements[2].ToLower());

                    int dolar_sign_index = 0;

                    //First element in the elements list

                    dolar_sign_index = str2.IndexOf('$');

                    if (dolar_sign_index == -1)
                    {
                        Regex regex = new Regex(@"\-?[0-9]");

                        var matches = regex.Matches(str2);

                        if (matches.Count != 1)
                        {
                            instruction = null;

                            return;
                        }
                        else if (matches[0].Value.Length != str2.Length)
                        {
                            instruction = null;

                            return;
                        }
                        else
                        {
                            instruction.operands.Add(new CPU_Instruction_Operand(CPU_Instruction_Operand.OperandType.Immediate, null, Convert.ToInt32(matches[0].Value)));
                            instruction.instructionType = CPU_Instruction.InstructionType.Immidiate;
                        }
                    }
                    else
                    {
                        Regex regex = new Regex(@"\$[a-z0-9]+");

                        var matches = regex.Matches(str2);

                        if (matches.Count != 1)
                        {
                            instruction = null;
                            return;
                        }
                        else
                        {
                            instruction.operands.Add(new CPU_Instruction_Operand(CPU_Instruction_Operand.OperandType.Register, matches[0].Value, 0));
                            instruction.instructionType = instruction.instructionType == CPU_Instruction.InstructionType.Immidiate ? instruction.instructionType : CPU_Instruction.InstructionType.Register;

                        }
                    }

                    //Second element in the elements list

                    dolar_sign_index = str3.IndexOf('$');

                    if (dolar_sign_index == -1)
                    {
                        Regex regex = new Regex(@"\-?[0-9]");

                        var matches = regex.Matches(str3);

                        if (matches.Count != 1)
                        {
                            instruction = null;

                            return;
                        }
                        else if (matches[0].Value.Length != str3.Length)
                        {
                            instruction = null;

                            return;
                        }
                        else
                        {
                            instruction.operands.Add(new CPU_Instruction_Operand(CPU_Instruction_Operand.OperandType.Immediate, null, Convert.ToInt32(matches[0].Value)));
                            instruction.instructionType = CPU_Instruction.InstructionType.Immidiate;
                        }
                    }
                    else
                    {
                        Regex regex = new Regex(@"\$[a-z0-9]+");

                        var matches = regex.Matches(str3);

                        if (matches.Count != 1)
                        {
                            instruction = null;
                            return;
                        }
                        else
                        {
                            instruction.operands.Add(new CPU_Instruction_Operand(CPU_Instruction_Operand.OperandType.Register, matches[0].Value, 0));
                            instruction.instructionType = instruction.instructionType == CPU_Instruction.InstructionType.Immidiate ? instruction.instructionType : CPU_Instruction.InstructionType.Register;
                        }
                    }
                    break;

                default:
                    instruction = null;
                    return;
            }
        }
    }
}
//\$[a-z0-9]+ register

//\$[a-zA-Z0-9]* register regex

//[0-9]+\s*\(\s*\$[a-z]+[0-9]+\s*\) offset

//only number (?<![a-z])[0-9]+(?!\()
