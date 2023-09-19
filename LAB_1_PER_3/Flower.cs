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

    internal class Flower
    {
        string name = "Flower";
        Color color = Color.Red;
        double state = 1, fadingInWater = 1, fadingInAir = 1, basePrice = 0;
        bool inWater = false;

        public string Name
        {
            get { return name; }
            set { if ((!string.IsNullOrWhiteSpace(value)) && (value.Length<10)) name = value; }
        }
        public double State { get { return state; }  }
        public Color Color { get { return color; } }
        public double FadingInWater { 
            get { return fadingInWater; }
            set { fadingInWater = 1.0 / value; }
        }
        public double FadingInAir {
            get { return fadingInAir; } 
            set { fadingInAir = 1.0 / value; }
        }
        public double BasePrice { 
            get { return basePrice; }
            set { if (value > 0 || value < 15000000) basePrice = value; }
        }


    }
}
