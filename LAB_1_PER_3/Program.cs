using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LAB_1_PER_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

           /* string forColor;
            int _color;

            string forInAir, forInWater;
            int _inAir, _inWater;

            string forBasePrice;
            double _basePrice;

            Flower flower = new Flower();

            void Print()
            {
                Console.WriteLine("Название: {0}", flower.Name);
                Console.WriteLine("Цвет: {0}", flower.Color);
                Console.WriteLine("Состояние цветка: {0}", flower.State);
                Console.WriteLine("Скорость, за которую цветок завянет на воздухе: {0}", flower.FadingInAir);
                Console.WriteLine("Скорость, за которую цветок завянет в воде: {0}", flower.FadingInWater);
                Console.WriteLine("Базовая стоимость: {0}", flower.BasePrice);
                Console.WriteLine("Реальная стоимость: {0}", flower.RealPrice());

                if (flower.InWater)
                    Console.WriteLine("Цветок находится в воде");
                else
                    Console.WriteLine("Цветок находится на воздухе");

                if (flower.State == 0)
                    Console.WriteLine("Цветок завял");
                else
                    Console.WriteLine("Цветок не завял");
            }


            //цветок 1
            Console.Write("Введите название цветка: ");
            try
            {
                flower.Name = Console.ReadLine();
            }
            catch (ArgumentException e) { Console.WriteLine(e.Message); }
            Console.Write("\nНажмите любую клавишу...");
            Console.ReadKey();
            Console.Clear();

            Console.Write("Введите цвет (0 - Красный, 1 - Зеленый, 2 - Синий): ");
            do forColor = Console.ReadLine();
            while (!int.TryParse(forColor, out _color));
            flower.Color = (Color)(_color % 3);
            Console.Write("\nНажмите любую клавишу...");
            Console.ReadKey();
            Console.Clear();

            Console.Write("Введите количество часов, через которые цветок завянет на воздухе: ");
            do forInAir = Console.ReadLine();
            while (!int.TryParse(forInAir, out _inAir));
            try
            {
                flower.FadingInAir = _inAir;
            }
            catch (ArgumentException e) { Console.WriteLine(e.Message); }
            Console.Write("\nНажмите любую клавишу...");
            Console.ReadKey();
            Console.Clear();

            Console.Write("Введите количество часов, через которые цветок завянет в воде: ");
            do forInWater = Console.ReadLine();
            while (!int.TryParse(forInWater, out _inWater));
            try
            {
                flower.FadingInWater = _inWater;
            }
            catch (ArgumentException e) { Console.WriteLine(e.Message); }
            Console.Write("\nНажмите любую клавишу, чтобы продолжить...");
            Console.ReadKey();
            Console.Clear();

            Console.Write("Введите базовую цену: ");
            do forBasePrice = Console.ReadLine();
            while (!double.TryParse(forBasePrice, out _basePrice));
            try
            {
                flower.BasePrice = _basePrice;
            }
            catch (ArgumentException e) { Console.WriteLine(e.Message); }
            Console.Write("\nНажмите любую клавишу, чтобы продолжить...");
            Console.ReadKey();
            Console.Clear();

            Print();
            Console.Write("\nНажмите любую клавишу, чтобы продолжить...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Сдвиг внутренних часов на 5");
            flower.MoveInnerClock(5);
            Print();
            Console.Write("\nНажмите любую клавишу, чтобы продолжить...");
            Console.ReadKey();
            Console.Clear();



            Console.WriteLine("Перемещение цветка в воду");
            flower.InWater = true;
            Print();
            Console.Write("\nНажмите любую клавишу, чтобы продолжить...");
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("Сдвиг внутренних часов на 4");
            flower.MoveInnerClock(4);
            Print();*/











            //Букет
            Bouqet bouquet = new Bouqet();

            int n = 2;
            for (int i = 0; i < n; i++)
            {
                string _forName;
                string _forColor;
                int __color;

                string _forInAir, _forInWater;
                int __inAir, __inWater;

                string _forBasePrice;
                double __basePrice;
                Flower _flower = new Flower();
                while (true)
                {
                    Console.Write("Введите название цветка: ");
                    _forName = Console.ReadLine();
                    Console.Write("\nНажмите любую клавишу...");
                    Console.ReadKey();
                    Console.Clear();

                    Console.Write("Введите цвет (0 - Красный, 1 - Зеленый, 2 - Синий): ");
                    do _forColor = Console.ReadLine();
                    while (!int.TryParse(_forColor, out __color));
                    _flower.Color = (Color)(__color % 3);
                    Console.Write("\nНажмите любую клавишу...");
                    Console.ReadKey();
                    Console.Clear();

                    Console.Write("Введите количество часов, через которые цветок завянет на воздухе: ");
                    do _forInAir = Console.ReadLine();
                    while (!int.TryParse(_forInAir, out __inAir));
                    Console.Write("\nНажмите любую клавишу...");
                    Console.ReadKey();
                    Console.Clear();

                    Console.Write("Введите количество часов, через которые цветок завянет в воде: ");
                    do _forInWater = Console.ReadLine();
                    while (!int.TryParse(_forInWater, out __inWater));

                    Console.Write("\nНажмите любую клавишу, чтобы продолжить...");
                    Console.ReadKey();
                    Console.Clear();

                    Console.Write("Введите базовую цену: ");
                    do _forBasePrice = Console.ReadLine();
                    while (!double.TryParse(_forBasePrice, out __basePrice));

                    Console.Write("\nНажмите любую клавишу, чтобы продолжить...");
                    Console.ReadKey();
                    Console.Clear();
                    try
                    {
                        bouquet.AddFlower(_forName, (Color)(__color % 3), __inAir, __inWater, __basePrice);
                        break;
                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }

            bouquet.print();
            Console.Write(bouquet.Size()+"\n");




        }
    }
}
