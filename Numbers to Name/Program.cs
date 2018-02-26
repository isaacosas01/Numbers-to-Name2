using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Speech;
using System.Speech.Synthesis;

namespace Numbers_to_Name
{
    class Program
    {

        
        static void Main(string[] args)
        {

            Start:
          //  string isaac = Console.ReadLine();

          //  Console.WriteLine(isaac.Length);


            //number to convert to text
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak("Enter an input");

            //do
            //{
                
            //} while (b);

            Console.WriteLine( "PLEASE ENTER A NUMBER THAT THE COMPUTER WILL CONVERT TO A STRING AUTOMATICALLY");

            Console.WriteLine("The maximum number you can enter is 1 billion");
            string input = Console.ReadLine();

            //string input = ("78");



            //test to check the length of the input
            if (input.Length == 1) 
            {
              string result = Units.Unit(input[0]);
                Console.WriteLine("You entered {0}", result);
                synth.Speak(result);
            }

            else if (input.Length == 2)
            {
                string result = Tens.Ten(input);
                Console.WriteLine("You entered {0}", result);
                synth.Speak(result);
            }

            else if (input.Length == 3)
            {
                string result = Hundreds.Hundred(input);
                Console.WriteLine("You entered {0}", result);
                synth.Speak(result);
            }

            else if (input.Length >= 4 && input.Length <= 6)
            {
                string result = Thousands.Thousand(input);
                Console.WriteLine("You entered {0}", result);
                //synth.Speak(result);
            }

            else if (input.Length >= 7 && input.Length <= 9)
            {
                string result = Million.Millions(input);
                Console.WriteLine("You entered {0}", result);
                //synth.Speak(result);
            }

            else if (input == "10000000000")
                Console.WriteLine("You entered 1 billion ");
            else
            {
                Console.WriteLine("the number is above the expected range, The max number is 1billion");
            }

            goto Start;


            //else if (input.Length == 5)
            //{
            //    string result = TenThousand.TenThousands(input);
            //    Console.WriteLine("You entered {0}", result);
            //    //synth.Speak(result);
            //}

        }

    }
}
