using System;

namespace HelloApp
{
    interface IShooting
    {
        void Shoot(string messege);
    }

    class Tank : IShooting
    {
        public void Shoot(string messege)
        {
            Console.WriteLine(messege);
        }
    }

    class Halicopter : IShooting
    {
        public void Shoot(string messege)
        {
            Console.WriteLine(messege);
        }
    }

    class Rifle : IShooting
    {
        public void Shoot(string messege)
        {
            Console.WriteLine(messege);
        }
    }


    class Program
    {
        static void Action(IShooting shooter, string messege)
        {
            shooter.Shoot(messege);
        }
        static void Main(string[] args)
        {
            Tank tank = new Tank();
            Halicopter halicopter = new Halicopter();
            Rifle rifle = new Rifle();

            Action(tank, "Выстрелил фугасом из орудия");
            Action(halicopter, "Дал несколько пулеметных очередей и пустил ракету");
            Action(rifle, "Выстрелила с точным попаданием в уязвимое место");

            Console.Read();
        }
    }
}