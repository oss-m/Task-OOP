using System;
using System.Collections.Generic;

namespace Universties
{
    class Program
    {
        static void Main()
        {
            //Universties Input
            Console.WriteLine("Entering Universties Names");
            var uni = new Universty();
            uni.Universties = new List<Operations<Universty>>();
            uni.Universties.AddRange(uni.Create(uni.Universties));
            //Colledges Input
            foreach (var item_uni in uni.Universties)
            {
                item_uni.Colledges = new List<Operations<Colledge>>();
                Console.WriteLine("Entering Colledges Names for University {0}", item_uni.Name);
                var coll = new Colledge();
                item_uni.Colledges.AddRange(coll.Create(item_uni.Colledges));
            }
            //Departments Input
            foreach (var item_uni in uni.Universties)
            {
                foreach (var item_coll in item_uni.Colledges)
                {
                    item_coll.Departments = new List<Operations<Department>>();
                    Console.WriteLine("Entering Departments Names for\nColledge {0} of {1} University", item_coll.Name, item_uni.Name);
                    var dep = new Department();
                    item_coll.Departments.AddRange(dep.Create(item_coll.Departments));
                }
            }
            //Subjects Input
            foreach (var item_uni in uni.Universties)
            {
                foreach (var item_coll in item_uni.Colledges)
                {
                    foreach (var item_dep in item_coll.Departments)
                    {
                        item_dep.Subjects = new List<Operations<Subject>>();
                        Console.WriteLine("Entering Subjects Names for\nDepartment {0} of Colledge {1} of University {2}", item_dep.Name, item_coll.Name, item_uni.Name);
                        var sub = new Subject();
                        item_dep.Subjects.AddRange(sub.Create(item_dep.Subjects));
                    }
                }
            }
            //Staff Input
            foreach (var item_uni in uni.Universties)
            {
                foreach (var item_coll in item_uni.Colledges)
                {
                    foreach (var item_dep in item_coll.Departments)
                    {
                        foreach (var item_sub in item_dep.Subjects)
                        {
                            item_sub.Staffs = new List<Operations<Staff>>();
                            Console.WriteLine("Entering Staffs Names for\nSubject {0} of Department {1} of Colledge {2} of University {3}", item_sub.Name, item_dep.Name, item_coll.Name, item_uni.Name);
                            var staff = new Staff();
                            item_sub.Staffs.AddRange(staff.Create(item_sub.Staffs));
                        }
                    }
                }
            }
            //Students Input
            foreach (var item_uni in uni.Universties)
            {
                foreach (var item_coll in item_uni.Colledges)
                {
                    foreach (var item_dep in item_coll.Departments)
                    {
                        item_dep.Students = new List<Operations<Student>>();
                        Console.WriteLine("Entering Students Names for\nDepartment {0} of Colledge {1} of University {2}", item_dep.Name, item_coll.Name, item_uni.Name);
                        var stu = new Student();
                        item_dep.Students.AddRange(stu.Create(item_dep.Students));
                    }
                }
            }

            //Results
            Console.WriteLine("Retrieving Percentages");
            foreach (var item_Uni in uni.Universties)
            {
                double uni_succ_stu_num = 0;
                double uni_stu_num = 0;
                foreach (var item_Coll in item_Uni.Colledges)
                {
                    double coll_succ_stu_num = 0;
                    double coll_stu_num = 0;
                    foreach (var item_Dep in item_Coll.Departments)
                    {
                        double dep_succ_stu_num = 0;
                        double dep_stu_num = 0;
                        foreach (var item_Stu in item_Dep.Students)
                        {
                            if (item_Stu.Grade >= 50)
                            {
                                dep_succ_stu_num++;
                            }
                            dep_stu_num++;
                        }
                        coll_succ_stu_num += dep_succ_stu_num;
                        coll_stu_num += dep_stu_num;
                    }
                    double coll_per = (coll_succ_stu_num / coll_stu_num) * 100;
                    Console.WriteLine("{0} Colledge of Universty {1} has Success Percentage of {2}%", item_Coll.Name, item_Uni.Name, coll_per);
                    uni_succ_stu_num += coll_succ_stu_num;
                    uni_stu_num += coll_stu_num;
                }
                double uni_per = (uni_succ_stu_num / uni_stu_num) * 100;
                Console.WriteLine("{0} Universty has Success Percentage of {1}%", item_Uni.Name, uni_per);
            }
        }
    }
}
