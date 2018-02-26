using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_to_Name
{
    public static class Hundreds
    {
        public static string Hundred(string hundred)
        {
            var tens = hundred.Substring(1);

            string tenth = String.Empty;
            string and;
            if (tens != "00")
            {
                and = " and ";
            }
            else
            {
                and = String.Empty;
            }

            /*This checks if the tens unit in the hundred is zero or not, if it is it simple takes the last 
             * digit and pass it to the unit method in the units class, else it calls the tens class with the last two digit(tens part)*/
            if (tens[0] != '0')
            {
                //if tens != '00'
                tenth = Tens.Ten(tens);
            }
            else
            {
                /* this would always run when the first number in the hundred is zero and also
                 when the last number is not zero(anything else but zero)*/
                if (hundred[0] == '0' || tens[1] != '0')
                tenth = Units.Unit(tens[1]);
            }
            
            

            var x = hundred[0];
            

            switch (x)
            {
                case '1':

                    return "One Hundred" + and + tenth;
                    break;

                case '2':

                    return "Two Hundred" + and + tenth;
                    break;

                case '3':

                    return "Three Hundred" + and + tenth;
                    break;

                case '4':

                    return "Four Hundred" + and + tenth;
                    break;

                case '5':

                    return "five Hundred" + and + tenth;
                    break;

                case '6':

                    return "Six Hundred" + and + tenth;
                    break;

                case '7':

                    return "Seven Hundred" + and + tenth;
                    break;

                case '8':

                    return "Eight Hundred" + and + tenth;
                    break;

                case '9':

                    return "Nine Hundred" + and + tenth;
                    break;

                case '0':

                    return tenth;
                    break;

                default:
                    Console.WriteLine("You entered an invalid input");
                    return "Invalid";
                    break;
            }
            return "";
        }
    }
}
