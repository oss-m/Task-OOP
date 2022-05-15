using System;
using System.Linq;
using System.Collections.Generic;

namespace Universties
{
    class Program
    {
        static void Main()
        {
            //Universties Input
            Data.DUniversties = new List<Universty>();
            Data.DColledges = new List<Colledge>();
            Data.DDepartments = new List<Department>();
            Data.DStaffs = new List<Staff>();
            Data.DSubjects = new List<Subject>();
            Data.DStudents = new List<Student>();

            string Main_Menu = "****************Universties Managment Program*************\nMain Menu:\n1.Add Data\n2.Edit Data\n3.Retrieve Data\n\nTo Exit Type Exit\n------------------------------------------------";
            Console.WriteLine(Main_Menu);
            string Main_selector = Console.ReadLine();
            while (Main_selector != "Exit")
            {
                if (Main_selector == "1")
                {
                    string Sub_Menu1 = ",,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,\n1.Add Universties\n2.Add Colledges\n3.Add Departments\n4.Add Subjects\n5.Add Staff\n6.Add Students\n\nTo Go Back Enter 0";
                    Console.WriteLine(Sub_Menu1);
                    string Sub_selector1 = Console.ReadLine();
                    if (Sub_selector1 == "0") { Console.WriteLine(Main_Menu); Main_selector = Console.ReadLine(); }

                    if (Sub_selector1 == "1") { var uni = new Universty(); uni.UniCreator(uni); 
                        Console.WriteLine(Sub_Menu1); Sub_selector1 = Console.ReadLine(); }

                    if (Sub_selector1 == "3") { var dep = new Department(); dep.DepMenu(dep); 
                        Console.WriteLine(Sub_Menu1); Sub_selector1 = Console.ReadLine(); }

                    if (Sub_selector1 == "4") { var sub = new Subject(); sub.SubMenu(sub); 
                        Console.WriteLine(Sub_Menu1); Sub_selector1 = Console.ReadLine(); }

                    if (Sub_selector1 == "5") { var staff = new Staff(); staff.StaffMenu(staff); 
                        Console.WriteLine(Sub_Menu1); Sub_selector1 = Console.ReadLine(); }

                    if (Sub_selector1 == "6") { var stu = new Student(); stu.StuMenu(stu); 
                        Console.WriteLine(Sub_Menu1); Sub_selector1 = Console.ReadLine(); }

                }
            }
        }
    }
}
           
        
            ////Results
            //Console.WriteLine("Retrieving Percentages");
            //foreach (var item_Uni in uni.Universties)
            //{
            //    double uni_succ_stu_num = 0;
            //    double uni_stu_num = 0;
            //    foreach (var item_Coll in item_Uni.Colledges)
            //    {
            //        double coll_succ_stu_num = 0;
            //        double coll_stu_num = 0;
            //        foreach (var item_Dep in item_Coll.Departments)
            //        {
            //            double dep_succ_stu_num = 0;
            //            double dep_stu_num = 0;
            //            foreach (var item_Stu in item_Dep.Students)
            //            {
            //                if (item_Stu.Grade != null)
            //                {
            //                    if (item_Stu.Grade >= 50)
            //                    {
            //                        dep_succ_stu_num++;
            //                    }
            //                }
            //                else
            //                {
            //                    continue;
            //                }
            //                dep_stu_num++;
            //            }
            //            coll_succ_stu_num += dep_succ_stu_num;
            //            coll_stu_num += dep_stu_num;
            //        }
            //        double coll_per = (coll_succ_stu_num / coll_stu_num) * 100;
            //        Console.WriteLine("{0} Colledge of Universty {1} has Success Percentage of {2}%", item_Coll.Name, item_Uni.Name, coll_per);
            //        uni_succ_stu_num += coll_succ_stu_num;
            //        uni_stu_num += coll_stu_num;
            //    }
            //    double uni_per = (uni_succ_stu_num / uni_stu_num) * 100;
            //    Console.WriteLine("{0} Universty has Success Percentage of {1}%", item_Uni.Name, uni_per);
            //}