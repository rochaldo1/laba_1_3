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
            fadingInWater = hoursInWater;
            BasePrice = basePrice;
        }
        public Flower() { }





        public string Name
        {
            get => name;
            set
            {
                if ((string.IsNullOrWhiteSpace(value)) && (value.Length > 50))
                    throw new ArgumentException("Длина название должна быть от 1 до 50 символов. Повторите попытку");

                name = value;

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
                    throw new ArgumentException("Количество часов на воздухе должно быть больше нуля. Повторите попытку");
                fadingInWater = 1.0 / value;
            }
        }
        public double FadingInAir
        {
            get => fadingInAir;
            set
            {
                if (value < 1)
                    throw new ArgumentException("Количество часов в воздухе должно быть больше нуля. Повторите попытку");
                fadingInAir = 1.0 / value;
            }
        }
        public double BasePrice
        {
            get => basePrice;
            set
            {
                if (value <= 0 || value >= 15000000)
                    throw new ArgumentException("Цена должна быть больше 0 и меньше 15000000. Повторите попытку");
                basePrice = value;
            }
        }
        public bool InWater
        {
            get => inWater;
            set { inWater = value; }
        }
        public double RealPrice() => BasePrice * state;

        public bool Withered() => state == 0;

        public void Placement(bool iWater)
        {
            inWater = iWater;
        }

        public void moveInnerClock(int hours)
        {
            if (hours < 0)
                throw new ArgumentException("Некорректное значение сдвига внутренних часов цветка");
            if (state <= 0) return;
            state -= (inWater ? fadingInWater : fadingInAir) * hours;
            if (state < 0) state = 0;
        }
    }
}
