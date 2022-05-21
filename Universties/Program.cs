using System;
using System.Linq;
using System.Collections.Generic;

namespace Universties
{
    class Program
    {
        static void Main()
        {
            Data.DUniversties = new List<Universty>();
            Data.DColledges = new List<Colledge>();
            Data.DDepartments = new List<Department>();
            Data.DStaffs = new List<Staff>();
            Data.DSubjects = new List<Subject>();
            Data.DStudents = new List<Student>();

            string Main_Menu = "****************Universties Managment Program*************\nMain Menu:\n1.Add Data\n2.Retrieve Data\n3.Edit Data\n4.Get Success Percentages\n5.Data save & Restore\n\nTo Exit Type Exit\n------------------------------------------------";
            Console.WriteLine(Main_Menu);
            string Main_selector = Console.ReadLine();
            while (Main_selector != "Exit")
            {
                if (Main_selector == "1")
                {
                    string Sub_Menu = ",,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,\n1.Add Universties\n2.Add Colledges\n3.Add Departments\n4.Add Subjects\n5.Add Staff\n6.Add Students\n\nTo Go Back Enter 0";
                    Console.WriteLine(Sub_Menu);
                    string Sub_selector = Console.ReadLine();
                    if (Sub_selector == "0") { Console.WriteLine(Main_Menu); Main_selector = Console.ReadLine(); }
                    if (Sub_selector == "1") { new ManageUniversty().UniCreator(); Console.WriteLine("Press Enter"); Sub_selector = Console.ReadLine(); }
                    if (Sub_selector == "2") { new ManageColledge().CollCreator(); Console.WriteLine("Press Enter"); Sub_selector = Console.ReadLine(); }
                    if (Sub_selector == "3") { new ManageDepartment().DepCreator(); Console.WriteLine("Press Enter"); Sub_selector = Console.ReadLine(); }
                    if (Sub_selector == "4") { new ManageSubject().SubCreator(); Console.WriteLine("Press Enter"); Sub_selector = Console.ReadLine(); }
                    if (Sub_selector == "5") { new ManageStaff().StaffCreator(); Console.WriteLine("Press Enter"); Sub_selector = Console.ReadLine(); }
                    if (Sub_selector == "6") { new ManageStudent().StuCreator(); Console.WriteLine("Press Enter"); Sub_selector = Console.ReadLine(); }
                }
                if (Main_selector == "2")
                {
                    string Sub_Menu = ",,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,\n1.Retrieve Universties\n2.Retrieve Colledges\n3.Retrieve Departments\n4.Retrieve Subjects\n5.Retrieve Staff\n6.Retrieve Students\n\nTo Go Back Enter 0";
                    Console.WriteLine(Sub_Menu);
                    string Sub_selector = Console.ReadLine();
                    if (Sub_selector == "0") { Console.WriteLine(Main_Menu); Main_selector = Console.ReadLine(); }
                    if (Sub_selector == "1") { new ManageUniversty().UniRet(); Console.WriteLine("Press Enter"); Sub_selector = Console.ReadLine(); }
                    if (Sub_selector == "2") { new ManageColledge().CollRet(); Console.WriteLine("Press Enter"); Sub_selector = Console.ReadLine(); }
                    if (Sub_selector == "3") { new ManageDepartment().DepRet(); Console.WriteLine("Press Enter"); Sub_selector = Console.ReadLine(); }
                    if (Sub_selector == "4") { new ManageSubject().SubRet(); Console.WriteLine("Press Enter"); Sub_selector = Console.ReadLine(); }
                    if (Sub_selector == "5") { new ManageStaff().StaffRet(); Console.WriteLine("Press Enter"); Sub_selector = Console.ReadLine(); }
                    if (Sub_selector == "6") { new ManageStudent().StuRet(); Console.WriteLine("Press Enter"); Sub_selector = Console.ReadLine(); }
                }
                if (Main_selector == "3")
                {
                    string Sub_Menu = ",,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,\n1.Edit Universties\n2.Edit Colledges\n3.Edit Departments\n4.Edit Subjects\n5.Edit Staff\n6.Edit Students\n\nTo Go Back Enter 0";
                    Console.WriteLine(Sub_Menu);
                    string Sub_selector = Console.ReadLine();
                    if (Sub_selector == "0") { Console.WriteLine(Main_Menu); Main_selector = Console.ReadLine(); }
                    if (Sub_selector == "1") { new ManageUniversty().UniEdit(); Console.WriteLine("Press Enter"); Sub_selector = Console.ReadLine(); }
                    if (Sub_selector == "2") { new ManageColledge().CollEdit(); Console.WriteLine("Press Enter"); Sub_selector = Console.ReadLine(); }
                    if (Sub_selector == "3") { new ManageDepartment().DepEdit(); Console.WriteLine("Press Enter"); Sub_selector = Console.ReadLine(); }
                    if (Sub_selector == "4") { new ManageSubject().SubEdit(); Console.WriteLine("Press Enter"); Sub_selector = Console.ReadLine(); }
                    if (Sub_selector == "5") { new ManageStaff().StaffEdit(); Console.WriteLine("Press Enter"); Sub_selector = Console.ReadLine(); }
                    if (Sub_selector == "6") { new ManageStudent().StuEdit(); Console.WriteLine("Press Enter"); Sub_selector = Console.ReadLine(); }
                }
                if (Main_selector =="4")
                {
                    ManageData.Per();
                    string Sub_Menu = ",,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,\n1.Retrieve Universties Students Success Data\n2.Retrieve Colledges Students Success Data\n\nTo Go Back Enter 0";
                    Console.WriteLine(Sub_Menu);
                    string Sub_selector = Console.ReadLine();
                    if (Sub_selector == "0") { Console.WriteLine(Main_Menu); Main_selector = Console.ReadLine(); }
                    if (Sub_selector == "1") { new ManageUniversty().UniPercent(); Console.WriteLine("Press Enter"); Sub_selector = Console.ReadLine(); }
                    if (Sub_selector == "2") { new ManageColledge().CollPercent(); Console.WriteLine("Press Enter"); Sub_selector = Console.ReadLine(); }
                }
                if (Main_selector == "5")
                {
                    string Sub_Menu = ",,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,\n1.Save Data\n2.Retrieve Data\n\nTo Go Back Enter 0";
                    Console.WriteLine(Sub_Menu);
                    string Sub_selector = Console.ReadLine();
                    if (Sub_selector == "0") { Console.WriteLine(Main_Menu); Main_selector = Console.ReadLine(); }
                    if (Sub_selector == "1") { ManageData.SaveData(); Console.WriteLine("Press Enter"); Sub_selector = Console.ReadLine(); }
                    if (Sub_selector == "2") { ManageData.RetrieveData(); Console.WriteLine("Press Enter"); Sub_selector = Console.ReadLine(); }
                }
            }
        }
    }
}