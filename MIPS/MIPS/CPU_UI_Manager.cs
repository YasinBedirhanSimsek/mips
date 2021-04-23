using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.ComponentModel;

//This class is for managing the UI side of the program 

namespace MIPS
{
    class CPU_UI_Manager
    {
        //UI - DataGridViews for Registers

        public System.Windows.Forms.DataGridView IntegerRegistersDataGridView;

        public System.Windows.Forms.DataGridView FloatRegistersDataGridView;

        public CPU cpu;

        //Constructor

        public CPU_UI_Manager(CPU cpu, System.Windows.Forms.DataGridView grid_int, System.Windows.Forms.DataGridView grid_float)
        {
            //Bind UI_Manager and CPU to Each Other

            this.cpu = cpu;

            this.cpu.UI_Manager = this;

            //Bind UI_Manager DataGridViews to Passed DataGridViews 

            this.IntegerRegistersDataGridView = grid_int;

            this.FloatRegistersDataGridView = grid_float;

            //Bind UI_Manager DataGridViews' DataSources to CPU Register Lists

            this.IntegerRegistersDataGridView.DataSource = cpu.IntegerRegisters;

            this.FloatRegistersDataGridView.DataSource = cpu.FloatRegisters;
        }    

    }
}
