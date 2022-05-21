using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universties
{
    public class Colledge
    {
        public Classification CollClass { get; set; }
        public double Tot { get; set; }
        public double Suc { get; set; }
        public double Per { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
        public int UniId { get; set; }
        public string UniName { get; set; }
        public List<Department> Departments { get; set; }
        public Colledge()
        {
            Departments = new List<Department>();
        }
        public enum Classification
        {
            Excellent,
            Good,
            Fail
        }
    }
}
