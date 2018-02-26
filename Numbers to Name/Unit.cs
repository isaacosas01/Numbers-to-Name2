using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_to_Name
{
    public static class Units
    {
        public static string Unit(char x)
        {
            switch (x)
            {
                case '1':

                    return "one";
                    break;

                case '2':

                    return "two";
                    break;

                case '3':

                    return "three";
                    break;

                case '4':

                    return "four";
                    break;

                case '5':

                    return "five";
                    break;

                case '6':

                    return "six";
                    break;

                case '7':

                    return "seven";
                    break;

                case '8':

                    return "eight";
                    break;

                case '9':

                    return "nine";
                    break;

                case '0':

                    return "zero";
                    break;

                default:
                    Console.WriteLine("You entered an invalid input");
                    return "Invalid";
                    break;
            }
        }
       // public static int Isaac { get; set; }
    }
}
