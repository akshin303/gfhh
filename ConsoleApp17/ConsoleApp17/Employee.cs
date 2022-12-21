using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp17
{
    internal class Employee:Human
    {
        public Employee(int Salary,string position) 
        {
            this.Salary = Salary; this.Position = position;
        }
        public int Salary;
        public string Position;
    }
}
