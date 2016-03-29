using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    public class Student : IComparable<Student>, IComparer<Student>
    {
        public static int selectedSubject { get; set; }

        private string name;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public Grade[] grades;

        public Student()
        {
        }

        public Student(Student student)
        {
            this.Name = student.Name;
            this.grades = new Grade[student.grades.Length];
            for (int index = 0; index < this.grades.Length; index++)
            {
                this.grades[index] = new Grade() { subject = student.grades[index].subject, Score = student.grades[index].Score };
            }
        }

        public Student(string name, float chinese, float english, float math)
        {
            this.Name = name;
            this.grades = new Grade[3]
            {
               new Grade{subject="國文"},
               new Grade{subject="英文"},
               new Grade{subject="數學"}
            };
            this.grades[0].Score = chinese;
            this.grades[1].Score = english;
            this.grades[2].Score = math;

            //this.chinese = new Grade { subject = "國文", score = chinese };
            //this.english = new Grade { subject = "英文", score = english };
            //this.math = new Grade { subject = "數學", score = math };
        }

        public float Chinese { get { return this.grades[0].Score; } }
        public float English { get { return this.grades[1].Score; } }
        public float Math { get { return this.grades[2].Score; } }

        public Student Clone()
        {
            return new Student(this);
        }

        public override string ToString()
        {
            string result = string.Empty;
            result += string.Format("學生姓名: {0}\n", this.name);
            result += string.Format("{0}\n", this.grades[0]);
            result += string.Format("{0}\n", this.grades[1]);
            result += string.Format("{0}\n", this.grades[2]);
            result += string.Format("總分: {0}\n", this.TotalGrade);
            return result;
        }

        private float totalGrade;

        public float TotalGrade
        {
            get
            {
                totalGrade = 0.0f;
                for (int index = 0; index < this.grades.Length; index++)
                {
                    totalGrade += this.grades[index].Score;
                }
                return totalGrade;
            }
        }

        public Student SetGrade(float chinese, float english, float math)
        {
            this.grades = new Grade[3]
            {
               new Grade{subject="國文"},
               new Grade{subject="英文"},
               new Grade{subject="數學"}
            };
            this.grades[0].Score = chinese;
            this.grades[1].Score = english;
            this.grades[2].Score = math;

            return this;

            //this.chinese = new Grade { subject = "國文", score = chinese };
            //this.english = new Grade { subject = "英文", score = english };
            //this.math = new Grade { subject = "數學", score = math };
            //return this;
        }

        public int CompareTo(Student other)
        {
            switch (Student.selectedSubject)
            {
                case 1:
                    if (this.Chinese > other.Chinese)
                        return 1;
                    else if (this.Chinese == other.Chinese)
                        return 0;
                    else
                        return -1;

                case 2:
                    if (this.English > other.English)
                        return 1;
                    else if (this.English == other.English)
                        return 0;
                    else
                        return -1;

                case 3:
                    if (this.Math > other.Math)
                        return 1;
                    else if (this.Math == other.Math)
                        return 0;
                    else
                        return -1;

                case 4:
                    if (this.TotalGrade > other.TotalGrade)
                        return 1;
                    else if (this.TotalGrade == other.TotalGrade)
                        return 0;
                    else
                        return -1;

                default:
                    return 0;
            }
        }

        int IComparer<Student>.Compare(Student x, Student y)
        {
            switch (Student.selectedSubject)
            {
                case 1:
                    if (x.Chinese > y.Chinese)
                        return 1;
                    else if (x.Chinese == y.Chinese)
                        return 0;
                    else
                        return -1;

                case 2:
                    if (x.English > y.English)
                        return 1;
                    else if (x.English == y.English)
                        return 0;
                    else
                        return -1;

                case 3:
                    if (x.Math > y.Math)
                        return 1;
                    else if (x.Math == y.Math)
                        return 0;
                    else
                        return -1;

                case 4:
                    if (x.TotalGrade > y.TotalGrade)
                        return 1;
                    else if (x.TotalGrade == y.TotalGrade)
                        return 0;
                    else
                        return -1;

                default:
                    return 0;
            }
        }
    }
}