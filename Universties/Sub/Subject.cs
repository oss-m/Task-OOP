using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universties
{
    public class Subject
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public string StaffName { get; set; }
        public List<Staff> Staffs { get; set; }
        public Subject()
        {
            Staffs = new List<Staff>();
        }
    }
}
