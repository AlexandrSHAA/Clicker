using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonVirtualOverride
{
    interface IWeapon 
    {
        int Damage { get; }
        void ShowInfo();        
        void Fire();
    }

    interface IThrowWeapon : IWeapon
    {
        void Throw();
    }


    class Knife : IThrowWeapon
    {
        public int Damage => 5;

        public void Fire()
        {
            ShowInfo();
            Console.WriteLine("...");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"{GetType().Name} Damage:{Damage}");
        }

        public void Throw()
        {
            ShowInfo();
            Console.WriteLine("Вшух");
        }
    }

    class Gun : Weapon
    {
        public override int Damage { get { return 5; } }
        public override void Fire()
        {
            ShowInfo();
            Console.WriteLine("Пуф");
        }
    }

    class MiniGun : Weapon
    {
        public override int Damage { get { return 15; } }
        public override void Fire()
        {
            ShowInfo();
            Console.WriteLine("Ра-та-та-та-т-т-т-т");
        }
    }

    class Bow : Weapon
    {
        public override int Damage =>3;
        public override void Fire()
        {
            ShowInfo();
            Console.WriteLine("Птюнь");
        }
    }
    abstract class Weapon : IWeapon
    {
        public abstract int Damage { get; }
        public abstract void Fire();
        public  void ShowInfo()
        {
            Console.WriteLine($"{GetType().Name} Damage:{Damage}");
        }

    }

    class Player
    {

    
        public void Fire(IWeapon weapon)
        {
            weapon.Fire();
        }

        public void ShowInfo(IWeapon weapon)
        {
            weapon.ShowInfo();
        }

        public void Throw(IThrowWeapon throwWeapon)
        {
            throwWeapon.Throw();
        }
    }



    class Game
    {
        static void Main(string[] args)
        {
            IWeapon[] inveтtar = { new Bow(), new Gun(), new MiniGun(), new Knife() };

            Player player = new Player();

            foreach (var item in inveтtar)
            {
                player.Fire(item);
                Console.WriteLine();               
            }
            player.Throw(new Knife());
        }

    }
}

