using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universties
{
    public class Colledge : Operations
    {
        public string UniName { get; set; }
        public List<Department> Departments { get; set; }
        public Colledge()
        {
            Departments = new List<Department>();
        }
        public void CollCreator(Colledge coll, Universty uni)
        {
            var uni_op = new Operations().Add(coll.GetType().Name);
            foreach (var item in uni_op)
            {
                var coll_item = new Colledge();
                coll_item.Name = item.Name;
                coll_item.Id = item.Id;
                coll_item.UniName = uni.Name;
                uni.Colledges.Add(coll_item);
                Data.DColledges.Add(coll_item);
            }
        }
        public void CollMenu(Colledge coll)
        {
            Console.WriteLine("Please Enter the University Id");
            int u_entry = int.Parse(Console.ReadLine());
            foreach (var item_uni in Data.DUniversties)
            {
                if (item_uni.Id == u_entry)
                {
                    Console.WriteLine("Entering Colledges Names for University {0}", item_uni.Name);
                    coll.CollCreator(coll, item_uni);

                }
            }
        }
    }
}
