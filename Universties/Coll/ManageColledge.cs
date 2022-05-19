using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universties
{
    public class ManageColledge : Colledge, IManageColledge
    {
        public void CollCreator()
        {
            Console.WriteLine("Please Enter the University Id to add Colledges to");
            string ent = Console.ReadLine();
            int u_entry = 1000;
            try
            {
                u_entry = int.Parse(ent);
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter valid value");
            }
            foreach (var uni in Data.DUniversties)
            {
                if (uni.Id == u_entry)
                {
                    Console.WriteLine("Entering Colledges Names for University {0}", uni.Name);
                    Console.WriteLine("Please Enter Colledge Name or Enter 0 if Finished");
                    string entry = Console.ReadLine();
                    while (entry != "0")
                    {
                        var item = new Colledge();
                        item.Name = entry;
                        item.Id = 1;
                        if (Data.DColledges.Count != 0)
                        {
                            item.Id = Data.DColledges.Last().Id + 1;
                        }
                        item.UniName = uni.Name;
                        uni.Colledges.Add(item);
                        Data.DColledges.Add(item);
                        Console.WriteLine("Please Enter Next Colledge Name or 0 if Finished");
                        entry = Console.ReadLine();
                    }
                    Console.WriteLine("The List Entered is:");
                    for (int i = 0; i < uni.Colledges.Count; i++)
                    {
                        Console.WriteLine("{0}. {1} Colledge - ID: {2}", i + 1, uni.Colledges[i].Name, uni.Colledges[i].Id);
                    }
                }
            }
        }
        public void CollRet()
        {
            Console.WriteLine("To Retrieve all Colledges of a Universty Enter A for a single Colledge Enter S");
            string c = Console.ReadLine();
            if (c == "A")
            {
                Console.WriteLine("Please Enter the University Id to Retrieve it's Colledges");
                int c_entry = int.Parse(Console.ReadLine());
                foreach (var uni in Data.DUniversties)
                {
                    if (uni.Id == c_entry)
                    {
                        var temp_list = new List<Colledge>();
                        foreach (var item in uni.Colledges)
                        {
                            temp_list.Add(item);
                        }
                        Console.WriteLine("Colledges for Universty {0} are", uni.Name);
                        for (int i = 0; i < temp_list.Count; i++)
                        {
                            Console.WriteLine("{0}. {1} Colledge - ID: {2}", i + 1, temp_list[i].Name, temp_list[i].Id);
                        }
                    }
                }
            }
            if (c == "S")
            {
                Console.WriteLine("Please Enter Colledge ID");
                int c2 = int.Parse(Console.ReadLine());
                foreach (var item in Data.DColledges)
                {
                    if (c2 == item.Id)
                    {
                        Console.WriteLine("{0} Colledge of Universty {1} - ID: {2}", item.Name, item.UniName, item.Id);
                    }
                }
            }
        }
        public void CollEdit()
        {
            Console.WriteLine("Please Enter Colledge ID to Edit");
            int c = int.Parse(Console.ReadLine());
            int Del = 1000000;
            foreach (var item in Data.DColledges)
            {
                if (c == item.Id)
                {
                    Console.WriteLine("Please Enter D to Delete or E to Edit Name");
                    string c2 = Console.ReadLine();
                    if (c2 == "D")
                    {
                        Del = Data.DColledges.IndexOf(item);
                    }
                    if (c2 == "E")
                    {
                        Console.WriteLine("Please Enter New Name");
                        string c3 = Console.ReadLine();
                        item.Name = c3;
                        Console.WriteLine("Done");
                    }
                }
            }
            if (Del != 1000000)
            {
                Data.DColledges.RemoveAt(Del);
                Console.WriteLine("Done");
            }
        }
        public void CollPercent()
        {
            Console.WriteLine("Retrieving Colledges Students Success Data");
            Console.WriteLine("Please Enter Colledge ID");
            int c2 = int.Parse(Console.ReadLine());
            foreach (var item in Data.DColledges)
            {
                if (c2 == item.Id)
                {
                    if (item.Per < 50) { item.CollClass = Classification.Fail; }
                    if (item.Per >= 50 && item.Per < 75) { item.CollClass = Classification.Good; }
                    if (item.Per >= 75) { item.CollClass = Classification.Excellent; }
                    Console.WriteLine("{0} Colledge has {1} Successeded Students out of {2} Students", item.Name, item.Suc, item.Tot);
                    Console.WriteLine("{0} Colledge has {1} Failed Students out of {2} Students", item.Name, item.Tot - item.Suc, item.Tot);
                    Console.WriteLine("{0} Colledge has Success Percentage of {1}%", item.Name, item.Per);
                    Console.WriteLine("{0} Colledge Classification is {1}", item.Name, item.CollClass);
                }
            }
        }
    }
}
