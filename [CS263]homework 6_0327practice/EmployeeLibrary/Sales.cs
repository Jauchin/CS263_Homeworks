using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class Sales : Employee
    {
        private int performance;

        public int Performance
        {
            get { return this.performance; }
            set
            {
                if (value < 0)
                    this.performance = 0;
                else
                    this.performance = value;
            }
        }

        public Sales(string id, string name, int baseSalary, int performance)
            : base(id, name, baseSalary)
        {
            this.Performance = performance;
        }

        public override int TotalSalary
        {
            get
            {
                base.totalSalary = this.BaseSalary + this.Performance;
                return base.totalSalary;
            }
        }

        public override int BaseSalary
        {
            get
            {
                return base.BaseSalary;
            }
            set
            {
                base.baseSalary = 22000;
            }
        }

        public override string ToString()
        {
            return string.Format(base.ToString() + "業績;{0}", this.Performance);
        }

        public Sales(string id, string name, string baseSalary, string performance)
            : this(id, name, int.Parse(baseSalary), int.Parse(performance))
        {
        }
    }
}