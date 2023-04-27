using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CatWorx.BadgeMaker
{
  class Program
  {
    static List<Employee> GetEmployees()
    {
        List<Employee> employees = new List<Employee>();
        
        while (true)
        {
            Console.WriteLine("Please enter fist name: ");
            string firstName = Console.ReadLine() ?? "";
            if (firstName == "")
            {
                break;
            }
            Console.WriteLine("Please enter last name: ");
            string lastName = Console.ReadLine() ?? "";
            Console.WriteLine("Please enter an id number: ");
            int id = Int32.Parse(Console.ReadLine() ?? "");
            Console.WriteLine("Please enter a photo url: ");
            string photoUrl = Console.ReadLine() ?? "";
            Employee currentEmployee = new Employee(firstName, lastName, id, photoUrl);
            employees.Add(currentEmployee);    
        }
        return employees;
    }

    async static Task Main(string[] args)
    {
        List<Employee> employeeList = GetEmployees();
        
        Util.PrintEmployees(employeeList);
        Util.MakeCSV(employeeList);
        await Util.MakeBadges(employeeList);

    }
  }
}
