using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This class is for representing the registers of a CPU

namespace MIPS
{
    class CPU_Register<T> 
    {
        //Fields

        private int id;

        private string name;

        private string prefix;

        private T value;

        //Properities

        public string Name { get => "$" + Convert.ToString(id); set => name = value; }

        public string Prefix { get => prefix; }

        public T Value { get => value; set => this.value = value; }

        //Constructor

        public CPU_Register(int id, string prefix, T value)
        {
            this.id = id;
            this.prefix = prefix;
            this.value = value;
        }

        public int getID()
        {
            return this.id;
        }
    }
}
