using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Racing.Classes
{
    /*●	Разработать классы автомобилей с конкретной реализацией конструкторов и методов, свойств.
В классы автомобилей добавить необходимые события (например, финиш).*/

    public class SportCar : Car
    {
        public override int Speed { get; set; }
        public int Name { get; set; }
        private Random r = new Random();

        public SportCar()
        {            
            Name = r.Next(1, 10);
            Speed = r.Next(100, 250);           
        }

        public override void Drive()
        {
            Console.WriteLine("Dryn, Dryn, Brrrrrrrrrrrrrrrr");
        }
    }
}
