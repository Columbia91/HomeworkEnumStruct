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
            SortedList<string, int> PostAndCount = new SortedList<string, int>();

            Console.Write("Введите количество сотрудников:\n\n");
            
            foreach (var item in Enum.GetNames(typeof(Positions)))
            {
                Console.Write($"{item}: ");
                if(item == (Positions.Boss).ToString())
                {
                    PostAndCount.Add(item, 1);
                    Console.WriteLine(PostAndCount[item]);
                    continue;
                }
                PostAndCount.Add(item, int.Parse(Console.ReadLine()));
                employeeCount += PostAndCount[item];
            }
            
            Employee[] employees = new Employee[employeeCount];

            DataEntry(employees, PostAndCount);
            WorkersEngagedAfterBoss(employees, employees[0].DateOfEngagement);
            
        }
        public static void DataEntry(Employee[] employees, SortedList<string, int> PostAndCount)
        {
            int iterator = 0;
            foreach (var item in Enum.GetNames(typeof(Positions)))
            {
                Console.Clear();
                Console.WriteLine("Введите данные  сотрудника");
                for (int j = 0; j < PostAndCount[item]; j++)
                {
                    Console.Write($"\nДолжность:\t{item}\n"); employees[iterator].Post = (Positions)iterator;
                    Console.Write("Полное имя:\t"); employees[iterator].Name = Console.ReadLine();
                    Console.Write("Зарплата:\t"); employees[iterator].Salary = int.Parse(Console.ReadLine());
                    Console.Write("Дата приема:\t"); employees[iterator].DateOfEngagement = DateTime.Parse(Console.ReadLine());
                }
                iterator++;
                Console.WriteLine();
            }
        }
        public static void TopManagers(Employee[] employees)
        {
            int totalClerkSalary = 0;
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i].Post == Positions.Clerk)
                {
                    totalClerkSalary += employees[i].Salary;
                }
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
