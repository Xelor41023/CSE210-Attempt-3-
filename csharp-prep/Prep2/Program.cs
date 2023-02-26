using System;

class Program
{
    static void Main(string[] args)
    {
        double studentGradeNumber=100;
        string studentLetterGrade="A";
        string studentPassedText="passed";


        Console.WriteLine("Enter Student Grade");
        studentGradeNumber = double.Parse(Console.ReadLine());

        switch (studentGradeNumber) {

        case double sgn when (sgn >= 90 && sgn <=100):
        studentLetterGrade = "A";
        studentPassedText = "passed";
        break;

        case double sgn when (sgn >= 80 && sgn <=89):
        studentLetterGrade = "B";
        studentPassedText = "passed";
        break;

        case double sgn when (sgn >= 70 && sgn <=79):
        studentLetterGrade = "C";
        studentPassedText = "passed";
        break;

        case double sgn when (sgn >= 60 && sgn <=69):
        studentLetterGrade = "D";
        studentPassedText = "failed";
        break;

        case double sgn when (sgn <=69):
        studentLetterGrade = "F";
        studentPassedText = "failed";
        break;

        default:
            Console.WriteLine("Invalid input please enter a number from 1-100");
            break;

        }

        Console.WriteLine(@$"Student Recived a Grade of {studentLetterGrade}");
        Console.WriteLine(@$"Student {studentPassedText} the class.");

    }
}