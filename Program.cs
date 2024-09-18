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
            Console.WriteLine("R1");
            Console.WriteLine("---Sandshrew---");
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

    public class Sandshrew : pokemon
    {
        double HP = 50;
        double Attack = 75;
        double Defense = 85;
        double SAttack = 20;
        double SDefense = 30;
        double Speed = 40;
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
    }
}
