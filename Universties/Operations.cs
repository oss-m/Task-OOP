using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universties
{
    public class Operations<T>
    {
        public string Name { get; set; }
        public List<Operations<T>> Group { get; set; }
        public Operations()
        {
            Group = new List<Operations<T>>();
        }
        private void Show()
        {
            Console.WriteLine("The List Entered is");
            for (int i = 0; i < Group.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, Group[i].Name);
            }
        }
        private string Del(string select3, int select2)
        {
            Group.RemoveAt(select2 - 1);
            Console.WriteLine("Please Enter E to Edit or any key to continue");
            var select1 = Console.ReadLine();
            Show();
            return select1;
        }
        private string Ed(string select3, int select2)
        {
            Console.WriteLine("Please Enter New Name");
            var newname = Console.ReadLine();
            Group.ElementAt(select2 - 1).Name = newname;
            Console.WriteLine("Please Enter E to Edit or any key to continue");
            var select1 = Console.ReadLine();
            Show();
            return select1;
        }
        private List<Operations<T>> Add()
        {
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
            Show();
            return Group;
        }
        private List<Operations<T>> Edit(List<Operations<T>> groups)
        {
            Group = groups;
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
                        select1 = Del(select3, select2);
                    }
                    if (select3 == "E")
                    {
                        select1 = Ed(select3, select2);
                    }
                }
            }
            return Group;
        }
        public List<Operations<T>> Create()
        {
            return Edit(Add());
        }
    }
}
