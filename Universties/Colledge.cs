using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universties
{
    public class Colledge : Universty
    {
        public List<Department> Departments { get; set; }
        public Colledge()
        {
            Departments = new List<Department>();
        }
        public override void Show()
        {
            Console.WriteLine("The List Entered is");
            for (int i = 0; i < Colledges.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, Colledges[i].Name);
            }
        }
        private string DelColl(string select3, int select2)
        {
            Colledges.RemoveAt(select2 - 1);
            Console.WriteLine("Please Enter E to Edit or any key to continue");
            var select1 = Console.ReadLine();
            Show();
            return select1;
        }
        private string EdColl(string select3, int select2)
        {
            Console.WriteLine("Please Enter New Name");
            var newname = Console.ReadLine();
            Colledges.ElementAt(select2 - 1).Name = newname;
            Console.WriteLine("Please Enter E to Edit or any key to continue");
            var select1 = Console.ReadLine();
            Show();
            return select1;
        }
        private List<Colledge> AddColl()
        {
            Console.WriteLine("Please Enter {0} Name or Enter 0 if Finished", this.GetType().Name);
            string entry = Console.ReadLine();
            while (entry != "0")
            {
                var coll = new Colledge();
                coll.Name = entry;
                Colledges.Add(coll);
                Console.WriteLine("Please Enter Next {0} Name or 0 if Finished", this.GetType().Name);
                entry = Console.ReadLine();
            }
            Show();
            return Colledges;
        }
        private List<Colledge> EditColl(List<Colledge> colledges)
        {
            Colledges = colledges;
            Console.WriteLine("Please Enter E to Edit or any key to continue");
            var select1 = Console.ReadLine();
            while (select1 == "E")
            {
                Console.WriteLine("Please Enter {0} Number to Edit", this.GetType().Name);
                var select2 = int.Parse(Console.ReadLine());
                if (select2 <= 0 || select2 > Colledges.Count)
                {
                    Console.WriteLine("Please Enter a valid Number");
                    select1 = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Please Enter D to Delete or E to Edit Name");
                    var select3 = Console.ReadLine();
                    if (select3 == "D")
                    {
                        select1 = DelColl(select3, select2);
                    }
                    if (select3 == "E")
                    {
                        select1 = EdColl(select3, select2);
                    }
                }
            }
            return Colledges;
        }
        public List<Colledge> CreateColl()
        {
            return EditColl(AddColl());
        }
    }
}
