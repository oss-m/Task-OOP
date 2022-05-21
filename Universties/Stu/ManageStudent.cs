using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universties
{
    public class ManageStudent : Student, IManageStudent
    {
        public void StuCreator()
        {
            Console.WriteLine("Please Enter the Department Id");
            string ent = Console.ReadLine();
            int d_entry = 1000;
            try
            {
                d_entry = int.Parse(ent);
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter valid value");
            }
            foreach (var dep in Data.DDepartments)
            {
                if (dep.Id == d_entry)
                {
                    Console.WriteLine("Entering Students Names for Department {0}", dep.Name);
                    Console.WriteLine("Please Enter Student Name or Enter 0 if Finished");
                    string entry = Console.ReadLine();
                    while (entry != "0")
                    {
                        var item = new Student();
                        item.Name = entry;
                        item.DepartmentName = dep.Name;
                        item.DepId = dep.Id;
                        item.Id = 1;
                        if (Data.DStudents.Count != 0)
                        {
                            item.Id = Data.DStudents.Last().Id + 1;
                        }
                        Console.WriteLine("Please Enter Student {0} Grade", item.Name);
                        string g = Console.ReadLine();
                        try
                        {
                            item.Grade = double.Parse(g);
                            dep.Students.Add(item);
                        }
                        catch (Exception)
                        {
                            item.Grade = 0;
                            dep.Students.Add(item);
                        }
                        Data.DStudents.Add(item);
                        Console.WriteLine("Please Enter Next Student Name or 0 if Finished");
                        entry = Console.ReadLine();
                    }
                    Console.WriteLine("The List Entered is:");
                    for (int i = 0; i < dep.Students.Count; i++)
                    {
                        Console.WriteLine("{0}. {1}, Grade is {2} - ID: {3}", i + 1, dep.Students[i].Name, dep.Students[i].Grade, dep.Students[i].Id);
                    }
                }
            }
        }
        public void StuRet()
        {
            Console.WriteLine("To Retrieve all Students of a Department Enter A for a single Student Enter S");
            string s = Console.ReadLine();
            if (s == "A")
            {
                Console.WriteLine("Please Enter the Department Id to Retrieve it's Students");
                int s_entry = int.Parse(Console.ReadLine());
                foreach (var dep in Data.DDepartments)
                {
                    if (dep.Id == s_entry)
                    {
                        var temp_list = new List<Student>();
                        foreach (var item in dep.Students)
                        {
                            temp_list.Add(item);
                        }
                        Console.WriteLine("Students for Department {0} are", dep.Name);
                        for (int i = 0; i < temp_list.Count; i++)
                        {
                            Console.WriteLine("{0}. {1} - Grade:{2} - ID: {3}", i + 1, temp_list[i].Name, temp_list[i].Grade, temp_list[i].Id);
                        }
                    }
                }
            }
            if (s == "S")
            {
                Console.WriteLine("Please Enter Student ID");
                int s2 = int.Parse(Console.ReadLine());
                foreach (var item in Data.DStudents)
                {
                    if (s2 == item.Id)
                    {
                        Console.WriteLine("{0} of Department {1} - Grade{2} - ID: {3}", item.Name, item.DepartmentName, item.Grade, item.Id);
                    }
                }
            }
        }
        public void StuEdit()
        {
            Console.WriteLine("Please Enter Student ID to Edit");
            int s = int.Parse(Console.ReadLine());
            int Del = 1000000;
            foreach (var item in Data.DStudents)
            {
                if (s == item.Id)
                {
                    Console.WriteLine("Please Enter D to Delete or E to Edit Name or G to Edit Grade");
                    string s2 = Console.ReadLine();
                    if (s2 == "D")
                    {
                        Del = Data.DStudents.IndexOf(item);
                    }
                    if (s2 == "E")
                    {
                        Console.WriteLine("Please Enter New Name");
                        string d3 = Console.ReadLine();
                        item.Name = d3;
                        Console.WriteLine("Done");
                    }
                    if (s2 == "G")
                    {
                        Console.WriteLine("Please Enter New Grade");
                        double d4 = double.Parse(Console.ReadLine());
                        item.Grade = d4;
                        Console.WriteLine("Done");
                    }
                }
            }
            if (Del!= 1000000)
            {
                Data.DStudents.RemoveAt(Del);
                Console.WriteLine("Done");
            }
        }
    }
}
