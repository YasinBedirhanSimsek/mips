using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace MIPS
{
    public partial class Form1 : Form
    {
        CPU cpu;

        Simulator simulator;

        public Form1()
        {            
            InitializeComponent();

            richTextBox1.Select(0, richTextBox1.Text.Length);
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;

            cpu = new CPU(intRegistersGridView, floatRegistersGridView, memoryDataGridView);

            simulator = new Simulator(cpu, textEditor);          
        }

        private void btn_sim_nextStep_Click(object sender, EventArgs e)
        {
            simulator.NextStep();

            cpu.UI_Manager.Update();
        }

        private void btn_simulate_Click(object sender, EventArgs e)
        {
            simulator.Reset();

            btn_sim_nextStep.Enabled = true;

            simulator.Start();
        }
    }
}
