using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universties
{
    public class Department : Colledge
    {
        public string ColledgeName { get; set; }
        protected override void Show(string coll_name)
        {
            ColledgeName = coll_name;
            Console.WriteLine("The List Entered is:");
            for (int i = 0; i < Departments.Count; i++)
            {
                Console.WriteLine("{0}. {1} of {2} {3}", i + 1, Departments[i].Name, ColledgeName, GetType().BaseType.Name);
            }
        }
        public override void Add(string coll_name)
        {
            Console.WriteLine("Please Enter {0} Name or Enter Done if Finished", this.GetType().Name);
            string entry = Console.ReadLine();
            while (entry != "Done")
            {
                var dep = new Department();
                dep.Name = entry;
                Departments.Add(dep);
                Console.WriteLine("Please Enter Next {0} Name or Done if Finished", this.GetType().Name);
                entry = Console.ReadLine();
            }
            Show(coll_name);
        }
    }
}
