using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Racing.Classes
{
    /*●	Разработать абстрактный класс «автомобиль» (класс Car). 
Собрать в нем все общие поля, свойства (например, скорость) методы (например, ехать). */
    public delegate void Driving(Car car, float deistance);
    public delegate void Finish(Car car);
    public delegate void Ready(Car car);

    public abstract class Car
    {
        public int Name { get; set; }
        public float Speed { get; set; }
        public float Distanse { get; set; }

        public abstract void Drive(float limit);

        public abstract void GetReady();

        public abstract event Ready Ready;
        public abstract event Finish Finish;
        public abstract event Driving Driving;

    }
}
