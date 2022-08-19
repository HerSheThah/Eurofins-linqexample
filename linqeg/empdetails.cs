using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqeg
{
    public class EmpDetails
    {
        public int empid { get; set; }

        public string name { get; set; }

        public int empage { get; set; }
        public float salary { get; set; }
        public static List<EmpDetails> listemp = new List<EmpDetails>();


        public EmpDetails() {
        }

        public EmpDetails(int empid, string name, int empage, float salary)
        {
            this.empid = empid;
            this.name = name;
            this.empage = empage;
            this.salary = salary;
        }
        public static List<EmpDetails> getEmpDetails()
        {
            listemp.Add(new EmpDetails(12, "rana", 30, 60000));
            listemp.Add(new EmpDetails(13, "rana", 23, 50000));
            listemp.Add(new EmpDetails(14, "rana", 21, 50000));
            listemp.Add(new EmpDetails(15, "rana", 32, 70000));

            return listemp;

        }

        public static EmpDetails getempdetailbyID(int id)
        {
            var employee = (from emp in listemp where emp.empid == id select emp).SingleOrDefault();
            return employee;
        }


        // creating new employee
        public static void CreatenewEmployee(EmpDetails newemp)
        {
            listemp.Add(newemp);
        }

        public override string ToString()
        {
            return empid + " " + name + " " + empage + " " + salary;
        }


    }
}
