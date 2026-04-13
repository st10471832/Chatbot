using System;

namespace CyberSecurity_Chatbot
{//start of namespace
    public class Program
    {//start of class
        static void Main(string[] args)
        {//start of main method

            //creating object for voice greeting
            greet_voice voice = new greet_voice();

            //creating object for ASCII logo
            ASCII_logo logo = new ASCII_logo();

            //creating object for greeting and name
            greet_and_name user = new greet_and_name();

            //calling methods
            voice.play_voice();
            logo.display_logo();
            user.welcome();
            user.ask_name();

        }//end of main method
    }//end of class
}//end of namespace