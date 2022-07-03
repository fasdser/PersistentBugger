using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistentBugger
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
           Persist persist = new Persist();
            persist.Equals(Persist.Persistence(39));
            Console.WriteLine($"{Persist.Persistence(999)}");
            Console.ReadLine();

        }
    }
}
