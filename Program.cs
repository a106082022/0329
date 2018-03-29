using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0329
{
    class Program
    {
        static void Main(string[] args)
        {
            //   string[] genders = {}

            string[] bloods = { "O", "其他", "O", "O", "A", "O", "A", "A", "O", "O", "A", "O", "A", "B", "O", "O", "A", "其他", "O", "O", "A", "", "B", "O", "", "O", "B", "O", "B", "B", "B", "O", "O", "AB", "O", "B", "A", "O", "O", "", "O", "A", "", "O", "O", "A", "O", "O", "其他", "B", "O", "O", "O", "A", "AB", "A", "O", "B", "AB", "", "O", "O", "O", "", "O", "A", "A", "O" };


            int count = 0;
            int countA = 0;
            int countB = 0;
            for (int i = 0; i < bloods.Length; i++)
            {
                Console.WriteLine(bloods[i]);

                if (bloods[i] == "O")
                {
                    count += 1;
                }
            }

                for (int j = 0; j < bloods.Length; j++)
                {
                    Console.WriteLine(bloods[j]);

                    if (bloods[j] == "A")
                    {
                        countA += 1;
                    }


                }
            for (int k = 0; k < bloods.Length; k++)
            {
                Console.WriteLine(bloods[k]);

                if (bloods[k] == "B")
                {
                    countB += 1;
                }


            }
                Console.WriteLine("O型人數:" + count);
                Console.WriteLine("A型人數:" + countA);
                 Console.WriteLine("B型人數:" + countB);
            Console.ReadKey();

            }
        }
    }

