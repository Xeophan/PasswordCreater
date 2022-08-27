// See https://aka.ms/new-console-template for more informationaaaa
using System;
public class Program
{ 
    public static void Main()
    {
        string[] lowerCase = new string[23] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "r", "s", "t", "u", "v", "y", "z" };
        string[] upperCase = new string[23] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "R", "S", "T", "U", "V", "Y", "Z" };
        string[] numbers = new string[10] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        string password = "";
        Random innerRnd = new Random();
        Random OuterRnd = new Random();
        choiceYes:
        for (int i = 0; i <= 8; i++) 
        {
            int selection = OuterRnd.Next(3);
            switch (selection)
            {
                case 0:
                    password += lowerCase[innerRnd.Next(0, 23)];
                    break;
                case 1:
                    password += upperCase[innerRnd.Next(0, 23)];
                    break;
                case 2:
                    password += numbers[innerRnd.Next(0, 10)];
                    break;     
            }
         
        }
        Console.WriteLine("Your 8 Digit Random Password is ="+" "+password);
    WrongAnswer:
        Console.Write("Do You Want a New One Or Is Thıs Good To Go? (Please Type Y/N) =");
        string choice = Console.ReadLine();
        if (choice == "Y" || choice == "y")
        {
            Console.Clear();
            password = "";
            goto choiceYes;
        }
        else if (choice == "N" || choice == "n")
        {
            Environment.Exit(0);
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Your Input Is Wrong Please Answer The Question Again..");
            goto WrongAnswer;
        }

    }
    

}
