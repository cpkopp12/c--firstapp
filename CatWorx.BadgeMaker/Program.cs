using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CatWorx.BadgeMaker
{
  class Program
  {

    async static Task Main(string[] args)
    {
        // List<Employee> employeeList = PeopleFetcher.GetEmployees();
        List<Employee> employeeList = await PeopleFetcher.GetFromApi();
        
        Util.PrintEmployees(employeeList);
        Util.MakeCSV(employeeList);
        await Util.MakeBadges(employeeList);

    }
  }
}
