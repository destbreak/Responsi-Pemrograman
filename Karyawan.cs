using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman2649
{
    public class Karyawan
    {
        public int Data { get; set; }
        public int NIK { get; set; }
        public string Name { get; set; }
        public int MonthlySalary { get; set; }

        public Karyawan(int number, int id, string name, int salary)
        {
            if(salary < 0)
            {
                salary = 0;
            }

            Data = number;
            NIK = id;
            Name = name;
            MonthlySalary = salary;
        }

        public void ShowEmployeeInformation()
        {
            Console.WriteLine("{0}. \t{1}  {2} \tRp. {3}", Data, NIK, Name, MonthlySalary);
        }

        public void SalaryIncreases() {
            MonthlySalary = MonthlySalary + Convert.ToInt32(MonthlySalary * 0.1);
            Console.WriteLine("{0}. \t{1}  {2} \tRp. {3}", Data, NIK, Name, MonthlySalary);
        }
    }
}
