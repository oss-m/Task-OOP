using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universties
{
    public class Universty : Operations<Universty>
    {
        public Universty()
        {
            
            
        }
        //public string Name { get; set; }
        //public List<Universty> Universties { get; set; }
        //public List<Colledge> Colledges { get; set; }
        //public Universty()
        //{
        //    Universties = new List<Operations<Universty>>();
        //    Colledges = new List<>(Operations<Colledge>);
        //}
        //public virtual void Show()
        //{
        //    Console.WriteLine("The List Entered is");
        //    for (int i = 0; i < Universties.Count; i++)
        //    {
        //        Console.WriteLine("{0}. {1}", i + 1, Universties[i].Name);
        //    }
        //}
        //private string DelUni(string select3, int select2)
        //{
        //    Universties.RemoveAt(select2 - 1);
        //    Console.WriteLine("Please Enter E to Edit or any key to continue");
        //    var select1 = Console.ReadLine();
        //    Show();
        //    return select1;
        //}
        //private string EdUni(string select3, int select2)
        //{
        //    Console.WriteLine("Please Enter New Name");
        //    var newname = Console.ReadLine();
        //    Universties.ElementAt(select2 - 1).Name = newname;
        //    Console.WriteLine("Please Enter E to Edit or any key to continue");
        //    var select1 = Console.ReadLine();
        //    Show();
        //    return select1;
        //}
        //private List<Universty> AddUni()
        //{
        //    Console.WriteLine("Please Enter {0} Name or Enter 0 if Finished", this.GetType().Name);
        //    string entry = Console.ReadLine();
        //    while (entry != "0")
        //    {
        //        var uni = new Universty();
        //        uni.Name = entry;
        //        Universties.Add(uni);
        //        Console.WriteLine("Please Enter Next {0} Name or 0 if Finished", this.GetType().Name);
        //        entry = Console.ReadLine();
        //    }
        //    Show();
        //    return Universties;
        //}
        //private List<Universty> EditUni(List<Universty> universties)
        //{
        //    Universties = universties;
        //    Console.WriteLine("Please Enter E to Edit or any key to continue");
        //    var select1 = Console.ReadLine();
        //    while (select1 == "E")
        //    {
        //        Console.WriteLine("Please Enter {0} Number to Edit", this.GetType().Name);
        //        var select2 = int.Parse(Console.ReadLine());
        //        if (select2 <= 0 || select2 > Universties.Count)
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
        //                select1 = DelUni(select3, select2);
        //            }
        //            if (select3 == "E")
        //            {
        //                select1 = EdUni(select3, select2);
        //            }
        //        }
        //    }
        //    return Universties;
        //}
        //public List<Universty> CreateUni()
        //{
        //    return EditUni(AddUni());
        //}
    }
}
