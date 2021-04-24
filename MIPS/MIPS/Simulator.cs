using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIPS
{
    class Simulator
    {
        private CPU cpu;

        private RichTextBox editor;

        private List<string> lines;

        private int step_line_index = 0;

        public Simulator(CPU cpu, RichTextBox editor)
        {
            this.editor = editor;

            this.cpu = cpu;
        }

        public void Start()
        {
            lines = this.editor.Text.Split('\n').ToList();

            step_line_index = 0;
        }

        public void Reset()
        {
            this.cpu.Reset();
        }

        public void NextStep()
        {
            if (step_line_index >= lines.Count)
                return;

            CPU_Instruction instruction = Parser.ParseNextInstruction(lines[step_line_index++]);

            if (step_line_index >= lines.Count)
                return;

            cpu.Decode(instruction);
        }
    }
}
