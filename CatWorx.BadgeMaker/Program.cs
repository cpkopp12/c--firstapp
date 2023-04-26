using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
  class Program
  {
    static List<string> GetEmployees()
    {
        List<string> employees = new List<string>();
        
        while (true)
        {
            Console.WriteLine("Please enter a name: ");
            string input = Console.ReadLine() ?? "";
            if (input == "")
            {
                break;
            }
            Employee currentEmployee = new Employee(input, "smilth");
            employees.Add(currentEmployee.GetFullName());    
        }
        return employees;
    }

    static void PrintEmployees(List<string> nameList) 
    {
        for (int i = 0; i < nameList.Count; i++)
        {
            Console.WriteLine(nameList[i]);
        }
    }

    static void Main(string[] args)
    {
        List<string> employeeList = GetEmployees();
        
        PrintEmployees(employeeList);

    }
  }
}
