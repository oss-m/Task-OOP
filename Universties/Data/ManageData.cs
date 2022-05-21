using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universties
{
    public class ManageData : Data
    {
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
        private static List<string> USave()
        {
            var list = new List<string>();
            foreach (var item in DUniversties)
            {
                var a = item.Name + ',';
                var b = item.Id.ToString() + ',';
                var f = ' ';
                var s = (a + b + f);
                list.Add(s);
            }
            return list;
        }
        private static List<string> CSave()
        {
            var list = new List<string>();
            foreach (var item in DColledges)
            {
                var a = item.Name + ',';
                var b = item.UniName + ',';
                var c = item.Id.ToString() + ',';
                var d = item.UniId.ToString() + ',';
                var g = ' ';
                var s = (a + b + c + d + g);
                list.Add(s);
            }
            return list;
        }
        private static List<string> DSave()
        {
            var list = new List<string>();
            foreach (var item in DDepartments)
            {
                var a = item.Name + ',';
                var b = item.Id.ToString() + ',';
                var e = item.CollId.ToString() + ',';
                var c = item.CollName + ',';
                var d = ' ';
                var s = (a + b + e + c + d);
                list.Add(s);
            }
            return list;
        }
        private static List<string> StaSave()
        {
            var list = new List<string>();
            foreach (var item in DStaffs)
            {
                var a = item.Name + ',';
                var b = item.Id.ToString() + ',';
                var f = item.DepId.ToString() + ',';
                var g = item.SubId.ToString() + ',';
                var c = item.DepartmentName + ',';
                var d = item.SubjectName + ',';
                var e = ' ';
                var s = (a + b + f + g + c + d + e);
                list.Add(s);
            }
            return list;
        }
        private static List<string> SubSave()
        {
            var list = new List<string>();
            foreach (var item in DSubjects)
            {
                var a = item.Name + ',';
                var b = item.Id.ToString() + ',';
                var f = item.DepId.ToString() + ',';
                var g = item.StaffId.ToString() + ',';
                var c = item.DepartmentName + ',';
                var d = item.StaffName + ',';
                var e = ' ';
                var s = (a + b + f + g + c + d + e);
                list.Add(s);
            }
            return list;
        }
        private static List<string> StuSave()
        {
            var list = new List<string>();
            foreach (var item in DStudents)
            {
                var a = item.Name + ',';
                var b = item.Id.ToString() + ',';
                var f = item.DepId.ToString() + ',';
                var c = item.DepartmentName + ',';
                var d = item.Grade.ToString() + ',';
                var e = ' ';
                var s = (a + b + f + c + d + e);
                list.Add(s);
            }
            return list;
        }

        private static void URet(string path2)
        {
            if (File.Exists(path2))
            {
                var x = File.ReadAllLines(path2);
                if (x.Length == 0)
                {
                    Console.WriteLine("No Data to Retrieve");
                }
                var listu = new List<int>();
                foreach (var i in DUniversties)
                {
                    listu.Add(i.Id);
                }
                foreach (var item in x)
                {
                    var z = item.Split(',');
                    if (listu.Contains(int.Parse(z[1])) == false)
                    {
                        var u = new Universty()
                        {
                            Name = z[0],
                            Id = int.Parse(z[1])
                        };
                        DUniversties.Add(u);
                    }
                }
            }
            else
            {
                Console.WriteLine("No Data to Retrieve");
            }
        }
        private static void CRet(string path2)
        {
            if (File.Exists(path2))
            {
                var x = File.ReadAllLines(path2);
                if (x.Length == 0)
                {
                    Console.WriteLine("No Data to Retrieve");
                }
                var listu = new List<int>();
                foreach (var i in DUniversties)
                {
                    listu.Add(i.Id);
                }
                var listc = new List<int>();
                foreach (var i in DColledges)
                {
                    listc.Add(i.Id);
                }
                foreach (var item in x)
                {
                    var z = item.Split(',');
                    if (listc.Contains(int.Parse(z[2])) == false)
                    {
                        var u = new Colledge()
                        {
                            Name = z[0],
                            UniName = z[1],
                            Id = int.Parse(z[2]),
                            UniId = int.Parse(z[3])
                        };
                        DColledges.Add(u);
                    }
                }
            }
            else
            {
                Console.WriteLine("No Data to Retrieve");
            }
        }
        private static void DRet(string path2)
        {
            if (File.Exists(path2))
            {
                var x = File.ReadAllLines(path2);
                if (x.Length == 0)
                {
                    Console.WriteLine("No Data to Retrieve");
                }
                var listc = new List<int>();
                foreach (var i in DColledges)
                {
                    listc.Add(i.Id);
                }
                var listd = new List<int>();
                foreach (var i in DDepartments)
                {
                    listd.Add(i.Id);
                }
                foreach (var item in x)
                {
                    var z = item.Split(',');
                    if (listd.Contains(int.Parse(z[2])) == false)
                    {
                        var d = new Department()
                        {
                            Name = z[0],
                            Id = int.Parse(z[1]),
                            CollId = int.Parse(z[2]),
                            CollName = z[3],
                        };
                        DDepartments.Add(d);
                    }
                }
            }
            else
            {
                Console.WriteLine("No Data to Retrieve");
            }
        }
        private static void SubRet(string path2)
        {
            if (File.Exists(path2))
            {
                var x = File.ReadAllLines(path2);
                if (x.Length == 0)
                {
                    Console.WriteLine("No Data to Retrieve");
                }
                var listd = new List<int>();
                foreach (var i in DDepartments)
                {
                    listd.Add(i.Id);
                }
                var liststaff = new List<int>();
                foreach (var i in DStaffs)
                {
                    liststaff.Add(i.Id);
                }
                var listsub = new List<int>();
                foreach (var i in DSubjects)
                {
                    listsub.Add(i.Id);
                }
                foreach (var item in x)
                {
                    var z = item.Split(',');
                    if (listsub.Contains(int.Parse(z[2])) == false)
                    {
                        var s1 = new Subject()
                        {
                            Name = z[0],
                            Id = int.Parse(z[1]),
                            DepId = int.Parse(z[2]),
                            StaffId = int.Parse(z[3]),
                            DepartmentName = z[4],
                            StaffName = z[5],
                        };
                        DSubjects.Add(s1);
                    }
                }
            }
            else
            {
                Console.WriteLine("No Data to Retrieve");
            }
        }
        private static void StaffRet(string path2)
        {
            if (File.Exists(path2))
            {
                var x = File.ReadAllLines(path2);
                if (x.Length == 0)
                {
                    Console.WriteLine("No Data to Retrieve");
                }
                var listd = new List<int>();
                foreach (var i in DDepartments)
                {
                    listd.Add(i.Id);
                }
                var liststaff = new List<int>();
                foreach (var i in DStaffs)
                {
                    liststaff.Add(i.Id);
                }
                var listsub = new List<int>();
                foreach (var i in DSubjects)
                {
                    listsub.Add(i.Id);
                }
                foreach (var item in x)
                {
                    var z = item.Split(',');
                    if (liststaff.Contains(int.Parse(z[2])) == false)
                    {
                        var s2 = new Staff()
                        {
                            Name = z[0],
                            Id = int.Parse(z[1]),
                            DepId = int.Parse(z[2]),
                            SubId = int.Parse(z[3]),
                            DepartmentName = z[4],
                            SubjectName = z[5],
                        };
                        DStaffs.Add(s2);
                    }
                }
            }
            else
            {
                Console.WriteLine("No Data to Retrieve");
            }
        }
        private static void StuRet(string path2)
        {
            if (File.Exists(path2))
            {
                var x = File.ReadAllLines(path2);
                if (x.Length == 0)
                {
                    Console.WriteLine("No Data to Retrieve");
                }
                var listd = new List<int>();
                foreach (var i in DDepartments)
                {
                    listd.Add(i.Id);
                }
                var liststud = new List<int>();
                foreach (var i in DStudents)
                {
                    liststud.Add(i.Id);
                }
                foreach (var item in x)
                {
                    var z = item.Split(',');
                    if (liststud.Contains(int.Parse(z[2])) == false)
                    {
                        var s3 = new Student()
                        {
                            Name = z[0],
                            Id = int.Parse(z[1]),
                            DepId = int.Parse(z[2]),
                            DepartmentName = z[3],
                            Grade = double.Parse(z[4]),
                        };
                        DStudents.Add(s3);
                    }
                }
            }
            else
            {
                Console.WriteLine("No Data to Retrieve");
            }
        }
        private static void ItemsAdd()
        {
            foreach (var u in DUniversties)
            {
                foreach (var c in DColledges)
                {
                    if (c.UniId == u.Id)
                    {
                        u.Colledges.Add(c);
                    }
                }
            }
            foreach (var c in DColledges)
            {
                foreach (var d in DDepartments)
                {
                    if (d.CollId == c.Id)
                    {
                        c.Departments.Add(d);
                    }
                }
            }
            foreach (var d in DDepartments)
            {
                foreach (var stu in DStudents)
                {
                    if (stu.DepId == d.Id)
                    {
                        d.Students.Add(stu);
                    }
                }
            }
            foreach (var d in DDepartments)
            {
                foreach (var staff in DStaffs)
                {
                    if (staff.DepId == d.Id)
                    {
                        d.Staffs.Add(staff);
                    }
                }
            }
            foreach (var d in DDepartments)
            {
                foreach (var sub in DSubjects)
                {
                    if (sub.DepId == d.Id)
                    {
                        d.Subjects.Add(sub);
                    }
                }
            }
            foreach (var sub in DSubjects)
            {
                foreach (var staff in DStaffs)
                {
                    if (staff.DepId == sub.Id)
                    {
                        sub.Staffs.Add(staff);
                    }
                }
            }
            foreach (var staff in DStaffs)
            {
                foreach (var sub in DSubjects)
                {
                    if (sub.DepId == staff.Id)
                    {
                        staff.Subjects.Add(sub);
                    }
                }
            }
        }

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
        public static void SaveData()
        {
            string path = @"C:\UMP";
            Console.WriteLine("All Data will be saved at {0}", path);
            var lists = @"\Universties.txt " + @"\Colledges.txt " + @"\Departments.txt " + @"\Subjects.txt " + @"\Staff.txt " + @"\Students.txt";
            var txtlist = lists.Split(' ');
            string s = "";
            foreach (var path1 in txtlist)
            {
                string path2 = path + path1;
                if (path1 == @"\Universties.txt")
                {
                    Save(path2, USave());
                }
                if (path1 == @"\Colledges.txt")
                {
                    Save(path2, CSave());
                }
                if (path1 == @"\Departments.txt")
                {
                    Save(path2, DSave());
                }
                if (path1 == @"\Subjects.txt")
                {
                    Save(path2, SubSave());
                }
                if (path1 == @"\Staff.txt")
                {
                    Save(path2, StaSave());
                }
                if (path1 == @"\Students.txt")
                {
                    Save(path2, StuSave());
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
                    URet(path2);
                }
                if (path1 == @"\Colledges.txt")
                {
                    CRet(path2);
                }
                if (path1 == @"\Departments.txt")
                {
                    DRet(path2);
                }
                if (path1 == @"\Subjects.txt")
                {
                    SubRet(path2);
                }
                if (path1 == @"\Staff.txt")
                {
                    StaffRet(path2);
                }
                if (path1 == @"\Students.txt")
                {
                    StuRet(path2);
                }
            }
            ItemsAdd();
            Console.WriteLine("Done");
        }
    }
}
