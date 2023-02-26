using System;

class Program
{
    static void Main(string[] args)
    {
        string firstName;
        string lastName;
        Console.WriteLine("What is your First Name?");
        firstName = Console.ReadLine();
        Console.WriteLine("What is your Last Name?");
        lastName = Console.ReadLine();
        Console.WriteLine(@$"My name is {firstName}... {firstName} {lastName}");


    }
}