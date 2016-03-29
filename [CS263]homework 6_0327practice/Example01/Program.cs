using EmployeeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Student A = new Student("A", 34, 100, 34);
            Student B = A.Clone();
            Console.WriteLine(A);
            Console.WriteLine(B);
            B.Name = "BBB";
            Console.WriteLine(A);
            Console.WriteLine(B);

            //Students students = new Students();
            //students.Add("A", 78.4f, 45.5f, 32.5f);
            //students.Add("B", 68.4f, 55.5f, 82.5f);
            //students.Add("C", 58.4f, 25.5f, 12.5f);
            //students.Add("D", 38.4f, 95.5f, 52.5f);

            //Console.WriteLine("請選擇排序的項目: 1.國文 2.英文 3.數學 4.總分");

            //students.Sort(int.Parse(Console.ReadLine()));

            //Console.WriteLine(students);

            //Student[] students = new Student[5]
            //{
            //    new Student("AAA", 78.4f, 78.5f, 78.5f),
            //    new Student("BBB", 58.4f, 58.5f, 58.5f),
            //    new Student("CCC", 48.4f, 48.5f, 48.5f),
            //    new Student("DDD", 38.4f, 98.5f, 88.5f),
            //    new Student("EEE", 28.4f, 68.5f, 98.5f)
            //};

            //Console.WriteLine("請輸入要按什麼排序: \n");
            //Console.WriteLine("1.國文 2.英文 3.數學 4.總分: ");
            //Student.selectedSubject = int.Parse(Console.ReadLine());
            //Array.Sort(students);

            //for (int index = 0; index < students.Length; index++)
            //    Console.WriteLine(students[index]);

            //Student aStudent = new Student { Name = "Jauchin" };
            //string name = string.Empty;
            //int chinese = 0;
            //int english = 0;
            //int math = 0;
            //Console.WriteLine("請輸入姓名: ");
            //name = Console.ReadLine();
            //do
            //{
            //    Console.Write("請輸入國文成績: ");
            //} while (!int.TryParse(Console.ReadLine(), out chinese));
            //do
            //{
            //    Console.Write("請輸入英文成績: ");
            //} while (!int.TryParse(Console.ReadLine(), out english));
            //do
            //{
            //    Console.Write("請輸入數學成績: ");
            //} while (!int.TryParse(Console.ReadLine(), out math));
            //aStudent = new Student("AAA", 89.4f, 45.5f, 49.5f);
            //aStudent.grades[0].Score = 2000;
            //aStudent.SetGrade(5000, 34000, 2000);

            //Console.WriteLine(aStudent);

            //    Random rdn = new Random();
            //    for (int index = 0; index < 5; index++)
            //    {
            //        Console.WriteLine(rdn.Next(1, 11));
            //    }

            //{
            //    Random rnd = new Random();
            //    do
            //    {
            //        Console.Write("請猜數字(1~5) : ");
            //        int x;
            //        x = rnd.Next(1, 6);
            //        if (x == int.Parse(Console.ReadLine()))
            //            Console.WriteLine("5選1都能猜中,厲害");
            //        else
            //            Console.WriteLine("沒猜中很正常,正確答案是 {0}", x);
            //        Console.Write("要再玩一遍嗎? (y/n) ");
            //    } while ((Console.ReadLine() == "y") || (Console.ReadLine() == "Y"));
            //}

            //Student[] students = new Student[3];

            //students = new Student[3]
            //    {
            //    students[0]=new Student("Shieh",93.4f,67.9f,56.6f),
            //    students[1]=new Student("BBB",83.4f,87.9f,86.6f),
            //    students[2]=new Student("CCC",73.4f,77.9f,76.6f),
            //     };

            //for (int index = 0; index < students.Length; index++)
            //    Console.WriteLine(students[index]);

            // Console.WriteLine(students[0]);

            //Student[] students = new Student[3];
            //students[0] = new Student { name = "AAA" };
            //students[1] = new Student { name = "BBB" };
            //students[2] = new Student { name = "CCC" };

            //students = new Student[3]
            //{
            //   students[0]= new Student { name = "AAA" }.SetGrade(89.0f, 34.5f, 34.4f),
            //   students[1]= new Student { name = "BBB" }.SetGrade(59.0f, 99.5f, 77.4f),
            //   students[2]= new Student { name = "CCC" }.SetGrade(55.0f, 94.5f,84.4f),
            //};

            // Console.WriteLine(students[1]);

            //Student aStudent = new Student
            //{
            //    name = "Jauchin",
            //    chinese = new Grade { score = 90.3f, subject = "國文" },
            //    english = new Grade { score = 67.3f, subject = "英文" },
            //    math = new Grade { score = 89.3f, subject = "數學" },
            //};

            //Console.WriteLine(aStudent);

            //aStudent.namePlusEmail();
            //Console.WriteLine(aStudent.Add(45, 67));

            //Console.WriteLine("Please input a number");
            //float a = float.Parse(Console.ReadLine());
            //Grade grade1 = new Grade
            //{
            //    score = a,
            //    subject = "國文"
            //};
            //Grade grade2 = new Grade
            //{
            //    score = 87.9f,
            //    subject = "英文"
            //};
            //Console.WriteLine(grade1);
            //Console.WriteLine(grade2);

            //if (a >= 90 && a <= 100)
            //    Console.WriteLine("A+");
            //else if (a >= 80 && a < 90)
            //    Console.WriteLine("B+");
            //else
            //    Console.WriteLine("f");

            //double b;
            //double.TryParse(Console.ReadLine(), out b);
            //Console.WriteLine("your input is{0}", b);

            //Console.WriteLine(a);
            //Console.WriteLine(aStudent.name);
            //Console.WriteLine(aStudent.family.memberCount);
        }
    }
}