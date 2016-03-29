using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Vector[] vectors = new Vector[3]
            {
                new Vector(30.2,35),
                new Vector(35.2,20),
                new Vector(38,15),
            };

            Array.Sort(vectors);

            foreach (Vector vector in vectors)
                Console.WriteLine(vector.Length);
            //for (int index = 0; index < vectors.Length; index++)
            //    Console.WriteLine(vectors[index].Length);

            Test[] testArrays = new Test[6]
            {
                new Test{Number=160},
                new Test{Number=50},
                new Test{Number=650},
                new Test{Number=90},
                 new Test{Number=70},
                  new Test{Number=64},
            };

            Array.Sort(testArrays);
            foreach (Test testArray in testArrays)
                Console.WriteLine(testArray.Number);
            //    for (int index = 0; index < testArray.Length; index++)
            //      Console.WriteLine(testArray[index].Number);
        }
    }
}