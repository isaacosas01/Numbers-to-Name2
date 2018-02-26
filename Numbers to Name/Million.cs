using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_to_Name
{
    public static class Million
    {
        public static string Millions(string million)
        {
            
            string millionWord = "Million";

            string and ;

            string millionResult = String.Empty;

            string  thousandResult = String.Empty;

            /* the thousand part of the million, 
             this will call the thousand method in the Thousand class */
            string thousandPart = String.Empty;

            /* the "million" / first part, 
             this part will call the hundred method in the Hundred class*/
            string millionPart = String.Empty;
           // Thousands.Thousand(thousandPart);

            if (million.Length == 7)
            {

                millionPart = million.Substring(0, 1);

                /*since the first part is just 0ne it adds 2 zeros to it at the beginning, since you can only call the 
                 the hundred method with a number with a lenght of 3, adding zero before it is negliable and does't change its value*/
                millionPart = "00" + millionPart;
                thousandPart = million.Substring(1);
            }
            else if (million.Length == 8)
            {
                millionPart = million.Substring(0, 2);
                millionPart = "0" + millionPart;
                thousandPart = million.Substring(2);
            }
            else
            {
                millionPart = million.Substring(0, 3);
                thousandPart = million.Substring(3);
            }

            // second part is not zero
            if (thousandPart != "000000")
            {
                thousandResult = Thousands.Thousand(thousandPart);
                and = "and";
            }
            else
            {
                if (millionPart == "000")
                    thousandResult = Thousands.Thousand(thousandPart);
                and = string.Empty;
            }
            //if (thousand[0] != '0')
            if (millionPart != "000")
            {
                millionResult = Hundreds.Hundred(millionPart);
                //millionResult = Units.Unit(firstnumber);

            }
            else
            {
                millionResult = String.Empty;
                and = String.Empty;
                millionWord = string.Empty;
            }

            return millionResult + " " + millionWord + " " + and + " " + thousandResult;
        }
    }
}
