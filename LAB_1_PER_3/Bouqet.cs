using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_1_PER_3
{
    internal class Bouqet
    {
        private List<Flower> flowers = new List<Flower>();
        public void AddFlower(string name, Color color, int hoursInAir, int hoursInWater, double basePrice)
        {
            flowers.Add(new Flower(name, color, hoursInAir, hoursInWater, basePrice));
        }

        public void RemoveFlower(int index)
        {
            if (index < 0 || index >= flowers.Count())
                throw new ArgumentException("Некорректное значение индекса, удаление невозможно");

            flowers.RemoveAt(index);
        }
        public double GetBasePrice()
        {
            double s = 0;
            int size = flowers.Count();
            for (int i = 0; i < size; i++)
                s += flowers[i].BasePrice;
            return s;
        }
        public double GetRealPrice()
        {
            double s = 0;
            int size = flowers.Count();
            for (int i = 0; i < size; i++)
                s += flowers[i].RealPrice();
            return s;
        }
        public int Size() => (int)flowers.Count();

        public int NumOfWithered()
        {
            int c = 0;
            int size = flowers.Count();
            for (int i = 0; i < size; i++)
                if (flowers[i].State == 0)
                    c++;
            return c;
        }

        public void SetPlacement(bool iWater)
        {
            int size = flowers.Count();
            for (int i = 0; i < size; i++)
                flowers[i].InWater=iWater;
        }
        public void moveInnerClock(int hours)
        {
            int size = flowers.Count();
            for (int i = 0; i < size; i++)
                try
                {
                    flowers[i].MoveInnerClock(hours);
                }
                catch (ArgumentException e)
                {
                    throw e;
                }
        }
        public void print()
        {
            Console.WriteLine("\n\nБукет:") ;
            int size = flowers.Count();
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Название: {0}", flowers[i].Name);
                Console.WriteLine("Цвет: {0}", flowers[i].Color);
                Console.WriteLine("Состояние цветка: {0}", flowers[i].State);
                Console.WriteLine("Скорость, за которую цветок завянет на воздухе: {0}", flowers[i].FadingInAir);
                Console.WriteLine("Скорость, за которую цветок завянет в воде: {0}", flowers[i].FadingInWater);
                Console.WriteLine("Базовая стоимость: {0}", flowers[i].BasePrice);
                Console.WriteLine("Реальная стоимость: {0}", flowers[i].RealPrice());

                if (flowers[i].InWater)
                    Console.WriteLine("Цветок находится в воде");
                else
                    Console.WriteLine("Цветок находится на воздухе");

                if (flowers[i].State == 0)
                    Console.WriteLine("Цветок завял");
                else
                    Console.WriteLine("Цветок не завял");
            }

        }







    }
}
