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
        //Register Lists

        public BindingList<CPU_Register<int>> IntegerRegisters;

        public BindingList<CPU_Register<float>> FloatRegisters;

        //CPU - UI Manager

        public CPU_UI_Manager UI_Manager;

        // Constructors

        public CPU(System.Windows.Forms.DataGridView grid_int, System.Windows.Forms.DataGridView grid_float)
        {
            //Register Lists

            this.IntegerRegisters = new BindingList<CPU_Register<int>>();

            this.FloatRegisters = new BindingList<CPU_Register<float>>();

            //Create Registers

            CreateRegisters();

            //Create UI Manager

            this.UI_Manager = new CPU_UI_Manager(this, grid_int, grid_float);
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

        public void Decode(CPU_Instruction instruction)
        {

        }

        public void Execute()
        {

        }
    }
}
