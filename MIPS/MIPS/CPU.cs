using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Instruction_Set matched_inst = (Instruction_Set)Enum.Parse(typeof(Instruction_Set), instruction.instruction_name);

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
            and,
            andi,
            or,
            ori,
            sub,
            lw,
            sw, 
            move,
            INVALID
        }

        //Register Lists

        public List<CPU_Instruction> CPU_Program;

        public BindingList<CPU_Register<int>> IntegerRegisters;

        public BindingList<CPU_Register<float>> FloatRegisters;

        public BindingList<CPU_MemoryCell> Memory;

        private int PC;

        //Operation Flags

        public bool N, Z, C, V;

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

            //Program Counter

            this.PC = 0;
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
                Memory[i].Value = 0;
            }

            PC = 0;

            N = false;
            Z = false;
            C = false;
            V = false;
        }

        public int Tick()
        {
            CPU_Instruction instruction = Fetch();

            if (instruction == null) return 1;

            if(instruction.name.EndsWith(".s"))
            {
                Decode<float>(instruction);
            }
            else
            {
                Decode<int>(instruction);
            }        

            return 0;
        }

        private CPU_Instruction Fetch()
        {
            return CPU_Program[PC].instruction_type != Instruction_Type.Invalid ? CPU_Program[PC] : null;
        }

        private int Decode<T>(CPU_Instruction instruction)
        {
            try
            {
                Instruction_Set matched_inst = (Instruction_Set)Enum.Parse(typeof(Instruction_Set), instruction.name);

                switch (instruction)
                {
                    case CPU_Instruction_R ins_r:
                            
                        break;

                    case CPU_Instruction_I ins_i:
                           
                        break;

                    case CPU_Instruction_I_Branch ins_i_branch:
                           
                        break;

                    case CPU_Instruction_I_DataTransfer ins_i_data:
                           
                        break;

                    case CPU_Instruction_J ins_j:
                            
                        break;

                    case CPU_Instruction_J_Register ins_j_reg:
                            
                        break;
                }

                return 0;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        //R 
        private void Execute<T>(Instruction_Set instructionName, CPU_Register<T> destination_reg, CPU_Register<T> op_reg_1, CPU_Register<T> op_reg_2)
        {

        }

        //I
        private void Execute<T>(Instruction_Set instructionName, CPU_Register<T> destination_reg, CPU_Register<T> op_reg, T imm)
        {

        }

        //I-Branch
        private void Execute<T>(Instruction_Set instructionName, CPU_Register<T> destination_reg, CPU_Register<T> op_reg, int new_pc_value)
        {

        }

        //I-Data
        private void Execute<T>(Instruction_Set instructionName, CPU_Register<int> destination_reg, int offset)
        {

        }

        //J
        private void Execute<T>(Instruction_Set instructionName, int new_pc_value)
        {

        }

        //J-R
        private void Execute<T>(Instruction_Set instructionName, CPU_Register<int> pc_reg)
        {

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

        private int MatchFloatingPointRegister(string name)
        {
            for (int i = 0; i < 32; i++)
            {
                if (this.FloatRegisters[i].Name == name || this.FloatRegisters[i].Register == name)
                    return i;
            }

            return -1;
        }      
    }
}
