using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_to_Name
{
    public class Thousands
    {
        public static string Thousand(string thousand)
        {

            string hundred; //= thousand.Substring(1);

            string unitResult;
            
            string hunderedResult = String.Empty;
            string and = "Thousand";

            string seperator;

            var firstnumber = string.Empty ;

            // check if the paramater is in thousands, tens of thousands and hundreds of thousands
            if (thousand.Length == 4)
            {

                firstnumber = thousand.Substring(0,1);

                /*since the first part is just 0ne it adds 2 zeros to it at the beginning, since you can only call the 
                 the hundred method with a number with a lenght of 3, adding zero before it is negliable and does't change its value*/
                firstnumber = "00" + firstnumber;
                hundred = thousand.Substring(1);
            }
            else if (thousand.Length == 5)
            {
                firstnumber = thousand.Substring(0, 2);
                firstnumber = "0" + firstnumber;
                hundred = thousand.Substring(2);
            }
            else
            {
                firstnumber = thousand.Substring(0, 3);
                hundred = thousand.Substring(3);
            }
            

            //if the hundred(second part) is not zero you call the hundred method
            if (hundred != "000")
            {
                hunderedResult = Hundreds.Hundred(hundred);
                seperator = "and";
            }
            else
            {
                if(firstnumber == "000")
                hunderedResult = Hundreds.Hundred(hundred);
                seperator = string.Empty;
            }
            //if (thousand[0] != '0')
            if(firstnumber != "000")
            {
                unitResult = Hundreds.Hundred(firstnumber);
                //unitResult = Units.Unit(firstnumber);

            }
            else
            {
                unitResult = String.Empty;
                and = String.Empty;
                seperator = string.Empty;
            }

            

           

            return unitResult + " " + and + " " + seperator + " " + hunderedResult; 
        }
        
    }
}
