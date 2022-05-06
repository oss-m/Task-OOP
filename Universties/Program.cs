using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universties
{
    class Program
    {
        static void Main()
        {
//Creating Objects of each class
            var uni = new Universty();
            var coll = new Colledge();
            var dep = new Department();
            var subj = new Subject();
//Creating Universties
            uni.Add();
            uni.Edit();
            foreach (var item_uni in uni.Universties)
            {
//Creating Colledges
                Console.WriteLine("Entering Colledges Names for University {0}", item_uni.Name);
                coll.Add(item_uni.Name);
                coll.Edit();
                foreach (var item_coll in coll.Colledges)
                {
//Creating Departments
                    Console.WriteLine("Entering Departments Names for Colledge {0}", item_coll.Name);
                    dep.Add(item_coll.Name);
                    dep.Edit();
//Creating Subjects
                    Console.WriteLine("Entering Subjects Names for Colledge {0}", item_coll.Name);
                    subj.Add(item_coll.Name);
                    subj.Edit();
                }
            }

//Retrieving Univerties
            foreach (var item_Uni in uni.Universties)
            {
                Console.WriteLine(item_Uni.Name);
            }
//Retrieving Colledges
            foreach (var item_Uni in uni.Universties)
            {
                foreach (var item_Coll in coll.Colledges)
                {
                    Console.WriteLine(item_Coll.Name);
                }
            }
//Retrieving Departments
            foreach (var item_Uni in uni.Universties)
            {
                foreach (var item_Coll in coll.Colledges)
                {
                    foreach (var item_Dep in dep.Departments)
                    {
                        Console.WriteLine(item_Dep.Name);
                    }
                }
            }
//Retrieving Subjects
            foreach (var item_Uni in uni.Universties)
            {
                foreach (var item_Coll in coll.Colledges)
                {
                    foreach (var item_Subj in subj.Subjects)
                    {
                        Console.WriteLine(item_Subj.Name);
                    }
                }
            }
        }
    }
}
