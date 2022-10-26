using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass1
{
    internal class Ass4
    {
        public static void Main()
        {
            try
            {
                int n1;
                int n2;
                Console.WriteLine("Enter a Value");
                n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter another Value");
                n2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Before Swapping n1={0} and n2={1}", n1, n2);
                n1 = n1 + n2;
                n2 = n2 - n1;
                n1 = n1 - n2;
                Console.WriteLine("After Swapping n1={0} and n2={1}", n1, n2);
            }
            catch(Exception Error)
            {
                Console.WriteLine(Error.ToString());
            }
            finally
            {
                Console.WriteLine("It is a final value");
            }
            Console.ReadLine();
        }
    }
}
