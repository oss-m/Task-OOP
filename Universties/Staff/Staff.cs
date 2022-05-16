using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universties
{
    public class Staff
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string SubjectName { get; set; }
        public string DepartmentName { get; set; }
        public List<Subject> Subjects { get; set; }
        public Staff()
        {
            Subjects = new List<Subject>();
        }
    }
}
