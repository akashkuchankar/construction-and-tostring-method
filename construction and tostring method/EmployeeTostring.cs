using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace construction_and_tostring_method
{
    internal class EmployeeTostring
    {
        private int id;
        private double salary;
        private string name;
        public EmployeeTostring(int id , double salary, string name)
        {
            this.id = id;
            this.salary = salary;
            this.name = name;
        }
        public override string ToString()
        {
            return $"{id} {salary} {name}";
        }
    }
}
