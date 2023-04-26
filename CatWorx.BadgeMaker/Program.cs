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
            Console.WriteLine("Please enter a name: ");
            string input = Console.ReadLine() ?? "";
            if (input == "")
            {
                break;
            }
            Employee currentEmployee = new Employee(input, "smilth");
            employees.Add(currentEmployee);    
        }
        return employees;
    }

    static void PrintEmployees(List<Employee> employeeList) 
    {
        for (int i = 0; i < employeeList.Count; i++)
        {
            Console.WriteLine(employeeList[i].GetFullName());
        }
    }

    static void Main(string[] args)
    {
        List<Employee> employeeList = GetEmployees();
        
        PrintEmployees(employeeList);

    }
  }
}
