using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeStructEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] date = new int[]{ 2018, 10, 15 };
            Employee employee = new Employee("Bob", Vacancies.Accountant, 250000, date);

            employee.Show();
            Console.ReadLine();
        }
    }
}
