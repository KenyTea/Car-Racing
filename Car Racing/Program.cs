﻿using Car_Racing.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Racing
{
    /*Тема: Делегаты, события.

1.	Игра «Автомобильные гонки»
Разработать игру "Автомобильные гонки" с использованием делегатов.
●	В игре использовать несколько типов автомобилей: 
спортивные, 
легковые, 
грузовые 
и автобусы.
●	Реализовать игру «Гонки».
Принцип игры:
Автомобили двигаются от старта к финишу со скоростями, которые изменяются в установленных пределах случайным образом.
Победителем считается автомобиль, пришедший к финишу первым.
Рекомендации по выполнению работы
●	Разработать абстрактный класс «автомобиль» (класс Car). 
Собрать в нем все общие поля, свойства (например, скорость) методы (например, ехать).  
●	Разработать классы автомобилей с конкретной реализацией конструкторов и методов, свойств.
В классы автомобилей добавить необходимые события (например, финиш).
●	Класс игры должен производить запуск соревнований автомобилей, 
выводить сообщения о текущем положении автомобилей, 
выводить сообщение об автомобиле, победившем в гонках.
Создать делегаты, обеспечивающие вызов методов из классов автомобилей (например, выйти на старт, начать гонку).
●	Игра заканчивается, когда какой-то из автомобилей проехал определенное расстояние(старт в положении 0, финиш в положении 100).
Уведомление об окончании гонки(прибытии какого-либо автомобиля на финиш) реализовать с помощью событий.
*/
    class Program
    {
        delegate void GetToStart();
        delegate void StartRacing();

        static void Main(string[] args)
        {
            Game g = new Game();
            SportCar sp1 = new SportCar();
            SportCar sp2 = new SportCar();

            g.ReadyToStart(sp1, sp2);

            g.MileInfo(sp1, sp2);
        }
    }
}
