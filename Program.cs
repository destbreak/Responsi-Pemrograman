using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman2649
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan1 = new Karyawan(1, 190302123, "Paijo", 3000000);
            Karyawan karyawan2 = new Karyawan(2, 190302123, "Jono", 2000000);

            Console.Clear();
            Console.WriteLine("\nNo \tNIK / Nama \t\tGaji Bulanan");
            Console.WriteLine("---------------------------------------------");
            karyawan1.ShowEmployeeInformation();
            karyawan2.ShowEmployeeInformation();

            Console.WriteLine("\n\nUntuk mendukung program #WorkFromHome, gaji karyawan naik 10%");

            Console.WriteLine("\nNo \tNIK / Nama \t\tGaji Bulanan");
            Console.WriteLine("---------------------------------------------");
            karyawan1.SalaryIncreases();
            karyawan2.SalaryIncreases();

            Console.ReadKey();
        }
    }
}
