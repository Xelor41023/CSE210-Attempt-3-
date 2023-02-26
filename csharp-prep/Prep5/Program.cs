using System;

class Program
{
    static void Main(string[] args)
    {

        displayWelcome();
        string userName = getuserName();
        string userNumber = getuserNumber();
         double squareduserNumber = squareuserNumber(userNumber);
        displayResult(userName,squareduserNumber);
    }

    public static void displayWelcome()
    {
        Console.WriteLine(@$"Welcome to the program!");
    }
    public static string getuserName()
    {
        string userfirstName = "";
        string userlastName = "";
        string userName = "";

        Console.WriteLine(@$"Please Enter Your Name");
        Console.WriteLine("What is your First Name?");
        userfirstName = Console.ReadLine();
        Console.WriteLine($"input accepted your first name is {firstName}");
        Console.WriteLine("What is your last name?");
        userlastName = Console.ReadLine();
        Console.WriteLine($"input accepted your last name is {lastName}");
        userName = userfirstName + "" + userlastName;
        return userName;


    static double getuserNumber()
    {
        double userNumber = 0;
        Console.WriteLine("Please Enter Your Favorite Number");
        userNumber = double.Parse(Console.ReadLine());
        Console.WriteLine($"input accepted your favorite number is {userNumber}");
        return userNumber;
    }

    static double squareuserNumber()
    {
        int squaredUserNumber = userNumber * userNumber;
        return squaredUserNumber;
    }

    static void displayResult(string userName, double squaredUserNumber);
    {
        Console.WriteLine($"{userName} the square of your number is  {squaredUserNumber}");
    }
}