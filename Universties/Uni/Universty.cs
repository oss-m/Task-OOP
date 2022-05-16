using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universties
{
    public class Universty
    {
        public Classification UniClass { get; set; }
        public double Tot { get; set; }
        public double Suc { get; set; }
        public double Per { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
        public List<Universty> Universties { get; set; }
        public List<Colledge> Colledges { get; set; }
        public Universty()
        {
            Universties = new List<Universty>();
            Colledges = new List<Colledge>();
        }
        public enum Classification
        {
            Excellent,
            Good,
            Fail
        }

    }
}
