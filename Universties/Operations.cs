using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universties
{
    public class Operations<T> : I_Operations<T>
    {
        public string Name { get; set; }
        public List<Operations<Universty>> Universties { get; set; }
        public List<Operations<Colledge>> Colledges { get; set; }
        public List<Operations<Department>> Departments { get; set; }
        public List<Operations<Subject>> Subjects { get; set; }
        public List<Operations<Student>> Students { get; set; }
        public List<Operations<Staff>> Staffs { get; set; }
        public double? Grade { get; set; }
        public virtual List<Operations<T>> Add(List<Operations<T>> Group)
        {
            Group = new List<Operations<T>>();
            Console.WriteLine("Please Enter {0} Name or Enter 0 if Finished", this.GetType().Name);
            string entry = Console.ReadLine();
            while (entry != "0")
            {
                var item = new Operations<T>();
                item.Name = entry;
                Group.Add(item);
                Console.WriteLine("Please Enter Next {0} Name or 0 if Finished", this.GetType().Name);
                entry = Console.ReadLine();
            }
            Show(Group);
            return Group;
        }
        public virtual void Show(List<Operations<T>> Group)
        {
            Console.WriteLine("The List Entered is:");
            for (int i = 0; i < Group.Count; i++)
            {
                Console.WriteLine("{0}. {1} {2}", i + 1, Group[i].Name, GetType().Name);
            }
        }
        protected string Del(string select3, int select2, List<Operations<T>> Group)
        {
            Group.RemoveAt(select2 - 1);
            Console.WriteLine("Please Enter E to Edit or any key to continue");
            var select1 = Console.ReadLine();
            Show(Group);
            return select1;
        }
        protected string Ed(string select3, int select2, List<Operations<T>> Group)
        {
            Console.WriteLine("Please Enter New Name");
            var newname = Console.ReadLine();
            Group.ElementAt(select2 - 1).Name = newname;
            Console.WriteLine("Please Enter E to Edit or any key to continue");
            var select1 = Console.ReadLine();
            Show(Group);
            return select1;
        }
        public virtual List<Operations<T>> Edit(List<Operations<T>> Group)
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
                    Console.WriteLine("Please Enter D to Delete or E to Edit Name");
                    var select3 = Console.ReadLine();
                    if (select3 == "D")
                    {
                        select1 = Del(select3, select2, Group);
                    }
                    if (select3 == "E")
                    {
                        select1 = Ed(select3, select2, Group);
                    }
                }
            }
            return Group;
        }
        public List<Operations<T>> Create(List<Operations<T>> Group)
        {
            return Edit(Add(Group));
        }
    }
}
