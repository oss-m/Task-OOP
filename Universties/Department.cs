using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universties
{
    public class Department : Colledge
    {
        public List<Student> Students { get; set; }
        public List<Subject> Subjects { get; set; }
        public Department()
        {
            Students = new List<Student>();
            Subjects = new List<Subject>();
        }
        public override void Show()
        {
            Console.WriteLine("The List Entered is");
            for (int i = 0; i < Departments.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, Departments[i].Name);
            }
        }
        private string DelDep(string select3, int select2)
        {
            Departments.RemoveAt(select2 - 1);
            Console.WriteLine("Please Enter E to Edit or any key to continue");
            var select1 = Console.ReadLine();
            Show();
            return select1;
        }
        private string EdDep(string select3, int select2)
        {
            Console.WriteLine("Please Enter New Name");
            var newname = Console.ReadLine();
            Departments.ElementAt(select2 - 1).Name = newname;
            Console.WriteLine("Please Enter E to Edit or any key to continue");
            var select1 = Console.ReadLine();
            Show();
            return select1;
        }
        private List<Department> AddDep()
        {
            Console.WriteLine("Please Enter {0} Name or Enter 0 if Finished", this.GetType().Name);
            string entry = Console.ReadLine();
            while (entry != "0")
            {
                var dep = new Department();
                dep.Name = entry;
                Departments.Add(dep);
                Console.WriteLine("Please Enter Next {0} Name or 0 if Finished", this.GetType().Name);
                entry = Console.ReadLine();
            }
            Show();
            return Departments;
        }
        private List<Department> EditDep(List<Department> departments)
        {
            Departments = departments;
            Console.WriteLine("Please Enter E to Edit or any key to continue");
            var select1 = Console.ReadLine();
            while (select1 == "E")
            {
                Console.WriteLine("Please Enter {0} Number to Edit", this.GetType().Name);
                var select2 = int.Parse(Console.ReadLine());
                if (select2 <= 0 || select2 > Departments.Count)
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
                        select1 = DelDep(select3, select2);
                    }
                    if (select3 == "E")
                    {
                        select1 = EdDep(select3, select2);
                    }
                }
            }
            return Departments;
        }
        public List<Department> CreateDep()
        {
            return EditDep(AddDep());
        }
    }
}
