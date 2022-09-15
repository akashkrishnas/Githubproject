using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Groupby
{
    public enum Departments
    {
        admin, soft
    }
    public class Employee
    {
        public string name { get; set; }
        public Departments department { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var employees = new Employee[]
            {
                new Employee(){name="one",department=Departments.soft},
                new Employee(){name="two",department=Departments.admin},
                new Employee(){name="three",department=Departments.soft},
                new Employee(){name="four",department=Departments.admin},
            };
            var groups = employees.GroupBy(e => e.department);
            foreach (var group in groups)
            {
                Console.WriteLine(group.Key);
                foreach (var emp in group)
                {
                    Console.WriteLine(emp.name);
                }
            }
        }
    }
}