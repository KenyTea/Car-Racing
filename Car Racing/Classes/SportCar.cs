using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Car_Racing.Classes
{
    /*●	Разработать классы автомобилей с конкретной реализацией конструкторов и методов, свойств.
В классы автомобилей добавить необходимые события (например, финиш).*/


    public class SportCar : Car
    {
        private static Random r = new Random();

        public SportCar()
        {
            Name = r.Next(1, 10);

        }

        public override event Ready Ready;
        public override event Finish Finish;
        public override event Driving Driving;

        public override void GetReady()
        {
            Distanse = 0;
            Thread.Sleep(2000);
            if (Ready != null)
                Ready(this);
        }

        public override void Drive(float limit)
        {
            Speed = r.Next(50, 150);
            Distanse += Speed*1000/36000;
            if (Driving != null)
            {
                Driving(this, Distanse);
            }
            if (Distanse >= limit)
            {
                if (Finish != null)
                {
                    Finish(this);
                }
            }
        }

        public void Reset()
        {
            Speed = 0;
            Distanse = 0;
        }
    }
}
