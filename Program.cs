using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("R0");
        }
    }

    public abstract class pokemon
    {
        public abstract void ShowHP();

        public abstract void ShowDamage();

        public abstract void ShowDefense();

        public abstract void ShowSPAttack();

        public abstract void ShowSPDefense();

        public abstract void ShowSpeed();
    }
}
