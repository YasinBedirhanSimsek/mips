using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIPS
{
    class Parser
    {
        public static CPU_Instruction ParseNextInstruction(string line)
        {
            string line_copy = String.Copy(line); //A copy of the line

            if(line.IndexOf('#') != -1) line = line.Remove(line.IndexOf('#')); //Handle comments

            char[] charsToTrim = { ' ' }; // Delete all empty spaces at the start and at the end of the line

            line = line.Trim(charsToTrim);

            string instruction_name;

            char[] charsToSplit = { ' ' }; 

            var elements = line.Split(charsToSplit).ToList(); //Split the line into elements after each empty space

            if (line[0] != '.') //If not a preprocessor
            {
                //var elements = line.Split(' ').ToList(); //Split the line into elements after each empty space

                if (elements.Count < 2) //Invalid Line Structure
                    return null;

                instruction_name = String.Copy(elements[0]); //Get the instruction name

                elements.RemoveAt(0);

                string str;

                for(int i = 0; i < elements.Count; i++)
                {
                    str = elements[i];

                    elements.RemoveAt(i);

                    elements.InsertRange(i, str.Split(','));
                }

                elements.RemoveAll(x => System.Text.RegularExpressions.Regex.IsMatch(x, @"^[a-zA-Z0-9$()]+$") == false);

            }
            else return null;

            return null;
        }
    }
}
