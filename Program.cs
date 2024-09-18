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
            Console.WriteLine("R6");
            Console.WriteLine("---Sandslash---");
            Sandslash sl = new Sandslash();
            sl.ShowHP();
            sl.ShowDamage();
            sl.ShowDefense();
            sl.ShowSPAttack();
            sl.ShowSPDefense();
            sl.ShowSpeed();
            Console.WriteLine("");
            sl.FocusEnergy();
            Console.WriteLine("");
            sl.QuickAttack();
            Console.WriteLine("");
            sl.Facade();
            Console.WriteLine("");
            sl.Roost();
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

    public class Sandslash : pokemon
    {
        double HP = 75;
        double Attack = 100;
        double Defense = 110;
        double SAttack = 45;
        double SDefense = 55;
        double Speed = 65;
        public override void ShowHP()
        {
            Console.WriteLine("Здоровье = " + HP);
        }
        public override void ShowDamage()
        {
            Console.WriteLine("Атака = " + Attack);
        }
        public override void ShowDefense()
        {
            Console.WriteLine("Защита = " + Defense);
        }
        public override void ShowSPAttack()
        {
            Console.WriteLine("Спец. атака = " + SAttack);
        }
        public override void ShowSPDefense()
        {
            Console.WriteLine("Спец. защита = " + SDefense);
        }
        public override void ShowSpeed()
        {
            Console.WriteLine("Скорость = " + Speed);
        }

        public void FocusEnergy()
        {
            Console.WriteLine("Using Focus Energy!!!");
        }
        public void QuickAttack()
        {
            Console.WriteLine("Using Quick Attack!!!");
        }
        public void Facade()
        {
            Console.WriteLine("Using Facade!!!");
        }
        public void Roost()
        {
            Console.WriteLine("Using Roost!!!");
        }
    }
}
