using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Car_Racing.Classes
{
    /*●	Класс игры должен производить запуск соревнований автомобилей, 
выводить сообщения о текущем положении автомобилей, 
выводить сообщение об автомобиле, победившем в гонках.*/

    public class Game
    {
        int mile = 0;
        int trassa = 1000;

        public void ReadyToStart(SportCar sp, SportCar sp2)
        {
            Console.WriteLine("The car " + sp.Name + "Is ready");
            Thread.Sleep(3000);
            Console.WriteLine("The car " + sp2.Name + "Is ready");
            Thread.Sleep(3000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
           Console.WriteLine("Get redy");
            Thread.Sleep(2000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Set");
            Thread.Sleep(1000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("GO!!!");
            Thread.Sleep(800);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            sp.Drive();
            sp2.Drive();
            Thread.Sleep(1500);
        }

        public void MileInfo(SportCar sp, SportCar sp2)
        {
            while (mile <= 1000)
            {
                Console.WriteLine( "Te car " + sp.Name + " ");
            }
        }

    }
}
