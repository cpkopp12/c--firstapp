using System;
using System.Collections.Generic;

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

    static void PrintEmployees(List<Employee> employeeList) 
    {
        for (int i = 0; i < employeeList.Count; i++)
        {
            string template = "{0,-10}\t{1,-20}\t{2}";
            Console.WriteLine(String.Format(template, employeeList[i].GetId(), employeeList[i].GetFullName(), employeeList[i].GetPhotoUrl()));
        }
    }

    static void Main(string[] args)
    {
        List<Employee> employeeList = GetEmployees();
        
        PrintEmployees(employeeList);

    }
  }
}
