using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuasLingkarancs
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Membuat konstanta

            const float Phi = 3.14f;

            Console.WriteLine("== PROGRAM LUAS LINGKARAN ==");
            Console.Write("Input Jari-Jari: ");
            int r = int.Parse(Console.ReadLine());

            var luas = Phi * r;

            Console.WriteLine($"Luas Lingkaran = {luas}");

        }
    }
}
