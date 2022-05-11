using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universties
{
    public class Student : Operations<Student>
    {
        public override List<Operations<Student>> Add(List<Operations<Student>> Group)
        {
            Group = new List<Operations<Student>>();
            Console.WriteLine("Please Enter {0} Name or Enter 0 if Finished", this.GetType().Name);
            string entry = Console.ReadLine();
            while (entry != "0")
            {
                var item = new Student();
                item.Name = entry;
                Console.WriteLine("Please Enter Student {0} Grade", item.Name);
                string g = Console.ReadLine();
                if (g == null)
                {
                    item.Grade = 0;
                    Group.Add(item);
                }
                else if (g == "")
                {
                    item.Grade = 0;
                    Group.Add(item);
                }
                else
                {
                    item.Grade = double.Parse(g);
                    Group.Add(item);
                }
                Console.WriteLine("Please Enter Next {0} Name or 0 if Finished", this.GetType().Name);
                entry = Console.ReadLine();
            }
            Show(Group);
            return Group;
        }
        private string EdG(string select3, int select2, List<Operations<Student>> Group)
        {
            Console.WriteLine("Please Enter New Grade");
            var newgrade = double.Parse(Console.ReadLine());
            Group.ElementAt(select2 - 1).Grade = newgrade;
            Console.WriteLine("Please Enter E to Edit or any key to continue");
            var select1 = Console.ReadLine();
            Show(Group);
            return select1;
        }
        public override List<Operations<Student>> Edit(List<Operations<Student>> Group)
        {
            Console.WriteLine("Please Enter E to Edit or any key to continue");
            var select1 = Console.ReadLine();
            while (select1 == "E")
            {
                Console.WriteLine("Please Enter {0} Number to Edit", this.GetType().Name);
                var select2 = int.Parse(Console.ReadLine());
                if (select2 <= 0 || select2 > Group.Count)
                {
                    Console.WriteLine("Please Enter a valid Number");
                    select1 = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Please Enter D to Delete or E to Edit Name or G to Edit Grade");
                    var select3 = Console.ReadLine();
                    if (select3 == "D")
                    {
                        select1 = Del(select3, select2, Group);
                    }
                    if (select3 == "E")
                    {
                        select1 = Ed(select3, select2, Group);
                    }
                    if (select3 == "G")
                    {
                        select1 = EdG(select3, select2, Group);
                    }
                }
            }
            return Group;
        }
        //public override void Show()
        //{
        //    Console.WriteLine("The List Entered is");
        //    for (int i = 0; i < Students.Count; i++)
        //    {
        //        Console.WriteLine("{0}. {1}", i + 1, Students[i].Name);
        //    }
        //}
        //private string DelStu(string select3, int select2)
        //{
        //    Students.RemoveAt(select2 - 1);
        //    Console.WriteLine("Please Enter E to Edit or any key to continue");
        //    var select1 = Console.ReadLine();
        //    Show();
        //    return select1;
        //}
        //private string EdStu(string select3, int select2)
        //{
        //    Console.WriteLine("Please Enter New Name");
        //    var newname = Console.ReadLine();
        //    Students.ElementAt(select2 - 1).Name = newname;
        //    Console.WriteLine("Please Enter E to Edit or any key to continue");
        //    var select1 = Console.ReadLine();
        //    Show();
        //    return select1;
        //}
        //private List<Student> AddStu()
        //{
        //    Console.WriteLine("Please Enter {0} Name or Enter 0 if Finished", this.GetType().Name);
        //    string entry = Console.ReadLine();
        //    while (entry != "0")
        //    {
        //        var stu = new Student();
        //        stu.Name = entry;
        //        Console.WriteLine("Please Enter Student {0} Grade", stu.Name);
        //        stu.Grade = double.Parse(Console.ReadLine());
        //        Students.Add(stu);
        //        Console.WriteLine("Please Enter Next {0} Name or 0 if Finished", this.GetType().Name);
        //        entry = Console.ReadLine();
        //    }
        //    Show();
        //    return Students;
        //}
        //private List<Student> EditStu(List<Student> students)
        //{
        //    Students = students;
        //    Console.WriteLine("Please Enter E to Edit or any key to continue");
        //    var select1 = Console.ReadLine();
        //    while (select1 == "E")
        //    {
        //        Console.WriteLine("Please Enter {0} Number to Edit", this.GetType().Name);
        //        var select2 = int.Parse(Console.ReadLine());
        //        if (select2 <= 0 || select2 > Students.Count)
        //        {
        //            Console.WriteLine("Please Enter a valid Number");
        //            select1 = Console.ReadLine();
        //        }
        //        else
        //        {
        //            Console.WriteLine("Please Enter D to Delete or E to Edit Name");
        //            var select3 = Console.ReadLine();
        //            if (select3 == "D")
        //            {
        //                select1 = DelStu(select3, select2);
        //            }
        //            if (select3 == "E")
        //            {
        //                select1 = EdStu(select3, select2);
        //            }
        //        }
        //    }
        //    return Students;
        //}
        //public List<Student> CreateStu()
        //{
        //    return EditStu(AddStu());
        //}
    }
}
