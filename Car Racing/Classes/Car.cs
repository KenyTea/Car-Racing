using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Racing.Classes
{
    /*●	Разработать абстрактный класс «автомобиль» (класс Car). 
Собрать в нем все общие поля, свойства (например, скорость) методы (например, ехать). */

    public abstract class Car
    {
        public abstract float Speed { get; set; }

        public abstract void Drive();
    }
}
