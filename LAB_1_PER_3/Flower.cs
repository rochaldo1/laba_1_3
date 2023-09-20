using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LAB_1_PER_3
{
    public enum Color
    {
        Red, Green, Blue
    };

    public class Flower
    {
        string name = "Flower";
        Color color = Color.Red;
        double state = 1, fadingInWater = 1, fadingInAir = 1, basePrice = 0;
        bool inWater = false;




        public Flower(string name, Color color, int hoursInAir, int hoursInWater, double basePrice)
        {
            Name = name;
            Color = color;
            FadingInAir = hoursInAir;
            FadingInWater = hoursInWater;
            BasePrice = basePrice;
        }
        public Flower() { }
        public string Name
        {
            get => name;
            set
            {
                if ((!string.IsNullOrWhiteSpace(value)) && (value.Length < 50))
                    name = value;
                else throw new ArgumentException("Длина название должна быть от 1 до 50 символов. Установлено значение по умолчанию!");
            }
        }
        public double State { get => state; }
        public Color Color
        {
            get => color;
            set
            {
                if (!Enum.IsDefined(typeof(Color), value))
                    throw new ArgumentOutOfRangeException(nameof(Color));

                color = value;
            }
        }
        public double FadingInWater
        {
            get => fadingInWater;
            set
            {
                if (value < 1)
                    throw new ArgumentException("Количество часов на воде должно быть больше нуля. Установлено значение по умолчанию!");
                fadingInWater = 1.0 / value;
            }
        }
        public double FadingInAir
        {
            get => fadingInAir;
            set
            {
                
                if (value < 1)
                    throw new ArgumentException("Количество часов в воздухе должно быть больше нуля. Установлено значение по умолчанию!");
                fadingInAir = 1.0 / value;

            }
        }
        public double BasePrice
        {
            get => basePrice;
            set
            {
                if (value <= 0 || value >= 15000000)
                    throw new ArgumentException("Цена должна быть больше 0 и меньше 15000000. Установлено значение по умолчанию!");
                basePrice = value;
            }
        }
        public bool InWater
        {
            get => inWater;
            set { inWater = value; }
        }
        public double RealPrice() => BasePrice * state;

        public void MoveInnerClock(int hours)//сдвиг внутренних часов
        {
            if (hours < 0)
                throw new ArgumentException("Некорректное значение сдвига внутренних часов цветка");
            if (state <= 0) return;
            state -= (inWater ? fadingInWater : fadingInAir) * hours;
            if (state < 0) state = 0;
        }
    }
}
