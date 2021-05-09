using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIPS
{
    public enum Instruction_Type
    {
        R_Type,
        I_Type,
        I_Type_Branch,
        I_Type_DataTransfer,
        J_Type,
        J_Type_Register,
        Invalid
    }

    class CPU_Instruction
    {
        public string name;

        public Instruction_Type instruction_type;

        public int code_line_index;

        public CPU_Instruction()
        {

        }

        public CPU_Instruction(int idx)
        {
            this.instruction_type = Instruction_Type.Invalid;

            this.name = String.Copy(idx.ToString());
        }

        public override string ToString()
        {
            return this.code_line_index.ToString() + "-) " + this.name;
        }
    }

    class CPU_Instruction_R : CPU_Instruction
    {
        public string destination_reg;

        public string op_reg_1;

        public string op_reg_2;

        public CPU_Instruction_R(string name, string destination_reg, string op_reg_1, string op_reg_2, int code_line_index)
        {
            this.name = String.Copy(name);
            this.destination_reg = String.Copy(destination_reg);
            this.op_reg_1 = String.Copy(op_reg_1);
            this.op_reg_2 = String.Copy(op_reg_2);
            this.instruction_type = Instruction_Type.R_Type;
            this.code_line_index = code_line_index;
        }

        public override string ToString()
        {
            return base.ToString() + " " + destination_reg + ", " + op_reg_1 + ", " + op_reg_2;
        }
    }

    class CPU_Instruction_I : CPU_Instruction
    {
        public string destination_reg;

        public string op_reg;

        public string immediate;

        public CPU_Instruction_I(string name, string destination_reg, string op_reg, string immediate, int code_line_index)
        {
            this.name = name;
            this.destination_reg = destination_reg;
            this.op_reg = op_reg;
            this.immediate = immediate;
            this.instruction_type = Instruction_Type.I_Type;
            this.code_line_index = code_line_index;
        }

        public override string ToString()
        {
            return base.ToString() + " " + destination_reg + ", " + op_reg + ", " + immediate;
        }
    }

    class CPU_Instruction_I_Branch : CPU_Instruction
    {
        public string op_reg_1;

        public string op_reg_2;

        public string label;

        public CPU_Instruction_I_Branch(string name, string op_reg_1, string op_reg_2, string label, int code_line_index)
        {
            this.name = name;
            this.op_reg_1 = op_reg_1;
            this.op_reg_2 = op_reg_2;
            this.label = label;
            this.instruction_type = Instruction_Type.I_Type_Branch;
            this.code_line_index = code_line_index;
        }

        public override string ToString()
        {
            return base.ToString() + " " + op_reg_1 + ", " + op_reg_2 + ", " + label;
        }
    }

    class CPU_Instruction_I_DataTransfer : CPU_Instruction
    {
        public string destination_reg;

        public string offset;

        public CPU_Instruction_I_DataTransfer(string name, string destination_reg, string offset, int code_line_index)
        {
            this.name = name;
            this.destination_reg = destination_reg;
            this.offset = offset;
            this.instruction_type = Instruction_Type.I_Type_DataTransfer;
            this.code_line_index = code_line_index;
        }

        public override string ToString()
        {
            return base.ToString() + " " + destination_reg + ", " + offset;
        }
    }

    class CPU_Instruction_J : CPU_Instruction
    {
        public string label;

        public CPU_Instruction_J(string name, string label, int code_line_index)
        {
            this.label = label;
            this.instruction_type = Instruction_Type.J_Type;
            this.code_line_index = code_line_index;
        }

        public override string ToString()
        {
            return base.ToString() + " " + label;
        }
    }

    class CPU_Instruction_J_Register : CPU_Instruction
    {
        public string register;

        public CPU_Instruction_J_Register(string name, string register, int code_line_index)
        {
            this.register = register;
            this.instruction_type = Instruction_Type.J_Type_Register;
            this.code_line_index = code_line_index;
        }

        public override string ToString()
        {
            return base.ToString() + " " + register;
        }
    }
}
