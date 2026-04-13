using System;

namespace CyberSecurity_Chatbot
{//start of namespace
    public class ASCII_logo
    {//start of class

        public void display_logo()
        {//start of method

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("==================================");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("   CYBERSECURITY CHATBOT");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("==================================");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("     [ 🔒 Stay Safe Online 🔒 ]");

            Console.ResetColor();

        }//end of method

    }//end of class

}//end of namespace