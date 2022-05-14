using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universties
{
    public class Operations
    {
        public string Name { get; set; }
        public double? Grade { get; set; }
        public List<Operations> Groups { get; set; }
        protected List<Operations> Add(List<Operations> Group, String class_name)
        {
            Group = new List<Operations>();
            Console.WriteLine("Please Enter {0} Name or Enter 0 if Finished", class_name);
            string entry = Console.ReadLine();
            while (entry != "0")
            {
                var item = new Operations();
                item.Name = entry;
                if (class_name== "Student")
                {
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
                else
                {
                    Group.Add(item);
                    Console.WriteLine("Please Enter Next {0} Name or 0 if Finished", class_name);
                    entry = Console.ReadLine();
                }
            }
            Show(Group, class_name);
            return Group;
        }
        protected void Show(List<Operations> Group, String str)
        {
            if (str == "Student")
            {
                Console.WriteLine("The List Entered is:");
                for (int i = 0; i < Group.Count; i++)
                {
                    Console.WriteLine("{0}. {1}, Grade is {2}", i + 1, Group[i].Name, Group[i].Grade);
                }
            }
            else
            {
                Console.WriteLine("The List Entered is:");
                for (int i = 0; i < Group.Count; i++)
                {
                    Console.WriteLine("{0}. {1} {2}", i + 1, Group[i].Name, str);
                }
            }
        }
        protected string Del(string select3, int select2, List<Operations> Group)
        {
            var class_name = this.GetType().Name;
            Group.RemoveAt(select2 - 1);
            Console.WriteLine("Please Enter E to Edit or any key to continue");
            var select1 = Console.ReadLine();
            Show(Group, class_name);
            return select1;
        }
        protected string Ed(string select3, int select2, List<Operations> Group)
        {
            var class_name = this.GetType().Name;
            Console.WriteLine("Please Enter New Name");
            var newname = Console.ReadLine();
            Group.ElementAt(select2 - 1).Name = newname;
            Console.WriteLine("Please Enter E to Edit or any key to continue");
            var select1 = Console.ReadLine();
            Show(Group, class_name);
            return select1;
        }
        protected string EdG(string select3, int select2, List<Operations> Group)
        {
            var class_name = this.GetType().Name;
            Console.WriteLine("Please Enter New Grade");
            var newgrade = double.Parse(Console.ReadLine());
            Group.ElementAt(select2 - 1).Grade = newgrade;
            Console.WriteLine("Please Enter E to Edit or any key to continue");
            var select1 = Console.ReadLine();
            Show(Group, class_name);
            return select1;
        }
        protected List<Operations> Edit(List<Operations> Group, String str)
        {
            Console.WriteLine("Please Enter E to Edit or any key to continue");
            var select1 = Console.ReadLine();
            while (select1 == "E")
            {
                Console.WriteLine("Please Enter {0} Number to Edit", str);
                var select2 = int.Parse(Console.ReadLine());
                if (select2 <= 0 || select2 > Group.Count)
                {
                    Console.WriteLine("Please Enter a valid Number");
                    select1 = Console.ReadLine();
                }
                else
                {
                    if (str == "Student")
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
            }
            return Group;
        }
        public List<Operations> Create(List<Operations> Group, String class_name)
        {
            return Edit(Add(Group, class_name), class_name);
        }
    }
}
