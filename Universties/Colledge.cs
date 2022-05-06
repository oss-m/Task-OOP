using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universties
{
    public class Colledge:Universty
    {
        public string UniverstyName { get; set; }
        public List<Subject> Subjects { get; set; }
        public List<Department> Departments { get; set; }
        public List<Staff> Staffs { get; set; }
        public Colledge()
        {
            Subjects = new List<Subject>();
            Departments = new List<Department>();
            Staffs = new List<Staff>();
        }
        protected virtual void Show(string uni_name)
        {
            UniverstyName = uni_name;
            Console.WriteLine("The List Entered is:");
            for (int i = 0; i < Colledges.Count; i++)
            {
                Console.WriteLine("{0}. {1} of {2} {3}", i + 1, Colledges[i].Name, UniverstyName, GetType().BaseType.Name);
            }
        }
        public virtual void Add(string uni_name)
        {
            Console.WriteLine("Please Enter {0} Name or Enter Done if Finished", this.GetType().Name);
            string entry = Console.ReadLine();
            while (entry != "Done")
            {
                var coll = new Colledge();
                coll.Name = entry;
                Colledges.Add(coll);
                Console.WriteLine("Please Enter Next {0} Name or Done if Finished", this.GetType().Name);
                entry = Console.ReadLine();
            }
            Show(uni_name);
        }
    }
}
