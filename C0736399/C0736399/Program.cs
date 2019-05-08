using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0736399
{
    class Program
    {
        static void Main(string[] args)
        {
            Method m = new Method();
            m.Output();

            Console.ReadKey();
        }
    }

    class Method
    {
        public void Output()
        {
            int start = 1098;
            int sum = 0;
            while (start >= 514)
            {
                Console.WriteLine(start);
                sum = sum + start;
                start =start-33;
            }
            Console.WriteLine("Sum is " + sum);
        }
    }
}
