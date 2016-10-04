using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var a in Returns())
            {
                Console.WriteLine(a);
            }
            Console.ReadLine();
        }
        static IEnumerable<int> Returns()
        {
            yield return 1;
            yield return 2;
        }
    }
}
