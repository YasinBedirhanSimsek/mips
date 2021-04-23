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

        }
   
    }
}
