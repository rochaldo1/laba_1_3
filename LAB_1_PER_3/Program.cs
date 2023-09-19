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
            try
            {
                Flower a = new Flower(" yuyuiiu  ", (Color)2, 5, 7, 7);
                Console.WriteLine(a.Name);
                Console.WriteLine(a.Color);
                Console.WriteLine(a.State);
                Console.WriteLine(a.FadingInAir);
                Console.WriteLine(a.FadingInWater);
                Console.WriteLine(a.BasePrice);
                Console.WriteLine(a.InWater);

                


            }
            catch(ArgumentException e) { Console.WriteLine(e.Message); }
            

        }
    }
}
