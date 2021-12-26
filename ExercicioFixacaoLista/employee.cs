using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoSeis
{
    class Employee
    {
        public int id{ get; set;}
        public string name{ get; set; }
        public double salary { get; private set;}

        public Employee(int idExterno, string nameExterno, double salaryExterno)
        {
            id = idExterno;
            name = nameExterno;
            salary = salaryExterno;
        }
        public void IncreaseSalary(double percentage)
        {
            salary += salary * percentage / 100.0;
        }

        public override string ToString()
        {
            return id
            + ", "
            + name
            + ", "
            + salary.ToString("F2");
        }
    }
}