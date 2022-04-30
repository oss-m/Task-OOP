using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universties
{
    public class Universty
    {
        public string UniverstyName { get; set; }
        public List<Colledge> Colledges { get; set; }
        public List<Student> Students { get; set; }
        public Universty()
        {
            Colledges = new List<Colledge>();
            Students = new List<Student>();
        }
    }
}
