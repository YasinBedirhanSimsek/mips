using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIPS
{
    class CPU_MemoryCell
    {
        private int value;

        private int address;

        public string Address_Str { get => $"0x{this.getAddress():X8}"; }

        public int Value { get => value; set => this.value = value; }

        public CPU_MemoryCell(int value, int address)
        {
            this.value = value;
            this.address = address;
        }

        public int getAddress()
        {
            return this.address;
        }
    }
}
