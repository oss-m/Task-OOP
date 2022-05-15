using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universties
{
    public class Universty : Operations
    {
        public List<Universty> Universties { get; set; }
        public List<Colledge> Colledges { get; set; }
        public Universty()
        {
            Universties = new List<Universty>();
            Colledges = new List<Colledge>();
        }
        public void UniCreator(Universty uni)
        {
            var uni_op = new Operations().Add(uni.GetType().Name);
            foreach (var item in uni_op)
            {
                var uni_item = new Universty();
                uni_item.Name = item.Name;
                uni_item.Id = item.Id;
                uni.Universties.Add(uni_item);
                Data.DUniversties.Add(uni_item);
            }
        }
    }
}
