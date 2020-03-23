using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Weapon
    {

        private string name;
        private float caliber;
        private double distance;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public float Caliber
        {
            get
            {
                return caliber;
            }
            set
            {
                caliber = value;
            }
        }
        public double Distance
        {
            get
            {
                return distance;
            }
            set
            {
                distance = value;
            }
        }

        public void Zap()
        {
            Weapon weapon = new Weapon("dsafdasf", 7.4f, 30);
            weapon.name = "Desert Eagle";
            weapon.caliber = 7.3f;
            weapon.distance = 100;
        }
        public void GetInfo()
        {
            Weapon weapon = new Weapon("dsafdasf", 7.4f, 30);
            Console.WriteLine("{0} {1} {2}", weapon.name, weapon.caliber, weapon.distance);
        }

        public Weapon(string name, float caliber, double distance)
        {
            this.name = name;
            this.caliber = caliber;
            this.distance = distance;
        }
    }
}
