using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет мир!!!");
            Console.WriteLine("Привет мир!!!- Калинин!");
            int[] a = new int[10];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = i;
                Console.Write(a[i] + "\t");
            }
            Console.ReadKey();
        }
    }
}
