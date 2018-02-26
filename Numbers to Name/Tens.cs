using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_to_Name
{

    //how do you index a string, how do you convert a string into an array
    public static class Tens
    {
        public static string Ten(string ten)
        {
            
           
            if (ten[0] == '1')
            {
                if (ten.EndsWith("1"))
                {
                    return "eleven";
                }
                if (ten.EndsWith("2"))
                {
                    return "twleve";
                }

                if (ten.EndsWith("3"))
                {
                    return "Thirteen";
                }

                if (ten.EndsWith("4"))
                {
                    return "Fourteen";
                }

                if (ten.EndsWith("5"))
                {
                    return "Fifteen";
                }

                if (ten.EndsWith("6"))
                {
                    return "Fifteen";
                }

                if (ten.EndsWith("7"))
                {
                    return "Seventeen";
                }

                if (ten.EndsWith("8"))
                {
                    return "Eighteen";
                }

                if (ten.EndsWith("9"))
                {
                    return "nineteen";
                }
                if (ten.EndsWith("0"))
                {
                    return "Ten";
                }
                else return " an Invalid input";


            }
            //if (ten[0] == '2')
            if(true)
            {
                string tenth;

                if (ten[1] != '0')
                {
                     tenth = Units.Unit(ten[1]);
                }
                else
                {
                    tenth = "";
                }
                

                var x = ten[0];

                switch (x)
                {
                    case '2':
                        
                        return "Twenty " + tenth;
                        break;

                    case '3':

                        return "Thirty " + tenth;
                        break;

                    case '4':

                        return "Fourty " + tenth;
                        break;

                    case '5':

                        return "Fifty " + tenth;
                        break;

                    case '6':

                        return "Sixty " + tenth;
                        break;

                    case '7':

                        return "Seventy " + tenth;
                        break;

                    case '8':

                        return "Eighty " + tenth;
                        break;

                    case '9':

                        return "Ninty " + tenth;
                        break;

                    case '0':

                        return tenth;
                        break;

                    default:
                        Console.WriteLine("You entered an invalid input");
                        return "Invalid";
                        break;
                }
            }
            return "Testing";
        }
    }
}
