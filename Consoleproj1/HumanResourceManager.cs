﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Consoleproj1
{
    class HumanResourceManager : IHumanResourceManager
    {
        public Department[] Departments => _departments;
        private Department[] _departments;

        public Employees[] employees => employees;
        private Employees[] _employees;

        public void AddDepartment(string name, int workerlimit, int SalaryLimit, Employees[] Employees)
        {
            Department department = new Department( name, workerlimit,SalaryLimit,Employees);
            Array.Resize(ref _departments, _departments.Length + 1);
            _departments[_departments.Length - 1] = department;
        }

        public void AddEmployee(Employees[] employees, string Name, string position, double salary, string departmentName)
        {
            Employees employees1 = new Employees(Name, position, salary, departmentName);
            Array.Resize(ref _employees, _employees.Length + 1);
            _employees[_employees.Length - 1] = employees1;
        }

        public void EditDepartaments(string name,string newname)
        {
            foreach (Department item in _departments)
            {
                if (item.Name==newname)
                {
                    break;
                }
            }
        }

        public void EditEmploye(string no, string Name, double Salary, string Position)
        {
            foreach (Employees item in _employees)
            {
                if (item.No==no)
                {
                    item.Position = Position;
                    item.Name = Name;
                    item.Salary = Salary;
                }
            }
        }

        public Department[] GetDepartments(Department[] departments)
        {
            return departments;
        }

        public void RemoveEmployee(string no, string Name)
        {
            for (int i = 0; i < _employees.Length; i++)
            {
                if (_employees[i].No==no)
                {
                    _employees = null;
                    return;
                }
            }
        }

        public void AddEmployee(string Name, string position, double salary, string departmentName)
        {
           
        }

        void IHumanResourceManager.GetDepartments(Department[] departments)
        {
            throw new NotImplementedException();
        }
    }
}
