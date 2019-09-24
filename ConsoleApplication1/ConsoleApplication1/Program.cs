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

            HLine(10, '*'); Console.WriteLine();
            HLine(10, 'a'); Console.WriteLine();
            HLine(10, 'b'); Console.WriteLine();

            VLine(10, '*');
            VLine(10, 'a');
        }

        static void HLine(int n, char c)
        {
            for (int i = 0; i < n; i++)
                Console.Write(c);
        }

        static void VLine(int n,char c)
        {
            for (int i = 0; i < n; i++)
                Console.WriteLine(c);
        }

        static void DLine(int n,char c)
        {

        }
    }
}
