using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoSeis
{
    class ExercicioFixacaoLista
    {
        public static void ExecutarExercicioLista()
        {
            Console.Write("How many employees will be registered? ");
            int qntEmployees = int.Parse(Console.ReadLine());

            List<Employee> employeesList = new List<Employee>();

            for(int cont = 1; cont <= qntEmployees; cont++)
            {
                Console.WriteLine($"Employee #{cont}");
                Console.Write("ID: ");
                int idEmp = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string nameEmp = Console.ReadLine();
                Console.Write("Salary: ");
                double salaryEmp = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employeesList.Add(new Employee(idEmp, nameEmp, salaryEmp));
                Console.WriteLine();
            }
            
            Console.Write("Enter the employee id that will have salary increase: ");
            int searchIdIncrease = int.Parse(Console.ReadLine());

            Employee emp = employeesList.Find(x => x.id == searchIdIncrease);

            if(emp != null)
            {
                Console.Write("Enter the percetage: ");
                double percentageEmp = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentageEmp);
            }
            else
            {
                Console.WriteLine("This ID does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of Employees: ");
            foreach(Employee obj in employeesList)
            {
                Console.WriteLine(obj);
            }            
           
        }
    }
}