using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (i % 2 == 0 && j % 2 == 0)
                    {
                        Console.Write("X");
                    }
                    else if (i % 2 == 0 && j % 2 == 1)
                    {
                        Console.Write("O");
                    }
                    else if (i % 2 == 1 && j % 2 == 0)
                    {
                        Console.Write("O");
                    }
                    else if (i % 2 == 1 && j % 2 == 1)
                    {
                        Console.Write("X");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
