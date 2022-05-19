using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universties
{
    public class ManageSubject : Subject, IManageSubject
    {
        public void SubCreator()
        {
            Console.WriteLine("To Add Subject to a Staff Enter S,To Add Subject to a Department Enter D");
            string subject_selector = Console.ReadLine();
            if (subject_selector == "S")
            {
                Console.WriteLine("Please Enter the Staff Id to add Subjects to");
                string ent = Console.ReadLine();
                int staff_entry = 1000;
                try
                {
                    staff_entry = int.Parse(ent);
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter valid value");
                }
                foreach (var staff in Data.DStaffs)
                {
                    if (staff.Id == staff_entry)
                    {
                        Console.WriteLine("Entering Subjects Names for Staff {0}", staff.Name);
                        Console.WriteLine("Please Enter Subject Name or Enter 0 if Finished");
                        string entry = Console.ReadLine();
                        while (entry != "0")
                        {
                            var item = new Subject();
                            item.Name = entry;
                            item.Id = 1;
                            if (Data.DSubjects.Count != 0)
                            {
                                item.Id = Data.DSubjects.Last().Id + 1;
                            }
                            item.StaffName = staff.Name;
                            staff.Subjects.Add(item);
                            Data.DSubjects.Add(item);
                            Console.WriteLine("Please Enter Next Subject Name or 0 if Finished");
                            entry = Console.ReadLine();
                        }
                        Console.WriteLine("The List Entered is:");
                        for (int i = 0; i < staff.Subjects.Count; i++)
                        {
                            Console.WriteLine("{0}. {1} Subject - ID: {2}", i + 1, staff.Subjects[i].Name, staff.Subjects[i].Id);
                        }
                    }
                }
            }
            if (subject_selector == "D")
            {
                Console.WriteLine("Please Enter the Department Id to add Subjects to");
                string ent = Console.ReadLine();
                int dep_entry = 1000;
                try
                {
                    dep_entry = int.Parse(ent);
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter valid value");
                }
                foreach (var dep in Data.DDepartments)
                {
                    if (dep.Id == dep_entry)
                    {
                        Console.WriteLine("Entering Subjects Names for Department {0}", dep.Name);
                        Console.WriteLine("Please Enter Subject Name or Enter 0 if Finished");
                        string entry = Console.ReadLine();
                        while (entry != "0")
                        {
                            var item = new Subject();
                            item.Name = entry;
                            item.Id = 1;
                            if (Data.DSubjects.Count != 0)
                            {
                                item.Id = Data.DSubjects.Last().Id + 1;
                            }
                            item.DepartmentName = dep.Name;
                            dep.Subjects.Add(item);
                            Data.DSubjects.Add(item);
                            Console.WriteLine("Please Enter Next Subject Name or 0 if Finished");
                            entry = Console.ReadLine();
                        }
                        Console.WriteLine("The List Entered is:");
                        for (int i = 0; i < dep.Subjects.Count; i++)
                        {
                            Console.WriteLine("{0}. {1} Subject - ID: {2}", i + 1, dep.Subjects[i].Name, dep.Subjects[i].Id);
                        }
                    }
                }
            }
        }
        public void SubRet()
        {
            Console.WriteLine("To Retrieve all Subjects of a Department Enter A To Retrieve all Subjects for a Staff Enter B for a single Department Enter S");
            string s = Console.ReadLine();
            if (s == "A")
            {
                Console.WriteLine("Please Enter the Department Id to Retrieve it's Subjects");
                int s_entry = int.Parse(Console.ReadLine());
                foreach (var dep in Data.DDepartments)
                {
                    if (dep.Id == s_entry)
                    {
                        var temp_list = new List<Subject>();
                        foreach (var item in dep.Subjects)
                        {
                            temp_list.Add(item);
                        }
                        Console.WriteLine("Subjects for Department {0} are", dep.Name);
                        for (int i = 0; i < temp_list.Count; i++)
                        {
                            Console.WriteLine("{0}. {1} Subject - ID: {2}", i + 1, temp_list[i].Name, temp_list[i].Id);
                        }
                    }
                }
            }
            if (s == "B")
            {
                Console.WriteLine("Please Enter the Staff Id to Retrieve it's Subjects");
                int s_entry = int.Parse(Console.ReadLine());
                foreach (var staff in Data.DStaffs)
                {
                    if (staff.Id == s_entry)
                    {
                        var temp_list = new List<Subject>();
                        foreach (var item in staff.Subjects)
                        {
                            temp_list.Add(item);
                        }
                        Console.WriteLine("Subjects for Staff {0} are", staff.Name);
                        for (int i = 0; i < temp_list.Count; i++)
                        {
                            Console.WriteLine("{0}. {1} Subject - ID: {2}", i + 1, temp_list[i].Name, temp_list[i].Id);
                        }
                    }
                }
            }
            if (s == "S")
            {
                Console.WriteLine("Please Enter Subjects ID");
                int s2 = int.Parse(Console.ReadLine());
                foreach (var item in Data.DSubjects)
                {
                    if (s2 == item.Id)
                    {
                        if (item.DepartmentName!=null)
                        {
                            Console.WriteLine("{0} Subject of Department {1} - ID: {2}", item.Name, item.DepartmentName, item.Id);
                        }
                        else
                        {
                            Console.WriteLine("{0} Subject of Staff {1} - ID: {2}", item.Name, item.StaffName, item.Id);
                        }
                    }
                }
            }
        }
        public void SubEdit()
        {
            Console.WriteLine("Please Enter Subject ID to Edit");
            int s = int.Parse(Console.ReadLine());
            int Del = 1000000;
            foreach (var item in Data.DSubjects)
            {
                if (s == item.Id)
                {
                    Console.WriteLine("Please Enter D to Delete or E to Edit Name");
                    string s2 = Console.ReadLine();
                    if (s2 == "D")
                    {
                        Del = Data.DSubjects.IndexOf(item);
                    }
                    if (s2 == "E")
                    {
                        Console.WriteLine("Please Enter New Name");
                        string d3 = Console.ReadLine();
                        item.Name = d3;
                        Console.WriteLine("Done");
                    }
                }
            }
            if (Del != 1000000)
            {
                Data.DSubjects.RemoveAt(Del);
                Console.WriteLine("Done");
            }
        }
    }
}
