using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universties
{
    public class Data
    {
        public static List<Universty> DUniversties { get; set; }
        public static List<Colledge> DColledges { get; set; }
        public static List<Department> DDepartments { get; set; }
        public static List<Staff> DStaffs { get; set; }
        public static List<Subject> DSubjects { get; set; }
        public static List<Student> DStudents { get; set; }
        public static void Per()
        {
            foreach (var uitem in DUniversties)
            {
                double uni_succ_stu_num = 0;
                double uni_stu_num = 0;
                foreach (var citem in uitem.Colledges)
                {
                    double coll_succ_stu_num = 0;
                    double coll_stu_num = 0;
                    foreach (var ditem in citem.Departments)
                    {
                        double dep_succ_stu_num = 0;
                        double dep_stu_num = 0;
                        foreach (var sitem in ditem.Students)
                        {
                            if (sitem.Grade != null)
                            {
                                if (sitem.Grade >= 50)
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
                    citem.Tot = coll_stu_num;
                    citem.Suc = coll_succ_stu_num;
                    double coll_per = (coll_succ_stu_num / coll_stu_num) * 100;
                    citem.Per = coll_per;
                    uni_succ_stu_num += coll_succ_stu_num;
                    uni_stu_num += coll_stu_num;
                }
                uitem.Tot = uni_stu_num;
                uitem.Suc = uni_succ_stu_num;
                double uni_per = (uni_succ_stu_num / uni_stu_num) * 100;
                uitem.Per = uni_per;
            }
            
        }
    }
}
