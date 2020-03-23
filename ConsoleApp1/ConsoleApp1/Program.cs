using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Weapon weapon = new Weapon("dsafdasf", 7.4f, 30);
            weapon.Zap();
            weapon.GetInfo();
            Console.ReadLine();
        }
    }
}
