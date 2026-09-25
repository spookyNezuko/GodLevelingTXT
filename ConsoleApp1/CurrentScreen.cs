using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class InitialNameSelection
    {
        //chiedo il nome poi lo ritorno
         static internal string Render() {
            Console.WriteLine("Input your name: ");
            string name = Console.ReadLine();
            WelcomePlayer(name);
            return name;
        }

        static private void WelcomePlayer(string name)
        {
            Console.WriteLine($"welcome to God Leveling {name}");
        }
    }

    
}
