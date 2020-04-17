using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz1
{
    class Employee
    {
        public int emplId;
        public string emplName;
        public int emplSalary;

        public Employee(int id, string name, int salary)
        {
            this.emplId = id;
            this.emplName = name;
            this.emplSalary = salary;
        }

    }
}
