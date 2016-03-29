using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    internal class Test : IComparable<Test>
    {
        private int number;

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public int Add(int x, int y)
        {
            return number = x + 2 * y;
        }

        public int CompareTo(Test other)
        {
            if (this.Number > other.Number)
                return 1;
            else if (this.Number == other.Number)
                return 0;
            else
                return -1;
        }
    }
}