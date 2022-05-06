using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universties
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Entering Universties Names");
            var uni = new Universty();
            uni.CreateUni();
            foreach (var item_uni in uni.Universties)
            {
                Console.WriteLine("Entering Colledges Names for University {0}", item_uni.Name);
                var coll = new Colledge();
                item_uni.Colledges.AddRange(coll.CreateColl());
                foreach (var item_coll in item_uni.Colledges)
                {
                    Console.WriteLine("Entering Departments Names for Colledge {0}", item_coll.Name);
                    var dep = new Department();
                    item_coll.Departments.AddRange(dep.CreateDep());
                    foreach (var item_dep in item_coll.Departments)
                    {
                        Console.WriteLine("Entering Subjects Names for Department {0}", item_dep.Name);
                        var sub = new Subject();
                        item_dep.Subjects.AddRange(sub.CreateSubj());
                        foreach (var item_sub in item_dep.Subjects)
                        {
                            Console.WriteLine("Entering Staffs Names for Subject {0}", item_sub.Name);
                            var staff = new Staff();
                            item_sub.Staffs.AddRange(staff.CreateStaff());
                        }
                    }
                    foreach (var item_dep in item_coll.Departments)
                    {
                        Console.WriteLine("Entering Students Names for Department {0}", item_dep.Name);
                        var stu = new Student();
                        item_dep.Students.AddRange(stu.CreateStu());
                    }
                }
            }
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
                            if (item_Stu.Grade>=50)
                            {
                                dep_succ_stu_num++;
                            }
                            dep_stu_num++;
                        }
                        coll_succ_stu_num += dep_succ_stu_num;
                        coll_stu_num += dep_stu_num;
                    }
                    double coll_per = (coll_succ_stu_num / coll_stu_num) * 100;
                    Console.WriteLine("{0} Colledge has Success Percentage of {1}%", item_Coll.Name, coll_per);
                    uni_succ_stu_num += coll_succ_stu_num;
                    uni_stu_num += coll_stu_num;
                }
                double uni_per = (uni_succ_stu_num / uni_stu_num) * 100;
                Console.WriteLine("{0} Universty has Success Percentage of {1}%", item_Uni.Name, uni_per);
            }
        }
    }
}
