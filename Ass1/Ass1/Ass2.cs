using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass1
{
    internal class Ass2
    {
        public static void Main()
        {
            try
            {
                int[] marks = new int[5];
                int sum = 0;
                float average;
                int highest = 0;
                Console.WriteLine("Enetr Marks:");
                for (int i = 0; i < marks.Length; i++)
                {
                    marks[i] = int.Parse(Console.ReadLine());
                }
                for (int i = 0; i < marks.Length; i++)
                {
                    sum += marks[i];
                    if (marks[i] > highest)
                    {
                        highest = marks[i];
                    }
                }
                average = sum / 5;
                Console.WriteLine("Average = {0} Highest{1}", average, highest);

            }
            catch (Exception Error)
            {
                Console.WriteLine(Error.ToString());
            }
            finally
            {
                Console.WriteLine("Final");
            }
            Console.ReadLine();

        }
    }
}
