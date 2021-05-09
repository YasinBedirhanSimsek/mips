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

        Simulator simulator;

        public Form1()
        {            
            InitializeComponent();

            richTextBox1.Select(0, richTextBox1.Text.Length);
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;

            this.simulator = new Simulator(intRegistersGridView, floatRegistersGridView, memoryDataGridView, textEditor, ParsedInstructionList);
        }

        private void btn_sim_nextStep_Click(object sender, EventArgs e)
        {
            simulator.NextStep();
        }

        private void btn_simulate_Click(object sender, EventArgs e)
        {
            simulator.Reset();

            if (simulator.Start() == 0)
            {
                btn_sim_nextStep.Enabled = true;
            };
        }
    }
}
