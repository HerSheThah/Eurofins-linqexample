
using System;
using System.Collections;

namespace linqeg
{
    internal class Program
    {
        static void Main()
        {

            List<EmpDetails> employeedetails = EmpDetails.getEmpDetails();


            // displaying details
            Console.WriteLine("Displaying details");
            foreach(var emp in employeedetails)
            {
                Console.WriteLine(emp.ToString());
            }


            // salary greater than 50k
            var employee =  employeedetails.Where(x => x.salary > 50000).Select(x => x).ToList();
            Console.WriteLine("\nSalary greater than 50k");
            foreach (var item in employee)
            {
                Console.WriteLine(item.ToString());
            }


            // Emp details 
            Console.WriteLine("\nGetting emp details");
            Console.WriteLine("Enter id: ");
            int id = int.Parse(Console.ReadLine());

            EmpDetails obedetail =  EmpDetails.getempdetailbyID(id);
            Console.WriteLine(obedetail.ToString());


            // creating new employee
            Console.WriteLine("\nNew employee");
            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter age: ");
            int age = int.Parse(Console.ReadLine());

            EmpDetails.CreatenewEmployee(new EmpDetails(17, name, age, 70000));

            // displaying details
            foreach (var emp in employeedetails)
            {
                Console.WriteLine(emp.ToString());
            }













        }
    }
}

