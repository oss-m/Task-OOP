using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universties
{
    public class ManageStaff :Staff, IManageStaff
    {
        public void StaffCreator()
        {
            Console.WriteLine("To Add Staff to a Subject Enter S,To Add Staff to a Department Enter D");
            string subject_selector = Console.ReadLine();
            if (subject_selector == "S")
            {
                Console.WriteLine("Please Enter the Subject Id to add Staff to");
                int sub_entry = int.Parse(Console.ReadLine());
                foreach (var sub in Data.DSubjects)
                {
                    if (sub.Id == sub_entry)
                    {
                        Console.WriteLine("Entering Staff Names for Subject {0}", sub.Name);
                        Console.WriteLine("Please Enter Staff Name or Enter 0 if Finished");
                        string entry = Console.ReadLine();
                        while (entry != "0")
                        {
                            var item = new Staff();
                            item.Name = entry;
                            item.Id = 1;
                            if (Data.DStaffs.Count != 0)
                            {
                                item.Id = Data.DStaffs.Last().Id + 1;
                            }
                            item.SubjectName = sub.Name;
                            sub.Staffs.Add(item);
                            Data.DStaffs.Add(item);
                            Console.WriteLine("Please Enter Next Staff Name or 0 if Finished");
                            entry = Console.ReadLine();
                        }
                        Console.WriteLine("The List Entered is:");
                        for (int i = 0; i < sub.Staffs.Count; i++)
                        {
                            Console.WriteLine("{0}. {1} Staff - ID: {2}", i + 1, sub.Staffs[i].Name, sub.Staffs[i].Id);
                        }
                    }
                }
            }
            if (subject_selector == "D")
            {
                Console.WriteLine("Please Enter the Department Id to add Staff to");
                int dep_entry = int.Parse(Console.ReadLine());
                foreach (var dep in Data.DDepartments)
                {
                    if (dep.Id == dep_entry)
                    {
                        Console.WriteLine("Entering Staff Names for Department {0}", dep.Name);
                        Console.WriteLine("Please Enter Staff Name or Enter 0 if Finished");
                        string entry = Console.ReadLine();
                        while (entry != "0")
                        {
                            var item = new Staff();
                            item.Name = entry;
                            item.Id = 1;
                            if (Data.DStaffs.Count != 0)
                            {
                                item.Id = Data.DStaffs.Last().Id + 1;
                            }
                            item.DepartmentName = dep.Name;
                            dep.Staffs.Add(item);
                            Data.DStaffs.Add(item);
                            Console.WriteLine("Please Enter Next Staff Name or 0 if Finished");
                            entry = Console.ReadLine();
                        }
                        Console.WriteLine("The List Entered is:");
                        for (int i = 0; i < dep.Staffs.Count; i++)
                        {
                            Console.WriteLine("{0}. {1} Staff - ID: {2}", i + 1, dep.Staffs[i].Name, dep.Staffs[i].Id);
                        }
                    }
                }
            }
        }
        public void StaffRet()
        {
            Console.WriteLine("To Retrieve all Staff of a Department Enter A To Retrieve all Staffs for a Subject Enter B for a single Department Enter S");
            string s = Console.ReadLine();
            if (s == "A")
            {
                Console.WriteLine("Please Enter the Department Id to Retrieve it's Staff");
                int s_entry = int.Parse(Console.ReadLine());
                foreach (var dep in Data.DDepartments)
                {
                    if (dep.Id == s_entry)
                    {
                        var temp_list = new List<Staff>();
                        foreach (var item in dep.Staffs)
                        {
                            temp_list.Add(item);
                        }
                        Console.WriteLine("Staff for Department {0} are", dep.Name);
                        for (int i = 0; i < temp_list.Count; i++)
                        {
                            Console.WriteLine("{0}. {1} Staff - ID: {2}", i + 1, temp_list[i].Name, temp_list[i].Id);
                        }
                    }
                }
            }
            if (s == "B")
            {
                Console.WriteLine("Please Enter the Subject Id to Retrieve it's Staff");
                int s_entry = int.Parse(Console.ReadLine());
                foreach (var sub in Data.DSubjects)
                {
                    if (sub.Id == s_entry)
                    {
                        var temp_list = new List<Staff>();
                        foreach (var item in sub.Staffs)
                        {
                            temp_list.Add(item);
                        }
                        Console.WriteLine("Staff for Subject {0} are", sub.Name);
                        for (int i = 0; i < temp_list.Count; i++)
                        {
                            Console.WriteLine("{0}. {1} Staff - ID: {2}", i + 1, temp_list[i].Name, temp_list[i].Id);
                        }
                    }
                }
            }
            if (s == "S")
            {
                Console.WriteLine("Please Enter Staff ID");
                int s2 = int.Parse(Console.ReadLine());
                foreach (var item in Data.DStaffs)
                {
                    if (s2 == item.Id)
                    {
                        if (item.DepartmentName != null)
                        {
                            Console.WriteLine("{0} Staff of Department {1} - ID: {2}", item.Name, item.DepartmentName, item.Id);
                        }
                        else
                        {
                            Console.WriteLine("{0} Staff of Subject {1} - ID: {2}", item.Name, item.SubjectName, item.Id);
                        }
                    }
                }
            }
        }
        public void StaffEdit()
        {
            Console.WriteLine("Please Enter Staff ID to Edit");
            int s = int.Parse(Console.ReadLine());
            int Del = 1000000;
            foreach (var item in Data.DStaffs)
            {
                if (s == item.Id)
                {
                    Console.WriteLine("Please Enter D to Delete or E to Edit Name");
                    string s2 = Console.ReadLine();
                    if (s2 == "D")
                    {
                        Del = Data.DStaffs.IndexOf(item);
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
                Data.DStaffs.RemoveAt(Del);
                Console.WriteLine("Done");
            }
        }
    }
}
