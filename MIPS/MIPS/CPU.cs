using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIPS
{
    class CPU
    {
        //Instruction_Set
        public enum Instruction_Set
        {
            add,
            addi,
            addiu,
            mul,
            muli,
            divi,
            div,
            sub,
            lw,
            sw, 
            move,
            INVALID
        }

        /*public struct ExecutionObject
        {
            public Instruction_Set instruction;
            public CPU_Register<int> target_register;
            public int operand_1;
            public int operand_2;
            public bool single_operand;
            public bool object_valid;
        }*/

        //Register Lists

        public BindingList<CPU_Register<int>> IntegerRegisters;

        public BindingList<CPU_Register<float>> FloatRegisters;

        public BindingList<CPU_MemoryCell> Memory;

        //CPU - UI Manager

        public CPU_UI_Manager UI_Manager;

        // Constructors

        public CPU(System.Windows.Forms.DataGridView grid_int, System.Windows.Forms.DataGridView grid_float, System.Windows.Forms.DataGridView grid_memory)
        {
            //Register Lists

            this.IntegerRegisters = new BindingList<CPU_Register<int>>();

            this.FloatRegisters = new BindingList<CPU_Register<float>>();

            this.Memory = new BindingList<CPU_MemoryCell>();

            //Create Memory

            CreateMemory();

            //Create Registers

            CreateRegisters();

            //Create UI Manager

            this.UI_Manager = new CPU_UI_Manager(this, grid_int, grid_float, grid_memory);
        }

        // Create Memory
        private void CreateMemory()
        {
            int adr = 0;

            for(int x = 0; x < 64; x++ )
            {
                this.Memory.Add(new CPU_MemoryCell(0, adr));
                adr += 4;
            }

        }

        // Create Registers
        private void CreateRegisters()
        {
            //Integer Registers
            this.IntegerRegisters.Add(new CPU_Register<int>(0, "zero", 0));

            this.IntegerRegisters.Add(new CPU_Register<int>(1, "at", 0));

            this.IntegerRegisters.Add(new CPU_Register<int>(2, "v0", 0));
            this.IntegerRegisters.Add(new CPU_Register<int>(3, "v1", 0));

            this.IntegerRegisters.Add(new CPU_Register<int>(4, "a0", 0));
            this.IntegerRegisters.Add(new CPU_Register<int>(5, "a1", 0));
            this.IntegerRegisters.Add(new CPU_Register<int>(6, "a2", 0));
            this.IntegerRegisters.Add(new CPU_Register<int>(7, "a3", 0));

            this.IntegerRegisters.Add(new CPU_Register<int>(8, "t0", 0));
            this.IntegerRegisters.Add(new CPU_Register<int>(9, "t1", 0));
            this.IntegerRegisters.Add(new CPU_Register<int>(10, "t2", 0));
            this.IntegerRegisters.Add(new CPU_Register<int>(11, "t3", 0));
            this.IntegerRegisters.Add(new CPU_Register<int>(12, "t4", 0));
            this.IntegerRegisters.Add(new CPU_Register<int>(13, "t5", 0));
            this.IntegerRegisters.Add(new CPU_Register<int>(14, "t6", 0));
            this.IntegerRegisters.Add(new CPU_Register<int>(15, "t7", 0));

            this.IntegerRegisters.Add(new CPU_Register<int>(16, "s0", 0));
            this.IntegerRegisters.Add(new CPU_Register<int>(17, "s1", 0));
            this.IntegerRegisters.Add(new CPU_Register<int>(18, "s2", 0));
            this.IntegerRegisters.Add(new CPU_Register<int>(19, "s3", 0));
            this.IntegerRegisters.Add(new CPU_Register<int>(20, "s4", 0));
            this.IntegerRegisters.Add(new CPU_Register<int>(21, "s5", 0));
            this.IntegerRegisters.Add(new CPU_Register<int>(22, "s6", 0));
            this.IntegerRegisters.Add(new CPU_Register<int>(23, "s7", 0));

            this.IntegerRegisters.Add(new CPU_Register<int>(24, "t8", 0));
            this.IntegerRegisters.Add(new CPU_Register<int>(25, "t9", 0));

            this.IntegerRegisters.Add(new CPU_Register<int>(26, "k0", 0));
            this.IntegerRegisters.Add(new CPU_Register<int>(27, "k1", 0));

            this.IntegerRegisters.Add(new CPU_Register<int>(28, "gp", 0));
            this.IntegerRegisters.Add(new CPU_Register<int>(29, "sp", 0));
            this.IntegerRegisters.Add(new CPU_Register<int>(30, "fp", 0));
            this.IntegerRegisters.Add(new CPU_Register<int>(31, "ra", 0));

            //Float Registers
            this.FloatRegisters.Add(new CPU_Register<float>(0, "f0", 0));
            this.FloatRegisters.Add(new CPU_Register<float>(1, "f1", 0));
            this.FloatRegisters.Add(new CPU_Register<float>(2, "f2", 0));
            this.FloatRegisters.Add(new CPU_Register<float>(3, "f3", 0));
            this.FloatRegisters.Add(new CPU_Register<float>(4, "f4", 0));
            this.FloatRegisters.Add(new CPU_Register<float>(5, "f5", 0));
            this.FloatRegisters.Add(new CPU_Register<float>(6, "f6", 0));
            this.FloatRegisters.Add(new CPU_Register<float>(7, "f7", 0));
            this.FloatRegisters.Add(new CPU_Register<float>(8, "f8", 0));
            this.FloatRegisters.Add(new CPU_Register<float>(9, "f9", 0));
            this.FloatRegisters.Add(new CPU_Register<float>(10, "f10", 0));
            this.FloatRegisters.Add(new CPU_Register<float>(11, "f11", 0));
            this.FloatRegisters.Add(new CPU_Register<float>(12, "f12", 0));
            this.FloatRegisters.Add(new CPU_Register<float>(13, "f13", 0));
            this.FloatRegisters.Add(new CPU_Register<float>(14, "f14", 0));
            this.FloatRegisters.Add(new CPU_Register<float>(15, "f15", 0));
            this.FloatRegisters.Add(new CPU_Register<float>(16, "f16", 0));
            this.FloatRegisters.Add(new CPU_Register<float>(17, "f17", 0));
            this.FloatRegisters.Add(new CPU_Register<float>(18, "f18", 0));
            this.FloatRegisters.Add(new CPU_Register<float>(19, "f19", 0));
            this.FloatRegisters.Add(new CPU_Register<float>(20, "f20", 0));
            this.FloatRegisters.Add(new CPU_Register<float>(21, "f21", 0));
            this.FloatRegisters.Add(new CPU_Register<float>(22, "f22", 0));
            this.FloatRegisters.Add(new CPU_Register<float>(23, "f23", 0));
            this.FloatRegisters.Add(new CPU_Register<float>(24, "f24", 0));
            this.FloatRegisters.Add(new CPU_Register<float>(25, "f25", 0));
            this.FloatRegisters.Add(new CPU_Register<float>(26, "f26", 0));
            this.FloatRegisters.Add(new CPU_Register<float>(27, "f27", 0));
            this.FloatRegisters.Add(new CPU_Register<float>(28, "f28", 0));
            this.FloatRegisters.Add(new CPU_Register<float>(29, "f29", 0));
            this.FloatRegisters.Add(new CPU_Register<float>(30, "f30", 0));
            this.FloatRegisters.Add(new CPU_Register<float>(31, "f31", 0));
        }

        //Functions
        public void Reset()
        {
            for (int i = 0; i < 32; i++)
            {
                IntegerRegisters[i].Value = 0;
                FloatRegisters[i].Value = 0.0f;                
            }
        }

        public int Decode(CPU_Instruction instruction)
        {
            int op1 = 0, op2 = 0, target_reg_search_idx = 0, op_reg1_idx = 0, op_reg2_idx = 0;

            bool single_operand = false;

            target_reg_search_idx = MatchIntegerRegister(instruction.destinationRegisterName);

            if (target_reg_search_idx == -1)
                return -1;            

            if(instruction.operands.Count() == 1)
            {
                op_reg1_idx = MatchIntegerRegister(instruction.operands[0].operand_reg);

                if (op_reg1_idx == -1)
                    return -1;

                op1 = this.IntegerRegisters[op_reg1_idx].Value + instruction.operands[0].offset;

                if (instruction.instruction_name == "move")
                    op1 = this.IntegerRegisters[op_reg1_idx].Value;

                single_operand = true;
            }
            else
            {
                if (instruction.operands[0].type == CPU_Instruction_Operand.OperandType.Register)
                {
                    op_reg1_idx = MatchIntegerRegister(instruction.operands[0].operand_reg);

                    if (op_reg1_idx == -1)
                        return -1;

                    op1 = this.IntegerRegisters[op_reg1_idx].Value;
                }
                else op1 = instruction.operands[0].operand_int;

                if (instruction.operands[1].type == CPU_Instruction_Operand.OperandType.Register)
                {
                    op_reg2_idx = MatchIntegerRegister(instruction.operands[1].operand_reg);

                    if (op_reg2_idx == -1)
                        return -1;

                    op2 = this.IntegerRegisters[op_reg2_idx].Value;
                }
                else op2 = instruction.operands[1].operand_int;
            }

            try
            {
                Instruction_Set matched_inst = (Instruction_Set)Enum.Parse(typeof(Instruction_Set), instruction.instruction_name);

                if (Verify_Match(instruction, target_reg_search_idx, matched_inst, op1, op2, single_operand) == false)
                    return -1;

                Execute(target_reg_search_idx, matched_inst, op1, op2, single_operand);

                return 0;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        private bool Verify_Match(CPU_Instruction instruction, int target_reg_search_idx, Instruction_Set matched_inst, int op1, int op2, bool single_operand)
        {
            switch (matched_inst)
            {
                case Instruction_Set.add:

                    if (single_operand)
                        return false;

                    if (instruction.instructionType != CPU_Instruction.InstructionType.Register)
                        return false;

                    break;

                case Instruction_Set.addi:

                    if (single_operand)
                        return false;

                    if (instruction.instructionType != CPU_Instruction.InstructionType.Immidiate)
                        return false;

                    break;

                case Instruction_Set.addiu:

                    if (single_operand)
                        return false;

                    if (instruction.instructionType != CPU_Instruction.InstructionType.Immidiate)
                        return false;

                    break;

                case Instruction_Set.sub:

                    if (single_operand)
                        return false;

                    if (instruction.instructionType != CPU_Instruction.InstructionType.Register)
                        return false;

                    break;

                case Instruction_Set.mul:

                    if (single_operand)
                        return false;

                    if (instruction.instructionType != CPU_Instruction.InstructionType.Register)
                        return false;

                break;

                case Instruction_Set.div:

                    if (single_operand)
                        return false;

                    if (instruction.instructionType != CPU_Instruction.InstructionType.Register)
                        return false;

                break;

                case Instruction_Set.muli:

                    if (single_operand)
                        return false;

                    if (instruction.instructionType != CPU_Instruction.InstructionType.Immidiate)
                        return false;

                break;

                case Instruction_Set.divi:

                    if (single_operand)
                        return false;

                    if (instruction.instructionType != CPU_Instruction.InstructionType.Immidiate)
                        return false;

                break;


                case Instruction_Set.lw:

                    if (single_operand == false)
                        return false;

                    if (instruction.instructionType != CPU_Instruction.InstructionType.Memory)
                        return false;

                    break;

                case Instruction_Set.sw:

                    if (single_operand == false)
                        return false;

                    if (instruction.instructionType != CPU_Instruction.InstructionType.Memory)
                        return false;

                    break;

                case Instruction_Set.move:

                    if (single_operand == false)
                        return false;

                    if (instruction.instructionType != CPU_Instruction.InstructionType.Register)
                        return false;

                    break;

                case Instruction_Set.INVALID:
                        return false;

                default:
                    return false;
            }

            return true;
        }

        public void Execute(int target_register_idx, Instruction_Set instruction, int op1, int op2, bool single_operand)
        {
            switch (instruction)
            {
                case Instruction_Set.add:
                    this.IntegerRegisters[target_register_idx].Value = op1 + op2;
                    break;

                case Instruction_Set.addi:
                    this.IntegerRegisters[target_register_idx].Value = op1 + op2;
                    break;

                case Instruction_Set.mul:
                    this.IntegerRegisters[target_register_idx].Value = op1 * op2;
                    break;

                case Instruction_Set.div:
                    this.IntegerRegisters[target_register_idx].Value = (int)(op1 / op2);
                    break;

                case Instruction_Set.muli:
                    this.IntegerRegisters[target_register_idx].Value = op1 * op2;
                    break;

                case Instruction_Set.divi:
                    this.IntegerRegisters[target_register_idx].Value = (int)(op1 / op2);
                    break;

                case Instruction_Set.addiu:
                    this.IntegerRegisters[target_register_idx].Value = (int)((uint)((uint)op1 + (uint)op2));
                    break;

                case Instruction_Set.sub:
                    this.IntegerRegisters[target_register_idx].Value = op1 - op2;
                    break;

                case Instruction_Set.lw:
                    this.IntegerRegisters[target_register_idx].Value = Memory[op1/4].Value;
                    break;

                case Instruction_Set.sw:
                    Memory[op1 / 4].Value = this.IntegerRegisters[target_register_idx].Value;
                    break;

                case Instruction_Set.move:
                    this.IntegerRegisters[target_register_idx].Value = 0 + op1;
                    break;
 
                default:
                    break;
            }
        }

        private int MatchIntegerRegister(string name)
        {
            for (int i = 0; i < 32; i++)
            {
                if (this.IntegerRegisters[i].Name == name || this.IntegerRegisters[i].Register == name)
                    return i;
            }

            return -1;
        }      

        /*
   public void Execute(CPU_Register<float> target_register, CPU_Register<float> op1, CPU_Register<float> op2)
   {

   }

   public void Execute(CPU_Register<float> target_register, CPU_Register<float> op1, float op2)
   {

   }

   public void Execute(CPU_Register<float> target_register, int address)
   {

   }*/

        /*public int TakeInstruction(CPU_Instruction instruction)
        {
            CPU_Register<int> operand_reg1 = null, operand_reg2 = null;

            ExecutionObject executionObject;

            switch (instruction.operands.Count())
            {
                case 2:
                    operand_reg1 = MatchRegister(instruction.operands[0].operand_reg);

                    if (operand_reg1 == null)
                        return -1;

                    executionObject = Decode(instruction, operand_reg1, operand_reg2);

                    if (executionObject.object_valid)
                    {
                        this.Execute(executionObject);

                        return 0;
                    }
                    else return - 1;

                case 3:

                    if(instruction.operands[0].type == CPU_Instruction_Operand.OperandType.Register)
                    {
                        operand_reg1 = MatchRegister(instruction.operands[0].operand_reg);

                        if (operand_reg1 == null)
                            return -1;
                    }

                    if (instruction.operands[1].type == CPU_Instruction_Operand.OperandType.Register)
                    {
                        operand_reg2 = MatchRegister(instruction.operands[1].operand_reg);

                        if (operand_reg2 == null)
                            return -1;                        
                    }

                    executionObject = Decode(instruction, operand_reg1, operand_reg2);

                    if (executionObject.object_valid)
                    {
                        this.Execute(executionObject);

                        return 0;
                    }
                    else return -1;

                default:
                    return -1;
            }
        }

        public ExecutionObject Decode(CPU_Instruction instruction, CPU_Register<int> operand_1_reg , CPU_Register<int> operand_2_reg)
        {
            ExecutionObject executionObject = new ExecutionObject();

            executionObject.object_valid = false;

            executionObject.instruction = MatchInstruction(instruction.instruction_name);

            if(executionObject.instruction == Instruction_Set.INVALID)
                return executionObject;

            executionObject.target_register = MatchRegister(instruction.destinationRegisterName);

            if (executionObject.target_register == null)
                return executionObject;

            executionObject.single_operand = instruction.operands.Count() == 2;

            if (executionObject.single_operand)
            {
                executionObject.operand_1 = operand_1_reg.Value + instruction.operands[0].offset;
            }
            else
            {
                executionObject.operand_1 = (operand_1_reg != null) ? operand_1_reg.Value:instruction.operands[0].operand_int;

                executionObject.operand_2 = (operand_2_reg != null) ? operand_2_reg.Value : instruction.operands[1].operand_int;
            }

            executionObject.object_valid = true;

            return executionObject;
        }

        public void Execute(ExecutionObject executionObject)
        {
            switch (executionObject.instruction)
            {
                case Instruction_Set.add:
                    executionObject.target_register.Value = executionObject.operand_1 + executionObject.operand_2;
                    break;

                case Instruction_Set.addi:
                    break;

                case Instruction_Set.sub:
                    break;

                case Instruction_Set.lw:
                    break;

                case Instruction_Set.sw:
                    break;

                case Instruction_Set.move:
                    break;

                case Instruction_Set.INVALID:
                    return;
            }
        }

        private CPU_Register<int> MatchRegister(string name)
        {
            return this.IntegerRegisters.First(x => x.Name == name || x.Register == name);
        }

        private Instruction_Set MatchInstruction(string inst_name)
        {
            return Instruction_Set.INVALID;
        }*/

    }
}
