using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universties
{
    public class Subject : Operations<Subject>
    {
        //public List<Staff> Staffs { get; set; }
        //public Subject()
        //{
        //    Staffs = new List<Staff>();
        //}
        //public override void Show()
        //{
        //    Console.WriteLine("The List Entered is");
        //    for (int i = 0; i < Subjects.Count; i++)
        //    {
        //        Console.WriteLine("{0}. {1}", i + 1, Subjects[i].Name);
        //    }
        //}
        //private string DelSubj(string select3, int select2)
        //{
        //    Subjects.RemoveAt(select2 - 1);
        //    Console.WriteLine("Please Enter E to Edit or any key to continue");
        //    var select1 = Console.ReadLine();
        //    Show();
        //    return select1;
        //}
        //private string EdSubj(string select3, int select2)
        //{
        //    Console.WriteLine("Please Enter New Name");
        //    var newname = Console.ReadLine();
        //    Subjects.ElementAt(select2 - 1).Name = newname;
        //    Console.WriteLine("Please Enter E to Edit or any key to continue");
        //    var select1 = Console.ReadLine();
        //    Show();
        //    return select1;
        //}
        //private List<Subject> AddSubj()
        //{
        //    Console.WriteLine("Please Enter {0} Name or Enter 0 if Finished", this.GetType().Name);
        //    string entry = Console.ReadLine();
        //    while (entry != "0")
        //    {
        //        var sub = new Subject();
        //        sub.Name = entry;
        //        Subjects.Add(sub);
        //        Console.WriteLine("Please Enter Next {0} Name or 0 if Finished", this.GetType().Name);
        //        entry = Console.ReadLine();
        //    }
        //    Show();
        //    return Subjects;
        //}
        //private List<Subject> EditSubj(List<Subject> subjects)
        //{
        //    Subjects = subjects;
        //    Console.WriteLine("Please Enter E to Edit or any key to continue");
        //    var select1 = Console.ReadLine();
        //    while (select1 == "E")
        //    {
        //        Console.WriteLine("Please Enter {0} Number to Edit", this.GetType().Name);
        //        var select2 = int.Parse(Console.ReadLine());
        //        if (select2 <= 0 || select2 > Subjects.Count)
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
        //                select1 = DelSubj(select3, select2);
        //            }
        //            if (select3 == "E")
        //            {
        //                select1 = EdSubj(select3, select2);
        //            }
        //        }
        //    }
        //    return Subjects;
        //}
        //public List<Subject> CreateSubj()
        //{
        //    return EditSubj(AddSubj());
        //}
    }
}
