﻿using System;

namespace Consoleproj1
{
    class Program
    {
        static void Main(string[] args)
        {
            HumanResourceManager humanResourceManager = new HumanResourceManager();
            do
            {
                Console.WriteLine("-----------------Human Resource Manager-------------------");
                Console.WriteLine("1.departmentlerin siyahisini gostermek");
                Console.WriteLine("2.department yaratmag");
                Console.WriteLine("3.department de deyisiklik etmek");
                Console.WriteLine("4.ishcilerin siyahisini gostermek");
                Console.WriteLine("5.departmentdeki ischilerin siyahisini gostermek");
                Console.WriteLine("6.isci elave etmek");
                Console.WriteLine("7.isci uzerinde deyisiklik etmek");
                Console.WriteLine("8.departmentden isci silinmesi");
                //Console.Write("emaliyyatin nomresini daxil et" );
                string choose = Console.ReadLine();
                double chooseNum;
                double.TryParse(choose, out chooseNum);
                switch (chooseNum)
                {
                    case 1:
                        GetDepartments(ref humanResourceManager);
                        Console.Clear();
                        break;
                    case 2:
                        AddDepartment(ref humanResourceManager);
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        break;
                    case 4:
                        Console.Clear();
                        break;
                    case 5:
                        Console.Clear();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("duzgun daxil et");
                        break;
                }
            } while (true);
            static void AddDepartment(ref HumanResourceManager humanResourceManager)
            {
                string name;
                bool check = true;
                do
                {
                    if (check)
                    {
                        Console.WriteLine("departmentin adini daxil edin");
                    }
                    else
                    {
                        Console.WriteLine("duzgun daxil edin");
                    }
                    name = Console.ReadLine();
                    check = false;
                } while (!humanResourceManager.Checkname(name));
                do
                {
                    if (check)
                    {
                        Console.WriteLine("daxil etdiyiniz department movcuddur.yeniden daxil edin");
                        name = Console.ReadLine();
                    }
                    check = true;

                } while (!humanResourceManager.Checkname(name));
                Console.WriteLine("isci sayini daxil edin");
            checkWN:
                string WorkerLimit = Console.ReadLine();
                int WorkerLimitNum = 0;
                while (!int.TryParse(WorkerLimit,out WorkerLimitNum)||WorkerLimitNum<1)
                {
                    Console.WriteLine("duzgun daxil edin:");
                    goto checkWN;
                }
            checkSL:
                string SalaryLimit = Console.ReadLine();
                int SalaryLimitNum = 0;
                while (!int.TryParse(SalaryLimit, out SalaryLimitNum) || SalaryLimitNum < 1)
                {
                    Console.WriteLine("duzgun daxil edin:");
                    goto checkSL;
                }

                humanResourceManager.AddDepartment(name, WorkerLimit, SalaryLimit);
            }

            static void EditDepartment(ref HumanResourceManager humanResourceManager)
            {
                if (humanResourceManager.Departments.Length<=0)
                {
                    Console.WriteLine("once daxil et");
                    return;
                }
                foreach (Department item in humanResourceManager.Departments)
                {
                    Console.WriteLine("item");
                    Console.WriteLine("----------------");
                }
                string name = Console.ReadLine();
                bool CheckDepartmentName = true;
                Console.WriteLine("deyisiklik edeceyiniz departmenti daxil edin");
                while (CheckDepartmentName)
                {
                    foreach (Department item in humanResourceManager.Departments)
                    {
                        if (item.Name.ToLower()==name.ToLower())
                        {
                            item.Name = name;
                        }
                        else
                        {
                            Console.WriteLine("departmentin adini duzgun daxil edin");
                        }
                        name = Console.ReadLine();
                    }
                }
            }
            //Department department = new Department();
            //Console.WriteLine(department);
            //Employees employee = new Employees("Fereh", "Front end", 800, "Developer");
            //Console.WriteLine(employee);
            //Employees employee1 = new Employees("Fereh", "Front end", 800, "Developer");
            //Console.WriteLine(employee1);
        }
        //static void AddEmployee(ref HumanResourceManager humanResourceManager)
        //{
        //    if (humanResourceManager.Departments.Length<=0)
        //    {
        //        Console.WriteLine("cari department bazasi bosdur.ilk once cari departmenti yazin");
        //        return;
        //    }
        //    Console.WriteLine("elave etmek istediyiniz iscinin ad ve soyadini daxil edin");
        //    EnterName;
        //    string name = Console.ReadLine();
        //    string[] name = name.Split(' ');

        //}

        private static void AddDepartment(ref HumanResourceManager humanResourceManager)
        {
            throw new NotImplementedException();
        }

        private static void GetDepartments(ref HumanResourceManager humanResourceManager)
        {
            throw new NotImplementedException();
        }
    }
}
