using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universties
{
    public class Staff : Subject
    {
        //public override void Show()
        //{
        //    Console.WriteLine("The List Entered is");
        //    for (int i = 0; i < Staffs.Count; i++)
        //    {
        //        Console.WriteLine("{0}. {1}", i + 1, Staffs[i].Name);
        //    }
        //}
        //private string DelStaff(string select3, int select2)
        //{
        //    Staffs.RemoveAt(select2 - 1);
        //    Console.WriteLine("Please Enter E to Edit or any key to continue");
        //    var select1 = Console.ReadLine();
        //    Show();
        //    return select1;
        //}
        //private string EdStaff(string select3, int select2)
        //{
        //    Console.WriteLine("Please Enter New Name");
        //    var newname = Console.ReadLine();
        //    Staffs.ElementAt(select2 - 1).Name = newname;
        //    Console.WriteLine("Please Enter E to Edit or any key to continue");
        //    var select1 = Console.ReadLine();
        //    Show();
        //    return select1;
        //}
        //private List<Staff> AddStaff()
        //{
        //    Console.WriteLine("Please Enter {0} Name or Enter 0 if Finished", this.GetType().Name);
        //    string entry = Console.ReadLine();
        //    while (entry != "0")
        //    {
        //        var staff = new Staff();
        //        staff.Name = entry;
        //        Staffs.Add(staff);
        //        Console.WriteLine("Please Enter Next {0} Name or 0 if Finished", this.GetType().Name);
        //        entry = Console.ReadLine();
        //    }
        //    Show();
        //    return Staffs;
        //}
        //private List<Staff> EditStaff(List<Staff> staffs)
        //{
        //    Staffs = staffs;
        //    Console.WriteLine("Please Enter E to Edit or any key to continue");
        //    var select1 = Console.ReadLine();
        //    while (select1 == "E")
        //    {
        //        Console.WriteLine("Please Enter {0} Number to Edit", this.GetType().Name);
        //        var select2 = int.Parse(Console.ReadLine());
        //        if (select2 <= 0 || select2 > Staffs.Count)
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
        //                select1 = DelStaff(select3, select2);
        //            }
        //            if (select3 == "E")
        //            {
        //                select1 = EdStaff(select3, select2);
        //            }
        //        }
        //    }
        //    return Staffs;
        //}
        //public List<Staff> CreateStaff()
        //{
        //    return EditStaff(AddStaff());
        //}
    }
}
