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
            Console.WriteLine("R10");
            Console.WriteLine("---Tropius---");
            Tropius tp = new Tropius();
            tp.ShowHP();
            tp.ShowDamage();
            tp.ShowDefense();
            tp.ShowSPAttack();
            tp.ShowSPDefense();
            tp.ShowSpeed();
            Console.WriteLine("");
            tp.Snarl();
            Console.WriteLine("");
            tp.PlayRough();
            Console.WriteLine("");
            tp.Tackle();
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

    public class Tropius : pokemon
    {
        double HP = 99;
        double Attack = 68;
        double Defense = 83;
        double SAttack = 72;
        double SDefense = 87;
        double Speed = 51;
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

        public void Snarl()
        {
            Console.WriteLine("Using Snarl!!!");
        }
        public void PlayRough()
        {
            Console.WriteLine("Using Play Rough!!!");
        }
        public void Tackle()
        {
            Console.WriteLine("Using Tackle!!!");
        }
    }
}
