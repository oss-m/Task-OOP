using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universties
{
    public class Data
    {
        public static string path { get; set; }
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
        public static void CreateFiles()
        {
            Console.WriteLine("Please Enter File Path");
            path = Console.ReadLine();
            var lists = @"\Universties.txt " + @"\Colledges.txt " + @"\Departments.txt " + @"\Subjects.txt " + @"\Staff.txt " + @"\Students.txt";
            var txtlist = lists.Split(' ');
            foreach (var path1 in txtlist)
            {
                string path2 = path + path1;
                using (StreamWriter txt1 = File.CreateText(path2))
                {
                    if (path1 == @"\Universties.txt")
                    {
                        foreach (var item in DUniversties)
                        {
                            var a = item.Name + ',';
                            var b = item.Id.ToString() + ',';
                            var c = item.Suc.ToString() + ',';
                            var d = item.Tot.ToString() + ',';
                            var e = item.Per.ToString() + ',';
                            var f = ' ';
                            txt1.WriteLine(a + b + c + d + e + f);
                        }
                    }
                    if (path1 == @"\Colledges.txt")
                    {
                        foreach (var item in DColledges)
                        {
                            var a = item.Name + ',';
                            var b = item.UniName + ',';
                            var c = item.Id.ToString() + ',';
                            var d = item.Suc.ToString() + ',';
                            var e = item.Tot.ToString() + ',';
                            var f = item.Per.ToString() + ',';
                            var g = ' ';
                            txt1.WriteLine(a + b + c + d + e + f + g);
                        }
                    }
                    if (path1 == @"\Departments.txt")
                    {
                        foreach (var item in DDepartments)
                        {
                            var a = item.Name + ',';
                            var b = item.Id.ToString() + ',';
                            var c = item.CollName + ',';
                            var d = ' ';
                            txt1.WriteLine(a + b + c + d);
                        }
                    }
                    if (path1 == @"\Subjects.txt")
                    {
                        foreach (var item in DSubjects)
                        {
                            var a = item.Name + ',';
                            var b = item.Id.ToString() + ',';
                            var c = item.DepartmentName + ',';
                            var d = item.StaffName + ',';
                            var e = ' ';
                            txt1.WriteLine(a + b + c + d + e);
                        }
                    }
                    if (path1 == @"\Staff.txt")
                    {
                        foreach (var item in DStaffs)
                        {
                            var a = item.Name + ',';
                            var b = item.Id.ToString() + ',';
                            var c = item.DepartmentName + ',';
                            var d = item.SubjectName +',';
                            var e = ' ';
                            txt1.WriteLine(a + b + c + d + e);
                        }
                    }
                    if (path1 == @"\Students.txt")
                    {
                        foreach (var item in DStudents)
                        {
                            var a = item.Name + ',';
                            var b = item.Id.ToString() + ',';
                            var c = item.DepartmentName + ',';
                            var d = item.Grade.ToString() + ',';
                            var e = ' ';
                            txt1.WriteLine(a + b + c + d + e);
                        }
                    }
                }
            }
            Console.WriteLine("Done");
        }
        public static void RetrieveFiles()
        {
            Console.WriteLine("Please Enter File Path");
            path = Console.ReadLine();
            var lists = @"\Universties.txt " + @"\Colledges.txt " + @"\Departments.txt " + @"\Subjects.txt " + @"\Staff.txt " + @"\Students.txt";
            var txtlist = lists.Split(' ');
            foreach (var path1 in txtlist)
            {
                string path2 = path + path1;
                string s = "";
                using (StreamReader txt2 = File.OpenText(path2))
                {
                    if (path1 == @"\Universties.txt")
                    {
                        var x = new List<string>();
                        while ((s = txt2.ReadLine()) != null)
                        {
                            x.Add(s);
                        }
                        foreach (var item in x)
                        {
                            var z = item.Split(',');
                            var u = new Universty()
                            {
                                Name = z[0],
                                Id = int.Parse(z[1]),
                                Suc = double.Parse(z[2]),
                                Tot = double.Parse(z[3]),
                                Per = double.Parse(z[4])
                            };
                            DUniversties.Add(u);
                        }
                    }
                    if (path1 == @"\Colledges.txt")
                    {
                        var x = new List<string>();
                        while ((s = txt2.ReadLine()) != null)
                        {
                            x.Add(s);
                        }
                        foreach (var item in x)
                        {
                            var z = item.Split(',');
                            var c = new Colledge()
                            {
                                Name = z[0],
                                UniName = z[1],
                                Id = int.Parse(z[2]),
                                Suc = double.Parse(z[3]),
                                Tot = double.Parse(z[4]),
                            };
                            DColledges.Add(c);
                        }
                    }
                    if (path1 == @"\Departments.txt")
                    {
                        var x = new List<string>();
                        while ((s = txt2.ReadLine()) != null)
                        {
                            x.Add(s);
                        }
                        foreach (var item in x)
                        {
                            var z = item.Split(',');
                            var d = new Department()
                            {
                                Name = z[0],
                                Id = int.Parse(z[1]),
                                CollName = z[2],
                            };
                            DDepartments.Add(d);
                        }
                    }
                    if (path1 == @"\Subjects.txt")
                    {
                        var x = new List<string>();
                        while ((s = txt2.ReadLine()) != null)
                        {
                            x.Add(s);
                        }
                        foreach (var item in x)
                        {
                            var z = item.Split(',');
                            var s1 = new Subject()
                            {
                                Name = z[0],
                                Id = int.Parse(z[1]),
                                DepartmentName = z[2],
                                StaffName = z[3],
                            };
                            DSubjects.Add(s1);
                        }
                    }
                    if (path1 == @"\Staff.txt")
                    {
                        var x = new List<string>();
                        while ((s = txt2.ReadLine()) != null)
                        {
                            x.Add(s);
                        }
                        foreach (var item in x)
                        {
                            var z = item.Split(',');
                            var s2 = new Staff()
                            {
                                Name = z[0],
                                Id = int.Parse(z[1]),
                                DepartmentName = z[2],
                                SubjectName = z[3],
                            };
                            DStaffs.Add(s2);
                        }
                    }
                    if (path1 == @"\Students.txt")
                    {
                        var x = new List<string>();
                        while ((s = txt2.ReadLine()) != null)
                        {
                            x.Add(s);
                        }
                        foreach (var item in x)
                        {
                            var z = item.Split(',');
                            var s3 = new Student()
                            {
                                Name = z[0],
                                Id = int.Parse(z[1]),
                                DepartmentName = z[2],
                                Grade = double.Parse(z[3]),
                            };
                            DStudents.Add(s3);
                        }
                    }
                }
            }
            Console.WriteLine("Done");
        }
    }
}
