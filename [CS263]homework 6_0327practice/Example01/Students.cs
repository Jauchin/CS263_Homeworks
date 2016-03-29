using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    public class Students
    {
        private List<Student> students;

        public Students()
        {
            students = new List<Student>();
        }

        public void Add(Student someone)
        {
            this.students.Add(someone);
        }

        public void Add(string name, float chinese, float english, float math)
        {
            this.students.Add(new Student(name, chinese, english, math));
        }

        public void Remove(Student someone)
        {
            this.students.Remove(someone);
        }

        public void Sort()
        {
            this.students.Sort();
        }

        public void Sort(int selectedSubject)
        {
            Student.selectedSubject = selectedSubject;
            this.students.Sort();
        }

        public override string ToString()
        {
            string result = string.Empty;
            result += string.Format("姓名 國文 英文 數學 總分\n");
            foreach (Student student in students)
                result += string.Format("{0} {1} {2} {3} {4}\n"

                    , student.Name
                    , student.Chinese
                    , student.English
                    , student.Math
                    , student.TotalGrade
                    );

            return result;
        }
    }
}