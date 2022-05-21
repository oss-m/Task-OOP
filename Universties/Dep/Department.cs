using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universties
{
    public class Department
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int CollId { get; set; }
        public string CollName { get; set; }
        public List<Staff> Staffs { get; set; }
        public List<Subject> Subjects { get; set; }
        public List<Student> Students { get; set; }
        public Department()
        {
            Subjects = new List<Subject>();
            Students = new List<Student>();
            Staffs = new List<Staff>();
        }
    }
}
