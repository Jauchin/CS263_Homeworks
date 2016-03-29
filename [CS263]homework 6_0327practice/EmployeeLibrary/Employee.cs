using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class Employee
    {
        public Employee()
        {
        }

        public Employee(string id, string name, int baseSalary)
        {
            this.Id = id;
            this.Name = name;
            this.BaseSalary = baseSalary;
        }

        public Employee(string id, string name, string baseSalary)
            : this(id, name, int.Parse(baseSalary))
        {
        }

        protected int totalSalary;

        virtual public int TotalSalary
        {
            get
            {
                this.totalSalary = this.BaseSalary;
                return totalSalary;
            }
        }

        public string Name { get; set; }
        public string Id { get; set; }
        protected int baseSalary;

        virtual public int BaseSalary
        {
            get { return this.baseSalary; }
            set
            {
                if (value > 50000)
                    this.baseSalary = 50000;
                else if (value >= 22000 && value <= 50000)
                    this.baseSalary = value;
                else
                    this.baseSalary = 22000;
            }
        }

        public override string ToString()
        {
            string result = string.Empty;
            result += string.Format("員工編號:{0}, 員工姓名:{1}\n", this.Id, this.Name);
            result += string.Format("員工底資:{0}, 員工薪水總計: {1}\n", this.BaseSalary, this.TotalSalary);
            return result;
        }
    }
}