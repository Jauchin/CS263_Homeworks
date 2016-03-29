using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    public class Vector : IComparable<Vector>
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Vector()
        {
        }

        public Vector(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public double Length
        {
            get
            {
                return Math.Sqrt(this.X * this.X + this.Y * this.Y);
            }
        }

        public int CompareTo(Vector other)
        {
            if (this.Length > other.Length)
                return 1;
            else if (this.Length == other.Length)
                return 0;
            else
                return -1;
        }
    }
}