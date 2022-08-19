
using System;
using System.Collections;

namespace linqeg
{
    internal class Program
    {
        static void Main()
        {
            //List<int> number = new List<int>();   
            //number.Add(32);
            //number.Add(34);
            //number.Add(8);
            //number.Add(4);
            //number.Add(3);
            //number.Add(24);

            //// Querry syntax
            //var result = (from i in number where i>20 select i);
            //foreach (int i in result)
            //    Console.WriteLine(i);

            //// Method syntax
            //Console.WriteLine("Method syntax");
            //var res = number.Where(i => i > 25).Select(i=>i);
            //foreach (int i in res)
            //    Console.WriteLine(i);

            List<EmpDetails> employeedetails = EmpDetails.getEmpDetails();

            foreach(var emp in employeedetails)
            {
                Console.WriteLine(emp.ToString());
            }

            var employee =  employeedetails.Where(x => x.salary > 50000).Select(x => x).ToList();
            Console.WriteLine("Salary greater than 50k");
            foreach (var item in employee)
            {
                Console.WriteLine(item.ToString());
            }


            Console.WriteLine("Enter id: ");
            int id = int.Parse(Console.ReadLine());

            EmpDetails obedetail =  EmpDetails.getempdetailbyID(id);
            Console.WriteLine(obedetail.ToString());
            








        }
    }
}

