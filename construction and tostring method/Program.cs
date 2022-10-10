using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace construction_and_tostring_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //course cs1 = new course(2,20000,"Net");
            //Console.WriteLine(cs1.Print());

            //courseTostring css1 = new courseTostring(2, 2000, "Net");
            //Console.WriteLine(css1);

            //student myobj = new student(12345, 84.34, "Akash");
            //Console.WriteLine(myobj.Print());

            //studentTostring sst = new studentTostring(12345,84.34,"Akash");
            //Console.WriteLine(sst);

            //Employee em = new Employee(12, 1200000, "Akash");
            //Console.WriteLine(em.Print());

            EmployeeTostring em1 = new EmployeeTostring(12,12300000,"Akash");
            Console.WriteLine(em1);
        }
    }
}
