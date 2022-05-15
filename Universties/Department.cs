using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universties
{
    public class Department : Operations
    {
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
        public void DepCreator(Department dep, Colledge coll)
        {
            var uni_op = new Operations().Add(dep.GetType().Name);
            foreach (var item in uni_op)
            {
                var dep_item = new Department();
                dep_item.Name = item.Name;
                dep_item.Id = item.Id;
                dep_item.CollName = coll.Name;
                coll.Departments.Add(dep_item);
                Data.DDepartments.Add(dep_item);
            }
        }
        public void DepMenu(Department dep)
        {
            Console.WriteLine("Please Enter the Colledge Id");
            int c_entry = int.Parse(Console.ReadLine());
            foreach (var item_coll in Data.DColledges)
            {
                if (item_coll.Id == c_entry)
                {
                    Console.WriteLine("Entering Departments Names for Colledge {0}", item_coll.Name);
                    dep.DepCreator(dep, item_coll);
                }
            }
        }
    }
}
