using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableTypeExplorer
{
    class Program
    {
        static void Main(string[] args)
        {
            bool boolX = true;
            byte byteX = 45;
            int intX = 12;
            short shortX = -27003;
            long longX = 893L;
            sbyte sbyteX = -123;
            ushort ushortX = 2598;
            uint uintX = 10467;
            ulong ulongX = 5555555UL;
            char charX = 'A';
            float floatX = 12.65f;
            double doubleX = 1.78385;
            decimal decimalX = 0.00045m;
            string stringX = "Hello!";

            Console.SetWindowSize(127, 30);
            Console.WriteLine("* C# Variable Type Chart * \n");

            Console.WriteLine("Simple Types: \n bool = " + boolX + "         Type:  " + boolX.GetType() + "   bytes = 2    range = true/false \n");
            Console.WriteLine("Numeric/Integral Types:");
            Console.WriteLine(" byte = " + byteX + "           Type:  " + byteX.GetType() + "      bytes = 1    range = 0 to 255");
            Console.WriteLine(" short = " + shortX + "      Type:  " + shortX.GetType() + "     bytes = 2    range = -32,768 to 32,767");
            Console.WriteLine(" int = " + intX + "            Type:  " + intX.GetType() + "     bytes = 4    range = -2,147,483,648 to 2,147,483,647");
            Console.WriteLine(" long = " + longX + "          Type:  " + longX.GetType() + "     bytes = 8    range = -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807");
            Console.WriteLine(" sbyte = " + sbyteX + "        Type:  " + sbyteX.GetType() + "     bytes = 1    range = -128 to +127");
            Console.WriteLine(" ushort = " + ushortX + "       Type:  " + ushortX.GetType() + "    bytes = 2    range = 0 to 65,535");
            Console.WriteLine(" uint = " + uintX + "        Type:  " + uintX.GetType() + "    bytes = 4    range = 0 to 4,294,967,295");
            Console.WriteLine(" ulong = " + ulongX + "     Type:  " + ulongX.GetType() + "    bytes = 8    range = 0 to 18,446,744,073,709,551,615");
            Console.WriteLine(" char = " + charX + "            Type:  " + charX.GetType() + "      bytes = 2    range = U+0000 to U+ffff (All Unicode characters)");

            Console.WriteLine("\nNumeric/Floating Point Types:");
            Console.WriteLine(" float = " + floatX + "       Type:  " + floatX.GetType() + "    bytes = 4    range = ±1.0e-45 to ±3.4e38          Precision: 7");
            Console.WriteLine(" double = " + doubleX + "    Type:  " + doubleX.GetType() + "    bytes = 8    range = ±5e-324 to ±1.7e308          Precision: 15-16");

            Console.WriteLine("\nNumeric Types:");
            Console.WriteLine(" decimal = " + decimalX + "   Type:  " + decimalX.GetType() + "   bytes = 16   range = ±1.0 × 10e-28 to ±7.9e28     Precision: 28-29");

            Console.WriteLine("\nString Type:");
            Console.WriteLine(" string = " + stringX + "     Type:  " + stringX.GetType());

            Console.ReadKey();
        }
    }
}
