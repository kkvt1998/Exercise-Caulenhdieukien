using System;

namespace Readnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program read number");
            Console.Write("What number do you want to read: ");
            int num;
            num = Int32.Parse(Console.ReadLine());
            if (0 <= num && num <= 999)
            {
                Console.WriteLine("Your number enter: " + num);
                //Calculate
                int hundreds, tens, units;
                string str_hundreds, str_tens, str_units;
                // Read hundreds
                hundreds = num / 100;
                switch (hundreds)
                    {
                        case 1: 
                            str_hundreds = "One hundred";
                            break;
                        case 2:
                            str_hundreds = "Two hundred";
                            break;
                        case 3:
                            str_hundreds = "Three hundred";
                            break;
                        case 4:
                            str_hundreds = "Four hundred";
                            break;
                        case 5:
                            str_hundreds = "Five hundred";
                            break;
                        case 6:
                            str_hundreds = "Six hundred";
                            break;
                        case 7:
                            str_hundreds = "Seven hundred";
                            break;
                        case 8:
                            str_hundreds = "Eight hundred";
                            break;
                        case 9:
                            str_hundreds = "Nine hundred";
                            break;
                        default:
                            str_hundreds = "";
                            break;
                }
                //read tens
                tens = (num % 100) / 10;
                units = (num % 100) % 10;
                if(tens == 0)
                {
                    str_tens = "";
                    switch (units)
                    {
                        case 1:
                            str_units = "one";
                            break;
                        case 2: 
                            str_units = "two";
                            break;
                        case 3:
                            str_units = "three";
                            break;
                        case 4:
                            str_units = "four";
                            break;
                        case 5:
                            str_units = "five";
                            break;
                        case 6:
                            str_units = "six";
                            break;
                        case 7:
                            str_units = "seven";
                            break;
                        case 8:
                            str_units = "eight";
                            break;
                        case 9:
                            str_units = "nine";
                            break;
                        default:
                            str_units = "";
                            break;

                    }
                } 
                else if (tens == 1)
                {
                    str_units = "";
                    switch (units)
                    {

                        case 0:
                            str_tens = "Ten";
                            break;
                        case 1:
                            str_tens = "eleven";
                            break;
                        case 2:
                            str_tens = "twelve";
                            break;
                        case 3:
                            str_tens = "thirteen";
                            break;
                        case 4:
                            str_tens = "fourteen";
                            break;
                        case 5:
                            str_tens = "fifteen";
                            break;
                        case 6:
                            str_tens = "sixteen";
                            break;
                        case 7:
                            str_tens = "seventeen";
                            break;
                        case 8:
                            str_tens = "eighteen";
                            break;
                        case 9:
                            str_tens = "nineteen";
                            break;
                        default:
                            str_tens = "";
                            break;
                    }
                }
                else if(tens > 1)
                {
                    switch (tens)
                    {
                        case 2:
                            str_tens = "twenty";
                            break;
                        case 3:
                            str_tens = "thirty";
                            break;
                        case 4:
                            str_tens = "forty";
                            break;
                        case 5:
                            str_tens = "fifty";
                            break;
                        case 6:
                            str_tens = "sixty";
                            break;
                        case 7:
                            str_tens = "seventy";
                            break;
                        case 8:
                            str_tens = "eighty";
                            break;
                        case 9:
                            str_tens = "ninety";
                            break;
                        default:
                            str_tens = "";
                            break;
                    }
                    switch (units)
                    {
                        case 1:
                            str_units = "one";
                            break;
                        case 2:
                            str_units = "two";
                            break;
                        case 3:
                            str_units = "three";
                            break;
                        case 4:
                            str_units = "four";
                            break;
                        case 5:
                            str_units = "five";
                            break;
                        case 6:
                            str_units = "six";
                            break;
                        case 7:
                            str_units = "seven";
                            break;
                        case 8:
                            str_units = "eight";
                            break;
                        case 9:
                            str_units = "nine";
                            break;
                        default:
                            str_units = "";
                            break;
                    }
                }
                else
                {
                    str_tens = "";
                    str_units = "";
                }
                //Display
                string result = str_hundreds + " and " + str_tens + " " + str_units;
                Console.WriteLine("Read number: " + result);
            }
            else
            {
                Console.WriteLine("Your number is not in range 0 - 999");
            }
        }    
    }
}