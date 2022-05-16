using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universties
{
    public class ManageDepartment:Department, IManageDepartment
    {
        public void DepCreator()
        {
            Console.WriteLine("Please Enter the Colledge Id to add Departments to");
            int c_entry = int.Parse(Console.ReadLine());
            foreach (var coll in Data.DColledges)
            {
                if (coll.Id == c_entry)
                {
                    Console.WriteLine("Entering Departments Names for Colledge {0}", coll.Name);
                    Console.WriteLine("Please Enter Department Name or Enter 0 if Finished");
                    string entry = Console.ReadLine();
                    while (entry != "0")
                    {
                        var item = new Department();
                        item.Name = entry;
                        item.Id = 1;
                        if (Data.DDepartments.Count != 0)
                        {
                            item.Id = Data.DDepartments.Last().Id + 1;
                        }
                        item.CollName = coll.Name;
                        coll.Departments.Add(item);
                        Data.DDepartments.Add(item);
                        Console.WriteLine("Please Enter Next Department Name or 0 if Finished");
                        entry = Console.ReadLine();
                    }
                    Console.WriteLine("The List Entered is:");
                    for (int i = 0; i < coll.Departments.Count; i++)
                    {
                        Console.WriteLine("{0}. {1} Department - ID: {2}", i + 1, coll.Departments[i].Name, coll.Departments[i].Id);
                    }
                }
            }
        }
        public void DepRet()
        {
            Console.WriteLine("To Retrieve all Departments of a Colledge Enter A for a single Department Enter S");
            string d = Console.ReadLine();
            if (d == "A")
            {
                Console.WriteLine("Please Enter the Colledge Id to Retrieve it's Departments");
                int d_entry = int.Parse(Console.ReadLine());
                foreach (var coll in Data.DColledges)
                {
                    if (coll.Id == d_entry)
                    {
                        var temp_list = new List<Department>();
                        foreach (var item in coll.Departments)
                        {
                            temp_list.Add(item);
                        }
                        Console.WriteLine("Departments for Colledge {0} are", coll.Name);
                        for (int i = 0; i < temp_list.Count; i++)
                        {
                            Console.WriteLine("{0}. {1} Department - ID: {2}", i + 1, temp_list[i].Name, temp_list[i].Id);
                        }
                    }
                }
            }
            if (d == "S")
            {
                Console.WriteLine("Please Enter Department ID");
                int d2 = int.Parse(Console.ReadLine());
                foreach (var item in Data.DDepartments)
                {
                    if (d2 == item.Id)
                    {
                        Console.WriteLine("{0} Department of Colledge {1} - ID: {2}", item.Name, item.CollName, item.Id);
                    }
                }
            }
        }
        public void DepEdit()
        {
            Console.WriteLine("Please Enter Department ID to Edit");
            int d = int.Parse(Console.ReadLine());
            int Del = 1000000;
            foreach (var item in Data.DDepartments)
            {
                if (d == item.Id)
                {
                    Console.WriteLine("Please Enter D to Delete or E to Edit Name");
                    string d2 = Console.ReadLine();
                    if (d2 == "D")
                    {
                        Del = Data.DDepartments.IndexOf(item);
                    }
                    if (d2 == "E")
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
                Data.DDepartments.RemoveAt(Del);
                Console.WriteLine("Done");
            }
        }
    }
}
