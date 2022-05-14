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
            Console.WriteLine("Entering Universties Names");
            var uni = new Universty();
            var uni_op = new Operations().Create(new Operations().Groups, uni.GetType().Name);
            foreach (var item in uni_op)
            {
                var uni_item = new Universty();
                uni_item.Name = item.Name;
                uni.Universties.Add(uni_item);
            }
            //Colledges Input
            foreach (var item_uni in uni.Universties)
            {
                Console.WriteLine("Entering Colledges Names for University {0}", item_uni.Name);
                var coll = new Colledge();
                var coll_op = new Operations().Create(new Operations().Groups, coll.GetType().Name);
                foreach (var item in coll_op)
                {
                    var coll_item = new Colledge();
                    coll_item.Name = item.Name;
                    item_uni.Colledges.Add(coll_item);
                }
            }
            //Departments Input
            foreach (var item_uni in uni.Universties)
            {
                foreach (var item_coll in item_uni.Colledges)
                {
                    Console.WriteLine("Entering Departments Names for\nColledge {0} of {1} University", item_coll.Name, item_uni.Name);
                    var dep = new Department();
                    var dep_op = new Operations().Create(new Operations().Groups, dep.GetType().Name);
                    foreach (var item in dep_op)
                    {
                        var dep_item = new Department();
                        dep_item.Name = item.Name;
                        item_coll.Departments.Add(dep_item);
                    }
                }
            }
            //Subjects Input
            foreach (var item_uni in uni.Universties)
            {
                foreach (var item_coll in item_uni.Colledges)
                {
                    foreach (var item_dep in item_coll.Departments)
                    {
                        Console.WriteLine("Entering Subjects Names for\nDepartment {0} of Colledge {1} of University {2}", item_dep.Name, item_coll.Name, item_uni.Name);
                        var sub = new Subject();
                        var sub_op = new Operations().Create(new Operations().Groups, sub.GetType().Name);
                        foreach (var item in sub_op)
                        {
                            var sub_item = new Subject();
                            sub_item.Name = item.Name;
                            item_dep.Subjects.Add(sub_item);
                        }
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
                            Console.WriteLine("Entering Staffs Names for\nSubject {0} of Department {1} of Colledge {2} of University {3}", item_sub.Name, item_dep.Name, item_coll.Name, item_uni.Name);
                            var staff = new Staff();
                            var staff_op = new Operations().Create(new Operations().Groups, staff.GetType().Name);
                            foreach (var item in staff_op)
                            {
                                var staff_item = new Staff();
                                staff_item.Name = item.Name;
                                item_sub.Staffs.Add(staff_item);
                            }
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
                        Console.WriteLine("Entering Students Names for\nDepartment {0} of Colledge {1} of University {2}", item_dep.Name, item_coll.Name, item_uni.Name);
                        var stu = new Student();
                        var stu_op = new Operations().Create(new Operations().Groups, stu.GetType().Name);
                        foreach (var item in stu_op)
                        {
                            var stu_item = new Student();
                            stu_item.Name = item.Name;
                            stu_item.Grade = item.Grade;
                            item_dep.Students.Add(stu_item);
                        }
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
                            if (item_Stu.Grade != null)
                            {
                                if (item_Stu.Grade >= 50)
                                {
                                    dep_succ_stu_num++;
                                }
                            }
                            else
                            {
                                continue;
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
