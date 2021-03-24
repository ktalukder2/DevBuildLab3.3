using System;
using System.Collections.Generic;

namespace DevBuildLab3._3
{
    class Program
    {
     
        public static string reverseMethod(string userinput)
        {
            string revWord = "";
            Stack<char> words = new Stack<char>();

            foreach (char item in userinput)
            {
                words.Push(item);
            }

            foreach (char item in userinput)
            {
                revWord = revWord + words.Pop();
            }
            return revWord;
        }




        static void Main(string[] args)
        {

            //request user input
            Console.WriteLine("Please Enter a word to reverse ");
            string userInput = Console.ReadLine();

            Console.Write(reverseMethod(userInput));



        }
    }
}
