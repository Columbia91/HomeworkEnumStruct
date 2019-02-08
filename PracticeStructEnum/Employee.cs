using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeStructEnum
{
    public struct Employee
    {
        public string Name { get; set; }
        public Vacancies Vacancy { get; set; }
        public int Salary { get; set; }
        public int[] DateOfEngagement { get; set; }
        
        public Employee(string name, Vacancies vacancy, int salary, int[] dateOfEngagement)
        {
            Name = name;
            Vacancy = vacancy;
            Salary = salary;
            DateOfEngagement = dateOfEngagement;
        }
    }
    /*a.	поля name строкового типа;
      b.	поля vacancy типа Vacancies;
      c.	поля зарплата целого типа;
      d.	поля дата приема на работу типа int[3].
    */
}
