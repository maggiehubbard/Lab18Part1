using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            string o = "Cat";

            LinkedList list = new LinkedList();
            list.AddAtStart("Cat");
            list.AddAtStart("Adam");
            list.AddAtStart("Mohammed");
            list.AddAtStart("Shaun");
            list.AddAtStart("Cat");
            list.AddAtStart("NoCat");

            list.PrintAllNodes();
            Console.WriteLine("------------------------------------------");
            list.RemoveAll(o);
            list.PrintAllNodes();

            Console.ReadKey();

        }

        
    }
}
