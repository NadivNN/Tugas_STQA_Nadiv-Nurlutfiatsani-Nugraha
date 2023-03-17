using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace STQA
{
    /// <summary>
    /// main class
    /// </summary>
    /// <remacks> class Program dapat membuat operasi pembagian</remacks>
    class Program
    {
        /// <summary>
        /// operasi pembagian
        /// </summary>
        /// <param name="a">angka pertama untuk menambahkan angka di dalam operasi pembagian </param>
        /// <param name="b">angka kedua yang ditambahkan ke dalam operasi pembagian </param>
        /// <hasil> hasil dari pembagian angka yang sudah di inputkan ke dalam operasi pembagian</hasil>

        static void Main(string[] args)
        {
           

            int a, b;
            decimal bagi;
            System.Console.Write("Masukan bilangan I  : ");
            a = int.Parse(System.Console.In.ReadLine());
            System.Console.Write("Masukan bilangan II : ");
            b = int.Parse(System.Console.In.ReadLine());

            bagi = a / b;

            System.Console.WriteLine("Hasil pembagian " + bagi);
            System.Console.ReadLine();
        }
    }
}