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
        private static void Save(string path, List<string> list)
        {
            if (File.Exists(path))
            {
                var list2 = File.ReadAllLines(path);
                var list3 = new List<string>();
                list3.AddRange(list);
                foreach (var i in list)
                {
                    foreach (var j in list2)
                    {
                        if (i == j)
                        {
                            list3.Remove(i);
                        }
                    }
                }
                File.AppendAllLines(path, list3);
            }
            else
            {
                File.AppendAllLines(path, list);
            }
        }
        public static void SaveData()
        {
            string path = @"C:\UMP";
            Console.WriteLine("All Data will be saved at {0}",path);
            var lists = @"\Universties.txt " + @"\Colledges.txt " + @"\Departments.txt " + @"\Subjects.txt " + @"\Staff.txt " + @"\Students.txt";
            var txtlist = lists.Split(' ');
            string s = "";
            foreach (var path1 in txtlist)
            {
                string path2 = path + path1;
                if (path1 == @"\Universties.txt")
                {
                    var list = new List<string>();
                    foreach (var item in DUniversties)
                    {
                        var a = item.Name + ',';
                        var b = item.Id.ToString() + ',';
                        var f = ' ';
                        s = (a + b + f);
                        list.Add(s);
                    }
                    Save(path2, list);
                }
                if (path1 == @"\Colledges.txt")
                {
                    var list = new List<string>();
                    foreach (var item in DColledges)
                    {
                        var a = item.Name + ',';
                        var b = item.UniName + ',';
                        var c = item.Id.ToString() + ',';
                        var g = ' ';
                        s = (a + b + c + g);
                        list.Add(s);
                    }
                    Save(path2, list);
                }
                if (path1 == @"\Departments.txt")
                {
                    var list = new List<string>();
                    foreach (var item in DDepartments)
                    {
                        var a = item.Name + ',';
                        var b = item.Id.ToString() + ',';
                        var c = item.CollName + ',';
                        var d = ' ';
                        s = (a + b + c + d);
                        list.Add(s);
                    }
                    Save(path2, list);
                }
                if (path1 == @"\Subjects.txt")
                {
                    var list = new List<string>();
                    foreach (var item in DSubjects)
                    {
                        var a = item.Name + ',';
                        var b = item.Id.ToString() + ',';
                        var c = item.DepartmentName + ',';
                        var d = item.StaffName + ',';
                        var e = ' ';
                        s = (a + b + c + d + e);
                        list.Add(s);
                    }
                    Save(path2, list);
                }
                if (path1 == @"\Staff.txt")
                {
                    var list = new List<string>();
                    foreach (var item in DStaffs)
                    {
                        var a = item.Name + ',';
                        var b = item.Id.ToString() + ',';
                        var c = item.DepartmentName + ',';
                        var d = item.SubjectName + ',';
                        var e = ' ';
                        s = (a + b + c + d + e);
                        list.Add(s);
                    }
                    Save(path2, list);
                }
                if (path1 == @"\Students.txt")
                {
                    var list = new List<string>();
                    foreach (var item in DStudents)
                    {
                        var a = item.Name + ',';
                        var b = item.Id.ToString() + ',';
                        var c = item.DepartmentName + ',';
                        var d = item.Grade.ToString() + ',';
                        var e = ' ';
                        s = (a + b + c + d + e);
                        list.Add(s);
                    }
                    Save(path2, list);
                }
            }
            Console.WriteLine("Done");
        }
        public static void RetrieveData()
        {
            string path = @"C:\UMP";
            Console.WriteLine(@"Data will be retrieved from {0}", path);
            var lists = @"\Universties.txt " + @"\Colledges.txt " + @"\Departments.txt " + @"\Subjects.txt " + @"\Staff.txt " + @"\Students.txt";
            var txtlist = lists.Split(' ');
            foreach (var path1 in txtlist)
            {
                string path2 = path + path1;
                if (path1 == @"\Universties.txt")
                {
                    if (File.Exists(path2))
                    {
                        var x = File.ReadAllLines(path2);
                        if (x.Length==0)
                        {
                            Console.WriteLine("No Data to Retrieve");
                        }
                        foreach (var item in x)
                        {
                            var z = item.Split(',');
                            var u = new Universty()
                            {
                                Name = z[0],
                                Id = int.Parse(z[1])
                            };
                            DUniversties.Add(u);
                        }
                    }
                    else
                    {
                        Console.WriteLine("No Data to Retrieve");
                    }
                }
                if (path1 == @"\Colledges.txt")
                {
                    if (File.Exists(path2))
                    {
                        var x = File.ReadAllLines(path2);
                        if (x.Length == 0)
                        {
                            Console.WriteLine("No Data to Retrieve");
                        }
                        foreach (var item in x)
                        {
                            var z = item.Split(',');
                            var u = new Colledge()
                            {
                                Name = z[0],
                                UniName = z[1],
                                Id = int.Parse(z[2])
                            };
                            DColledges.Add(u);
                        }
                    }
                    else
                    {
                        Console.WriteLine("No Data to Retrieve");
                    }
                }
                if (path1 == @"\Departments.txt")
                {
                    if (File.Exists(path2))
                    {
                        var x = File.ReadAllLines(path2);
                        if (x.Length == 0)
                        {
                            Console.WriteLine("No Data to Retrieve");
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
                    else
                    {
                        Console.WriteLine("No Data to Retrieve");
                    }
                }
                if (path1 == @"\Subjects.txt")
                {
                    if (File.Exists(path2))
                    {
                        var x = File.ReadAllLines(path2);
                        if (x.Length == 0)
                        {
                            Console.WriteLine("No Data to Retrieve");
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
                    else
                    {
                        Console.WriteLine("No Data to Retrieve");
                    }
                }
                if (path1 == @"\Staff.txt")
                {
                    if (File.Exists(path2))
                    {
                        var x = File.ReadAllLines(path2);
                        if (x.Length == 0)
                        {
                            Console.WriteLine("No Data to Retrieve");
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
                    else
                    {
                        Console.WriteLine("No Data to Retrieve");
                    }
                }
                if (path1 == @"\Students.txt")
                {
                    if (File.Exists(path2))
                    {
                        var x = File.ReadAllLines(path2);
                        if (x.Length == 0)
                        {
                            Console.WriteLine("No Data to Retrieve");
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
                    else
                    {
                        Console.WriteLine("No Data to Retrieve");
                    }
                }
            }
            Console.WriteLine("Done");
        }
    }
}
