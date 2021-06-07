using System;

namespace AssessmentQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1. Create a variable of type String. Call this string 'name'. Give this string the value of "Jane".
             * Create a variable of type Integer. Call this integer 'age'. Give this integer the value of 34.
             * 
             * Using these variables, write to console the message: "Jane is 34".
             */


            //Write code here.

            Console.WriteLine("Answer Here");



            /*----------------------------------------------------------------------------------------------------------------------------------------------------
             * 2. You are given an array of integers.
             * 
             * Write to console the lowest value of the array.
             */

            int[] testArray = RandomArray();

            int lowestValue = testArray[0];


            //Write code here.

            Console.WriteLine(lowestValue); //Answer should be either 1, -5, or -10



            /*----------------------------------------------------------------------------------------------------------------------------------------------------
             * 3. You will be given a string at random. If the given string is "Red", you should write to console the word "STOP".
             * 
             * If the given string is "Yellow", you should write to console the word "SLOW".
             * 
             * If the given string is "Green", you should write to console the word "GO".
             * 
             * If a string other than these options is given, write to console the message "Input is invalid".
             * 
             * Your message should be printed regardless of capitalization. For example: "Red", "red", and "rED" would all return the message "STOP".
             */

            string testString = RandomString();


            //Write code here.

            Console.WriteLine("Answer Here");

        }

        public static int[] RandomArray()
        {
            Random rnd = new Random();

            int selection = rnd.Next(1, 4);

            int[] anArray;

            if(selection == 1)
            {
                anArray = new int[] { 1, 3, 5 };
            }
            else if(selection == 2)
            {
                anArray = new int[] { -1, -3, -5 };
            }
            else
            {
                anArray = new int[] { 10, -10, 5, -5, 0 };
            }

            return anArray;
        }

        public static string RandomString ()
        {
            Random rnd = new Random();

            int selection = rnd.Next(1, 9);

            if (selection == 1)
            {
                return "Red";
            }
            else if(selection == 2)
            {
                return "rED";
            }
            else if(selection == 3)
            {
                return "yeLLow";
            }    
            else if(selection == 4)
            {
                return "yellow";
            }
            else if(selection == 5)
            {
                return "GREEN";
            }
            else if(selection == 6)
            {
                return "gReEn";
            }
            else if(selection == 7)
            {
                return "Blue";
            }
            else
            {
                return "purple";
            }
        }
    }
}
