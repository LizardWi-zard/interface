using System;

namespace HelloApp
{
    interface IShooting
    {
        void Shoot();
    }

    class Tank : IShooting
    {
        public void Shoot()
        {
            Console.WriteLine("Выстрелил фугасом из орудия");
        }
    }

    class Halicopter : IShooting
    {
        public void Shoot()
        {
            Console.WriteLine("Дал несколько пулеметных очередей и пустил ракету");
        }
    }

    class Rifle : IShooting
    {
        public void Shoot()
        {
            Console.WriteLine("Выстрелила с точным попаданием в уязвимое место");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Tank tank = new Tank();
            Halicopter halicopter = new Halicopter();
            Rifle rifle = new Rifle();

            tank.Shoot();
            halicopter.Shoot();
            rifle.Shoot();

            Console.Read();
        }
    }
}