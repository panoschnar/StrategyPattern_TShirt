using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern_TShirt
{
    class Menu
    {
        public void FabricMenu()
        {
            Console.WriteLine("Please select the number corresponding to the desired fabric of the T-Shirt:");
            Console.WriteLine("1. WOOL");
            Console.WriteLine("2. COTTON");
            Console.WriteLine("3. POLYESTER");
            Console.WriteLine("4. RAYON");
            Console.WriteLine("5. LINEN");
            Console.WriteLine("6. CASHMERE");
            Console.WriteLine("7. SILK");
        }

        public void ColorMenu()
        {
            Console.WriteLine("Please select the number corresponding to the color of the T-Shirt:");
            Console.WriteLine("1. RED");
            Console.WriteLine("2. ORANGE");
            Console.WriteLine("3. YELLOW");
            Console.WriteLine("4. GREEN");
            Console.WriteLine("5. BLUE");
            Console.WriteLine("6. INDIGO");
            Console.WriteLine("7. VIOLET");
        }

        public void SizeMenu()
        {
            Console.WriteLine("Please select the number corresponding to the size of the T-Shirt:");
            Console.WriteLine("1. XS");
            Console.WriteLine("2. S");
            Console.WriteLine("3. M");
            Console.WriteLine("4. L");
            Console.WriteLine("5. XL");
            Console.WriteLine("6. XXL");
            Console.WriteLine("7. XXXL");
        }

        public void PaymentMethodMenu()
        {
            Console.WriteLine("Select payment method");
            Console.WriteLine("1. Credit card");
            Console.WriteLine("2. Bank transfer");
            Console.WriteLine("3. Cash");
        }
    }
}
