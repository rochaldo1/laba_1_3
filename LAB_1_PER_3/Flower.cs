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
            set { name = value; }
        }
    }
}
