using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIPS
{
    class CPU_Instruction_Operand
    {
        public enum OperandType
        {
            Register,
            Immediate,
            Offset
        }

        private OperandType type;

        private CPU_Register<int> operand_reg;

        private Int32 operand_int;

        private Int32 offset;
        
        public CPU_Instruction_Operand(OperandType type, CPU_Register<int> operand_reg, int value)
        {
            switch (this.type)
            {
                case OperandType.Register:
                    this.operand_reg = operand_reg;
                    this.offset = 0;
                    this.operand_int = 0;
                break;

                case OperandType.Immediate:
                    this.operand_reg = null;
                    this.offset = 0;
                    this.operand_int = value;
                break;

                case OperandType.Offset:
                    this.operand_reg = operand_reg;
                    this.offset = value;
                    this.operand_int = 0;
                break;
            }
        }

        public int GetValue()
        {
            switch (this.type)
            {
                case OperandType.Register:
                    return this.operand_reg.Value;

                case OperandType.Immediate:
                    return this.operand_int;

                case OperandType.Offset:
                    return this.offset + this.operand_reg.Value;

                default:
                    return 0;
            }
        }
    }

    class CPU_Instruction
    {
        public string instruction_name;

        public CPU_Register<int> destinationRegister;

        public List<CPU_Instruction_Operand> operands;

        public CPU_Instruction(string instruction_name, CPU_Register<int> destinationRegister)
        {
            this.instruction_name = instruction_name;

            this.destinationRegister = destinationRegister;

            this.operands = new List<CPU_Instruction_Operand>();
        }
    }
}
