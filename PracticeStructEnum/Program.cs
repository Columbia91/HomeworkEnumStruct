using System;
using System.Collections;
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
            int employeeCount = 0;
            
            string[] posts = { "Начальник", "Менеджер", "Бухгалтер", "Клерк", "Торговый агент" };
            List<int> eachPostCounts = new List<int>(5);

            Console.Write("Введите количество сотрудников:\n\n");
            eachPostCounts.Insert(0,1);
            employeeCount += eachPostCounts[0];
            for (int i = 1; i < posts.Length; i++)
            {
                Console.Write($"{posts[i]}: ");
                eachPostCounts.Add(int.Parse(Console.ReadLine()));
                employeeCount += eachPostCounts[i];
            }
            
            Employee[] employees = new Employee[employeeCount];

            DataEntry(employees, posts, eachPostCounts);
            WorkersEngagedAfterBoss(employees, employees[0].DateOfEngagement);
            
        }
        public static void DataEntry(Employee[] employees, string[] posts, List<int> eachPostCounts)
        {
            int iterator = 0;
            for (int i = 0; i < posts.Length; i++)
            {
                Console.Clear();
                Console.WriteLine("Введите данные  сотрудника");
                for (int j = 0; j < eachPostCounts[i]; j++)
                {
                    Console.Write($"\nДолжность:\t{posts[i]}\n"); employees[iterator].Post = (Positions)iterator;
                    Console.Write("Полное имя:\t"); employees[iterator].Name = Console.ReadLine();
                    Console.Write("Зарплата:\t"); employees[iterator].Salary = int.Parse(Console.ReadLine());
                    Console.Write("Дата приема:\t"); employees[iterator].DateOfEngagement = DateTime.Parse(Console.ReadLine());
                }
                iterator++;
                Console.WriteLine();
            }
        }
        public static void WorkersEngagedAfterBoss(Employee[] employees, DateTime bossDateOfEngagement)
        {
            Console.Clear();
            Array.Sort(employees, new SortByName());
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i].DateOfEngagement > bossDateOfEngagement)
                    employees[i].Show();
                Console.WriteLine("\n");
            }
        }
    }
}
//foreach (var item in Enum.GetNames(typeof(Positions)))