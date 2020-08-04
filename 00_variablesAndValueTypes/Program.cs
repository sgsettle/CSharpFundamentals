using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_variablesAndValueTypes
{
    enum PastryType { Cake, Cupcake, Eclaire }

    class Program
    {
        static void Main(string[] args)
        {
            // Booleans
            // Declaration - type name;
            bool isDeclared;

            // Assigning a value
            isDeclared = true;

            // Declaring and assigning an initial value
            bool isDeclarationAndInitiliazed = false;

            isDeclarationAndInitiliazed = true;

            // Characters
            char character = 'a';
            char symbol = '?';
            char number = '7';
            char space = ' ';
            char specialCharacter = '\'';
            // Add \ inside '' to use special characters
            // \n creates new line in console

            Console.WriteLine(specialCharacter);

            // Whole numbers
            byte byteExample = 255;
            // Byte can only go to 255. 0 counts as a number in a byte
            // use a byte if you need a small number
            // cannot be a negative number

            sbyte signedByte = -128;
            // sbyte can only go to -128

            short shortExample = 32767;
            //32767 is max number
            Int16 anotherShortExample = -32000;
            // use short instead of Int16

            int intMin = -2147483648;
            uint unsignedInt = 400000000;
            // min value is 0 on uint so it can't be negative
            //signed can go negative
            // unsigned is only positive

            long longExample = 9223372036854775807;

            Console.WriteLine(longExample + 1);

            //Decimals
            float floatExample = 1.320561408513f;
            double doubleExample = 1.320561408513d;
            decimal decimalExample = 1.320561408513m;

            // Structs
            // Always has a default value
            DateTime today = DateTime.Today;
            DateTime tomorrow = new DateTime(2020, 7, 29);

            // Enums
            PastryType myPastry = PastryType.Cake;
            PastryType anotherOne = PastryType.Eclaire;

            DayOfWeek dayOfWeek = DayOfWeek.Tuesday;

            Console.ReadLine();
        }
    }
}
