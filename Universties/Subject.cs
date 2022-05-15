using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universties
{
    public class Subject : Operations
    {
        public string DepartmentName { get; set; }
        public string StaffName { get; set; }
        public List<Staff> Staffssubject { get; set; }
        public Subject()
        {
            Staffssubject = new List<Staff>();
        }
        public void SubCreatorD(Subject sub, Department dep)
        {
            var uni_op = new Operations().Add(sub.GetType().Name);
            foreach (var item in uni_op)
            {
                var sub_item = new Subject();
                sub_item.Name = item.Name;
                sub_item.DepartmentName = dep.Name;
                sub_item.Id = item.Id;
                dep.Subjects.Add(sub_item);
                Data.DSubjects.Add(sub_item);
            }
        }
        public void SubCreatorS(Subject sub, Staff staff)
        {
            var uni_op = new Operations().Add(sub.GetType().Name);
            foreach (var item in uni_op)
            {
                var sub_item = new Subject();
                sub_item.Name = item.Name;
                sub_item.Id = item.Id;
                sub_item.StaffName = staff.Name;
                staff.Subjectsstaffs.Add(sub_item);
                Data.DSubjects.Add(sub_item);
            }
        }
        public void SubMenu(Subject sub)
        {
            Console.WriteLine("To Add Subject to a Staff Enter S,To Add Subject to a Department Enter D");
            string subject_selector = Console.ReadLine();
            if (subject_selector == "S")
            {
                Console.WriteLine("Please Enter the Subject Id");
                int staff_entry = int.Parse(Console.ReadLine());
                foreach (var item_staff in Data.DStaffs)
                {
                    if (item_staff.Id == staff_entry)
                    {
                        Console.WriteLine("Entering Subjects Names for Staff {0}", item_staff.Name);
                        sub.SubCreatorS(sub, item_staff);
                    }
                }
            }
            if (subject_selector == "D")
            {
                Console.WriteLine("Please Enter the Department Id");
                int dep_entry = int.Parse(Console.ReadLine());
                foreach (var item_dep in Data.DDepartments)
                {
                    if (item_dep.Id == dep_entry)
                    {
                        Console.WriteLine("Entering Subjects Names for Department {0}", item_dep.Name);
                        sub.SubCreatorD(sub, item_dep);
                    }
                }
            }
        }
    }
}
