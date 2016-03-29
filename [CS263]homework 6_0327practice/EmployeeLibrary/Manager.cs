using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class Manager : Employee
    {
        private int performance;

        public int Performance
        {
            get
            {
                return this.performance;
            }
            set
            {
                if (value <= 100000)
                    this.performance = 0;
                else if (value >= 50000)
                    this.performance = (int)(value * 1.2);
                else if (value >= 10000 && value < 50000)
                    this.performance = value;
            }
        }

        public Manager(string id, string name, int baseSalary, int performance)
            : base(id, name, baseSalary)
        {
            this.Performance = performance;
        }

        public override int BaseSalary
        {
            get
            {
                return base.BaseSalary;
            }
            set
            {
                if (value < 50000)
                    base.baseSalary = 50000;
                else
                    base.baseSalary = value;
            }
        }

        public override int TotalSalary
        {
            get
            {
                base.totalSalary = this.BaseSalary + this.Performance;
                return base.totalSalary;
            }
        }

        public override string ToString()
        {
            return string.Format(base.ToString() + "業績;{0}", this.Performance);
        }

        public Manager(string id, string name, string baseSalary, string performance)
            : this(id, name, int.Parse(baseSalary), int.Parse(performance))
        {
        }
    }
}