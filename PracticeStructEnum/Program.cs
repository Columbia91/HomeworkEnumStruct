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
            //Console.Write("Введите количество работников: ");
            //int employeeCount = int.Parse(Console.ReadLine());
            //Employee[] employees = new Employee[employeeCount];

            //Console.WriteLine("\n\nВведите данные сотрудников ");
            //for (int i = 0; i < employees.Length; i++)
            //{
            //    string str = Console.ReadLine();
            //}
            
            foreach (var item in Enum.GetNames(typeof(Vacancies)))
            {
                Console.WriteLine(item);
            }
        }
    }
}
