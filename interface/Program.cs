using System;
using System.Collections.Generic;

namespace HelloApp
{
    interface IShooting
    {
        void Shoot();
    }
    interface IMovable
    {
        void Move();
    }
    interface IFlyable
    {
        public void Fly();
    }



    class Tank : IShooting, IMovable, IFlyable
    {
        public void Shoot()
        {
            Console.WriteLine("Выстрелил фугасом из орудия");
        }
        public void Move()
        {
            Console.WriteLine("Проехал по грязи");
        }
        public void Fly()
        {
            Console.WriteLine("Не может летать");
        }
    }

    class Halicopter : IShooting, IMovable, IFlyable
    {
        public void Shoot()
        {
            Console.WriteLine("Дал несколько пулеметных очередей и пустил ракету");
        }
        public void Move()
        {
            Console.WriteLine("Пролетел над посёлком");
        }
        public void Fly()
        {
            Console.WriteLine("Взлетел на 200 метров");
        }
    }

    class Rifle : IShooting, IMovable, IFlyable
    {
        public void Shoot()
        {
            Console.WriteLine("Выстрелила с точным попаданием в уязвимое место");
        }
        public void Move()
        {
            Console.WriteLine("Не может перемещатся");
        }
        public void Fly()
        {
            Console.WriteLine("Не может летать");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Tank tank = new Tank();
            Halicopter halicopter = new Halicopter();
            Rifle rifle = new Rifle();

            List<IShooting> whoDoAction = new List<IShooting>();
            whoDoAction.Add(tank);
            whoDoAction.Add(halicopter);
            whoDoAction.Add(rifle);

            // что-то я в этом не уверен, наверное должно быть что-то проще
            for(int i = 0; i < whoDoAction.Count; i++)
            {
                ((IFlyable)whoDoAction[i])?.Fly();
            }
            for (int i = 0; i < whoDoAction.Count; i++)
            {                
                ((IMovable)whoDoAction[i])?.Move();             
            }
            for (int i = 0; i < whoDoAction.Count; i++)
            {
                ((IShooting)whoDoAction[i])?.Shoot();
            }

            Console.Read();
        }
    }
}