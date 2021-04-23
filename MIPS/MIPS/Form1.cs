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

        int x = 0;

        public Form1()
        {            
            InitializeComponent();

            cpu = new CPU(intRegistersGridView, floatRegistersGridView);
        }

    }
}
