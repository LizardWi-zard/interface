using System;
using System.Collections.Generic;

namespace Interface
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



    class Tank : IShooting, IMovable
    {
        public void Shoot()
        {
            Console.WriteLine("Выстрелил фугасом из орудия");
        }
        public void Move()
        {
            Console.WriteLine("Проехал по грязи");
        }
    }

    class Halicopter : IShooting, IMovable, IFlyable
    {
        public virtual void Shoot() { }
        
        public void Move()
        {
            Console.WriteLine("Пролетел над посёлком");
        }
        public void Fly()
        {
            Console.WriteLine("Взлетел на 200 метров");
        }
    }

    class Rifle : IShooting
    {
        public void Shoot()
        {
            Console.WriteLine("Выстрелила с точным попаданием в уязвимое место");
        }
    }

    class Mi28 : Halicopter
    {
        public override void Shoot()
        {
            Console.WriteLine("Выстрелил ракетой");
        }
    }

    class KA50 : Halicopter
    {
        public override void Shoot()
        {
            Console.WriteLine("Выстрелил из пулемёта");
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            Tank tank = new Tank();
            Halicopter halicopter = new Halicopter();
            Rifle rifle = new Rifle();
            Mi28 mi28 = new Mi28();
            KA50 ka50 = new KA50();

            List<IShooting> whoDoAction = new List<IShooting>();
            whoDoAction.Add(tank);
            whoDoAction.Add(halicopter);
            whoDoAction.Add(rifle);
            whoDoAction.Add(mi28);
            whoDoAction.Add(ka50);

            for (int i = 0; i < whoDoAction.Count; i++)
            {
                if((whoDoAction[i] as IFlyable) != null)
                   (whoDoAction[i] as IFlyable).Fly();
            }
            Console.WriteLine(" ");

            for (int i = 0; i < whoDoAction.Count; i++)
            {
                if ((whoDoAction[i] as IMovable) != null)
                    (whoDoAction[i] as IMovable).Move();             
            }
            Console.WriteLine(" ");

            for (int i = 0; i < whoDoAction.Count; i++)
            {
                ((IShooting)whoDoAction[i]).Shoot();
            }

            Console.Read();
        }
    }
}