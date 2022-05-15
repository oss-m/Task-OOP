using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universties
{
    public class Staff : Operations
    {
        public string SubjectName { get; set; }
        public string DepartmentName { get; set; }
        public List<Subject> Subjectsstaffs { get; set; }
        public Staff()
        {
            Subjectsstaffs = new List<Subject>();
        }
        public void StaffCreatorD(Staff staff, Department dep)
        {
            var uni_op = new Operations().Add(staff.GetType().Name);
            foreach (var item in uni_op)
            {
                var staff_item = new Staff();
                staff_item.Name = item.Name;
                staff_item.Id = item.Id;
                staff_item.DepartmentName = dep.Name;
                dep.Staffs.Add(staff_item);
                Data.DStaffs.Add(staff_item);
            }
        }
        public void StaffCreatorS(Staff staff, Subject sub)
        {
            var uni_op = new Operations().Add(staff.GetType().Name);
            foreach (var item in uni_op)
            {
                var staff_item = new Staff();
                staff_item.Name = item.Name;
                staff_item.Id = item.Id;
                staff_item.SubjectName = sub.Name;
                sub.Staffssubject.Add(staff_item);
                Data.DStaffs.Add(staff_item);
            }
        }
        public void StaffMenu(Staff staff)
        {
            Console.WriteLine("To Add Staff to a Subject Enter S,To Add Staff to a Department Enter D");
            string subject_selector = Console.ReadLine();
            if (subject_selector == "S")
            {
                Console.WriteLine("Please Enter the Subject Id");
                int sub_entry = int.Parse(Console.ReadLine());
                foreach (var item_sub in Data.DSubjects)
                {
                    if (item_sub.Id == sub_entry)
                    {
                        Console.WriteLine("Entering Subjects Names for Staff {0}", item_sub.Name);
                        staff.StaffCreatorS(staff, item_sub);
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
                        staff.StaffCreatorD(staff, item_dep);
                    }
                }
            }
        }
    }
}
