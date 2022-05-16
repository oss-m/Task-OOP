using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universties
{
    public class ManageUniversty : Universty, IManageUniversty
    {
        public void UniCreator()
        {
            Console.WriteLine("Please Enter Universty Name or Enter 0 if Finished");
            string entry = Console.ReadLine();
            while (entry != "0")
            {
                var item = new Universty();
                item.Name = entry;
                item.Id = 1;
                if (Data.DUniversties.Count != 0)
                {
                    item.Id = Data.DUniversties.Last().Id + 1;
                }
                Universties.Add(item);
                Data.DUniversties.Add(item);
                Console.WriteLine("Please Enter Next Universty Name or 0 if Finished");
                entry = Console.ReadLine();
            }
            Console.WriteLine("The List Entered is:");
            for (int i = 0; i < Universties.Count; i++)
            {
                Console.WriteLine("{0}. {1} Universty - ID: {2}", i + 1, Universties[i].Name, Universties[i].Id);
            }
        }
        public void UniRet()
        {
            Console.WriteLine("To Retrieve all Universties Enter A for a single Universty Enter S");
            string u = Console.ReadLine();
            if (u == "A")
            {
                Console.WriteLine("Universties Entered are");
                for (int i = 0; i < Data.DUniversties.Count; i++)
                {
                    Console.WriteLine("{0}. {1} Universty - ID: {2}", i + 1, Data.DUniversties[i].Name, Data.DUniversties[i].Id);
                }
            }
            if (u == "S")
            {
                Console.WriteLine("Please Enter Universty ID");
                int u2 = int.Parse(Console.ReadLine());
                foreach (var item in Data.DUniversties)
                {
                    if (u2 == item.Id)
                    {
                        Console.WriteLine("{0} Universty - ID: {1}", item.Name, item.Id);
                    }
                }
            }
        }
        public void UniEdit()
        {
            Console.WriteLine("Please Enter Universty ID to Edit");
            int u = int.Parse(Console.ReadLine());
            int Del = 1000000;
            foreach (var item in Data.DUniversties)
            {
                if (u == item.Id)
                {
                    Console.WriteLine("Please Enter D to Delete or E to Edit Name");
                    string u2 = Console.ReadLine();
                    if (u2 == "D")
                    {
                        Del = Data.DUniversties.IndexOf(item);
                    }
                    if (u2 == "E")
                    {
                        Console.WriteLine("Please Enter New Name");
                        string u3 = Console.ReadLine();
                        item.Name = u3;
                        Console.WriteLine("Done");
                    }
                }
            }
            if (Del!=1000000)
            {
                Data.DUniversties.RemoveAt(Del);
                Console.WriteLine("Done");
            }
        }
        public void UniPercent()
        {
            Console.WriteLine("Retrieving Universties Students Success Data");
            Console.WriteLine("Please Enter Universty ID");
            int u2 = int.Parse(Console.ReadLine());
            foreach (var item in Data.DUniversties)
            {
                if (u2 == item.Id)
                {
                    if (item.Per < 50) { item.UniClass = Classification.Fail; }
                    if (item.Per >= 50 && item.Per < 75) { item.UniClass = Classification.Good; }
                    if (item.Per >= 75) { item.UniClass = Classification.Excellent; }
                    Console.WriteLine("{0} Universty has {1} Successeded Students out of {2} Students", item.Name, item.Suc, item.Tot);
                    Console.WriteLine("{0} Universty has {1} Failed Students out of {2} Students", item.Name, item.Tot-item.Suc, item.Tot);
                    Console.WriteLine("{0} Universty has Success Percentage of {1}%", item.Name, item.Per);
                    Console.WriteLine("{0} Universty Classification is {1}", item.Name, item.UniClass);
                }
            }
        }
    }
}
