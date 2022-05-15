using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universties
{
    public class Student : Operations
    {
        public string DepartmentName { get; set; }
        public void StuCreator(Student stu, Department dep)
        {
            var uni_op = new Operations().Add(stu.GetType().Name);
            foreach (var item in uni_op)
            {
                var stu_item = new Student();
                stu_item.Name = item.Name;
                stu_item.Grade = item.Grade;
                stu_item.Id = item.Id;
                stu_item.DepartmentName = dep.Name;
                dep.Students.Add(stu_item);
                Data.DStudents.Add(stu_item);
            }
        }
        public void StuMenu(Student stu)
        {
            Console.WriteLine("Please Enter the Department Id");
            int d_entry = int.Parse(Console.ReadLine());
            foreach (var item_dep in Data.DDepartments)
            {
                if (item_dep.Id == d_entry)
                {
                    Console.WriteLine("Entering Students Names for Department {0}", item_dep.Name);
                    stu.StuCreator(stu, item_dep);
                }
            }
        }
    }
}
