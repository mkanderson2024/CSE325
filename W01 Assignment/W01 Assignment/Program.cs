using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Welcome to the greeting program!");

        Console.WriteLine("What is your favorite color? ");

        string favoriteColor = Console.ReadLine();
        Console.WriteLine("Oh, I love " + favoriteColor + " too!");

        Console.Write("What's your name? ");

        string name = Console.ReadLine();

        Console.Write("What is your age? ");
        string ageInput = Console.ReadLine();
        int age = int.Parse(ageInput);


        string greeting = $"Welcome, {name.ToUpper()}! You are {age} years old. Its great to meet you.";
        Console.WriteLine(greeting);
    }
}