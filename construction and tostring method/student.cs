using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace construction_and_tostring_method
{
    internal class student
    {

        private int rollno;
        private double percentage;
        private string name;
        public student(int rollno, double percentage, string name)
        {
            this.rollno = rollno;
            this.percentage = percentage;
            this.name = name;
        }
        public string Print()
        {
            return $"{rollno} {percentage} {name}";
        }



    }
}
