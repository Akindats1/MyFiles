using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildApp
{
    public static class Helper
    {
        public static void Execute()
        {
            /*.1 Declare several variables by selecting for each one of them the most 
            appropriate of the types sbyte, byte, short, ushort, int, uint, long
            and ulong in order to assign them the following values: 52,130; -115; 
            4825932; 97; -10000; 20000; 224; 970,700,000; 112; -44; -1,000,000; 
            1990; 123456789123456789;

            sbyte num1 = 52,97,-44,-115;
            byte num2 = 130,224,112;
            short num3 =-10000,1990;
            ushort num4 =4825932U;
            int num5 =-1000000 ;
            uint num6 =20000U ;
            long num7 =9707000000 ;
            ulong num8 =123456789123456789U;*/


            /*Which of the following values can be assigned to variables of type float, 
            double and decimal: 5, -5.01, 34.567839023; 12.345; 8923.1234857;
            3456.091124875956542151256683467?

            float number = 5F;
            float number2 = -5.01F;
            float number3 =12.345F;
            double number4 = 34.567839023;
            double number5 = 8923.1234857;
            decimal number6 = 3456.091124875956542151256683467M;*/


            //Write a program, which compares correctly two real numbers with 
            //accuracy at least 0.000001.

            /* a = 34.76557666466464846M;
            decimal b =34.64764684847467474M;
            a += b;
            Console.WriteLine(a.ToString("0.000001"));*/


            //Initialize a variable of type int with a value of 256 in
            //hexadecimal format (256 is 100 in a numeral system with base 16).

            /*int hexadecimalnumber = 0x100;
            Console.WriteLine(hexadecimalnumber);*/


            //Declare a variable of type char and assign it as a value the character, 
            // which has Unicode code, 72 (use the Windows calculator in order to find 
            // hexadecimal representation of 72).

            /*char character = '\u0072';
            Console.WriteLine(character);

            //Declare a variable isMale of type bool and assign a value to it depending 
            //on your gender.

            bool isMale = true;

            //Declare two variables of type string with values "Hello" and "World". 
            //Declare a variable of type object. Assign the value obtained of 
            //concatenation of the two string variables (add space if necessary) to this 
            //variable. Print the variable of type object.

            string string1 ="Hello";
            string string2 ="World";
            object object1 = string1 + " " + string2;
            Console.WriteLine(object1);*/

            /*Declare two variables of type string and give them values "Hello" and 
            "World". Assign the value obtained by the concatenation of the two 
            variables of type string (do not miss the space in the middle) to a 
            variable of type object. Declare a third variable of type string and 
            initialize it with the value of the variable of type object (you should use 
            type casting)*/

                
            // string string1 ="Hello";
            // string string2 ="World";
            // object object1 = string1 + " " + string2;
            // string string3 = object1.ToString();

            //Declare two variables of type string and assign them a value “The 
            //"use" of quotations causes difficulties.” (without the outer quotes). 
            //In one of the variables use quoted string and in the other do not use it.*/

            //string string4 = "The \"use\" of quotations causes diffculties";
            //string string5 = "The" + " " +  "\u0022"  + "use" +  "\u0022" + " " + "of quotations causes difficulties";
            //Console.WriteLine(string4);
            //Console.WriteLine(string5);

            /*Write a program to print a figure in the shape of a heart by the sign "o".
            Console.WriteLine("  o         o");
            Console.WriteLine("o   o     o   o");
            Console.WriteLine(" o    o  o   o ");
            Console.WriteLine("  o   o o   o");
            Console.WriteLine("    o      o");
            Console.WriteLine("      o   o   ");
            Console.WriteLine("       o o");
            Console.WriteLine("        oo");

            // Write a program that prints on the console isosceles triangle which 
            //sides consist of the copyright character "©"
            Console.WriteLine("    @");
            Console.WriteLine("   @ @ ");
            Console.WriteLine("  @   @    ");
            Console.WriteLine(" @    @    ");
            Console.WriteLine("@@@@@@@   ");*/

            /* A company dealing with marketing wants to keep a data record of its 
            employees. Each record should have the following characteristic – first 
            name, last name, age, gender (‘m’ or ‘f’) and unique employee number 
            (27560000 to 27569999). Declare appropriate variables needed to 
            maintain the information for an employee by using the appropriate data 
            types and attribute names.*/

            /*string firstName;
            string lastname;
            byte age;
            char gender;
            int employeeNumber;*/

            // Declare two variables of type int. Assign to them values 5 and 10 
            // respectively. Exchange (swap) their values and print them.

            /*int a = 5;
            int b = 10;
            int a = a + b;
            int b = a - b;
            int a = a - b;
            Console.WriteLine($"a:{a} and b:{b}");*/


            /*bool arraysEqual = true;

            Console.Write("Enter lenght of first array: ");
            int length = Int32.Parse(Console.ReadLine());

            int[] arrA = new int[length];

            for (int i = 0; i < arrA.Length; i++)
            {
                Console.Write("Enter element {0}: ", i);
                arrA[i] = Int32.Parse(Console.ReadLine());
            }

            Console.Write("\nEnter lenght of second array: ");

            if(length != int.Parse(Console.ReadLine()))
            {
                    Console.WriteLine("\nArrays have different lengths therefore they are not equal.");
        
            }
            else
            {
                int[] arrB = new int[length];

            for (int i = 0; i < arrB.Length; i++)
            {
                Console.Write("Enter element {0}: ", i);
                arrB[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arrA.Length; i++)
            {
                if (arrA[i] != arrB[i])
                {
                    Console.WriteLine("\nArrays are different.");
                    arraysEqual = false;
                    break;
                }
            }

        if (arraysEqual) Console.WriteLine("\nArrays are the same.");
        }*/
            
            





            /*
            8.Write a program that prints on the console the current date and time.
            9.Write a program that prints the square root of 12345.
            10.Write a program that prints the first 100 members of the sequence 2, -
                3, 4, -5, 6, -7, 8.
            11.Write a program that reads your age from the console and prints your 
                age after 10 years 
            */




             int V = 5;
            Console.WriteLine("Enter X:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y:");
            int y = int.Parse(Console.ReadLine());
            bool isInside = (x * x) + (y * y) <= 25;
            bool outOfRectangle = (x < -1 && x > V) && (y < 1 && y > V);
            bool isInsideAndOutOfRectangle = isInside && outOfRectangle ? true : false;
            Console.WriteLine($"The point {x} and {y} is inside the cirle and out of the rectangle :{isInsideAndOutOfRectangle}");

            Console.WriteLine("Enter hexa Number:");
            string hexNumber = Console.ReadLine();
            Console.WriteLine("Enter positive fraction number:");
            double positiveFractionNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter  negative fraction number:");
            double negativeFractionNumber =  double.Parse(Console.ReadLine());
            Console.WriteLine("[{0 , -10:x}]", hexNumber);
            Console.WriteLine("[{0 , -10:f2}]", positiveFractionNumber);
            Console.WriteLine("[{0 , -10:f2}]", negativeFractionNumber);
        }
    }
}