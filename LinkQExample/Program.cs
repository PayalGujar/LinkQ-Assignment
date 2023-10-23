using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkQExample
{
    public class Employee
    {
      public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public int Salary { get; set; }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>()
            {
                new Employee { Id= 1, Name="Payal",City="Pune",Salary=55000},
                new Employee { Id = 2, Name = "Samruddhi", City = "Mumbai", Salary = 45000 },
                new Employee { Id = 3, Name = "Ketki", City = "Satara", Salary = 35000 },
                new Employee { Id = 4, Name = "Aishwarya", City = "Pune", Salary = 22000 }



            };
            var result = from e in list
                         where e.City == "Pune"
                         select e;

            foreach(Employee e in result)
            {
                Console.WriteLine($"{e.Id},{e.Name},{e.City},{e.Salary}");
            }






        }
    }
}
