using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universties
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("         Welcome to Universties Application");
            Console.WriteLine("Please Enter Universty Name or Done if Finished");
            List<Universty> universties = new List<Universty>();
            string uni_input = Console.ReadLine();
            while (uni_input != "Done")
            {
                var uni = new Universty();
                uni.UniverstyName = uni_input;
                universties.Add(uni);
                Console.WriteLine("Please Enter Next Universty Name or Done if Finished");
                uni_input = Console.ReadLine();
            }
            Console.WriteLine("The List of Universties are:");
            for (int i = 0; i < universties.Count; i++)
            {
                Console.WriteLine("{0}. {1}",i+1,universties[i].UniverstyName);
            }


        }
    }
}
