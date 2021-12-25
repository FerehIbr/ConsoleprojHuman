using System;
using System.Collections.Generic;
using System.Text;

namespace Consoleproj1
{
    class Employees
    {
        private static int Count = 1000;
        public string Name { get; set; }
        public string No { get; set; }
        public string Position { get; set; }
        public double Salary { get; set; }
        public string DepartmentName { get; set; }

        public Employees(string name, string position, double salary, string departmentName)
        {
            No = departmentName.Substring(0, 2) + Count;
            Count++;
            Name = name;
            Position = position;
            Salary = salary;
            DepartmentName = departmentName;

            if (position.Length < 2)
            {
                Console.WriteLine("daxil etdiyiniz position yanlishdir!");

            }
            if (salary <= 250)
            {
                Console.WriteLine("maash movcud deyil!");
            }

        }
        public override string ToString()
        {
            return $"Nomresi: {No}\n Name: {Name} \n Position: {Position} \n Salary: {Salary} \n DepartmentName: {DepartmentName}";
        }

    }

}
