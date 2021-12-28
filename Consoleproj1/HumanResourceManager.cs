using System;
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

        public void AddDepartment(string name, int workerlimit, int SalaryLimit)
        {
            Department department = new Department( name, workerlimit,SalaryLimit);
            Array.Resize(ref _departments, _departments.Length + 1);
            _departments[_departments.Length - 1] = department;
        }
        public bool Checkname(string str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                if (Char.IsUpper(str[0]))
                {
                    foreach (var chr in str)
                    {
                        if (char.IsLetter(chr)==false)
                        {
                            return false;
                        }
                    }
                    return true;
                }
            }
            return false;
        }

        public void AddEmployee(Employees[] employees, string Name, string position, double salary, string departmentName)
        {
            Department department = FindDepartmentByName(departmentName);
            if (department==null)
            {
                Console.WriteLine("sistemde bu adda department movcud deyil");
            }
            else if (department.Workerlimit<=department.Employees.Length)
            {
                Console.WriteLine("isci elave etmek mumkun deyil");
            }
            else if (department.TotalSalary(department)+ salary>department.SalaryLimit)
            {
                Console.WriteLine("iscinin maasi limitden artigdi");
            }
            else
            {
                Employees employees2 = new Employees(departmentName)
                {
                    DepartmentName = departmentName,
                    Name = Name,
                    Position = position,
                    Salary = salary
                };
            }
            Employees employees1 = new Employees(Name, position, salary, departmentName);
            Array.Resize(ref _employees, _employees.Length + 1);
            _employees[_employees.Length - 1] = employees1;
        }

        private Department FindDepartmentByName(string departmentName)
        {
            throw new NotImplementedException();
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

        //internal bool Checkname(string name)
        //{
        //    throw new NotImplementedException();
        //}

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

        internal void AddDepartment(string name, string workerLimit, string salaryLimit)
        {
            throw new NotImplementedException();
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
