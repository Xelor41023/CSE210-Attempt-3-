using System;

class Program
{
    static void Main(string[] args)
    {
        List<double> Numbers = new List<double>();
        bool inputsDone = false;
        double userNumber =0;
        double listSum = 0;
        double listAverage = 0;
        double listLargestNumber = 0;
        double listLength = 0;
        
        do{

            Console.Write("Please enter a number  into the list type 0 when your done");
            userNumber = double.Parse(Console.ReadLine());

            if (userNumber != 0)
            {
                Numbers.Add(userNumber);
                inputsDone = false;

            }
            else if (userNumber == 0)
            {
                inputsDone = true;
            }
    

        }while(inputsDone == false);

        Console.WriteLine("calculating values");

        foreach (double number in Numbers)
        {
            listSum =  listSum + number;
            listLength = Numbers.Count();
            listAverage = double.Parse(listSum/listLength);
            
            if (number > listLargestNumber)
            {
                listLargestNumber = number;
            }
        }



    }

}