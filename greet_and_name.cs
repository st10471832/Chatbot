using System;

namespace CyberSecurity_Chatbot
{//start of namespace
    public class greet_and_name
    {//start of class

        //global variable
        private string username = string.Empty;

        //welcome method
        public void welcome()
        {//start of welcome method

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("========================");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Welcome to HNT chatbot");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("========================");

            Console.ResetColor();

        }//end of welcome method

        //ask user name
        public void ask_name()
        {//start of ask method

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("CAN AI: ");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Hey enter your name: ");

            Console.ResetColor();

            do
            {//start of loop

                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("User: ");

                Console.ForegroundColor = ConsoleColor.Gray;
                username = Console.ReadLine();

            }
            while (!IsEmpty());

        }//end of ask method

        //check if empty
        private Boolean IsEmpty()
        {//start of method

            if (username != "")
            {//start of if

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("AI: ");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Hey " + username);

                return true;

            }//end of if
            else
            {//start of else

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("AI:");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter your name");

                return false;

            }//end of else

        }//end of method

    }//end of class
}//end of namespace