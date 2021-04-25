using System;
using System.Collections.Generic;
using System.Drawing;
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

        private int last_cursor;

        public Simulator(CPU cpu, RichTextBox editor)
        {
            this.editor = editor;

            this.cpu = cpu;
        }

        public void Start()
        {
            lines = this.editor.Text.Split('\n').ToList();

            last_cursor = 0;
            step_line_index = 0;

            this.editor.Select(0, this.editor.Text.Length);
            this.editor.SelectionColor = Color.Chartreuse;
            this.editor.Select(last_cursor, this.editor.Lines[step_line_index].Length);
            this.editor.SelectionColor = Color.Red;
        }

        public void Reset()
        {
            this.cpu.Reset();

            this.cpu.UI_Manager.Update();
        }

        public void NextStep()
        {
            if (step_line_index >= lines.Count)
            {
                this.editor.Select(0, this.editor.Text.Length);
                this.editor.SelectionColor = Color.Blue;

                return;
            }

            if (lines[step_line_index].Trim().Length == 0)
            {
                step_line_index++;
                last_cursor += lines[step_line_index - 1].Length + 1;
                this.editor.Select(last_cursor, this.editor.Lines[step_line_index].Length);
                this.editor.SelectionColor = Color.Red;
                return;
            }
  
            CPU_Instruction instruction = Parser.Fetch(lines[step_line_index++]);

            if(instruction == null || cpu.Decode(instruction) == -1)
            {
                MessageBox.Show("Error At " + (step_line_index).ToString());
            }

            if (step_line_index >= lines.Count)
            {
                this.editor.Select(0, this.editor.Text.Length);
                this.editor.SelectionColor = Color.Blue;

                return;
            }

            last_cursor += lines[step_line_index - 1].Length+1;

            this.editor.Select(last_cursor, this.editor.Lines[step_line_index].Length);
            this.editor.SelectionColor = Color.Red;
        }
    }
}
