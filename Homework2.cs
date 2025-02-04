using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace Homework2;

class Program
{
    static void Main(string[] args)
    {
            // Question 1 Begin

        Console.WriteLine("Please input a letter grade:");
        string? LetterGrade = Console.ReadLine();
        string LetterGrade1 = LetterGrade.ToUpper();
        switch (LetterGrade1) 
        {
        case "A":
            Console.WriteLine("GPA point: 4");
            break;
        case "B":
            Console.WriteLine("GPA point: 3");
            break;
        case "C":
            Console.WriteLine("GPA point: 2");
            break;
        case "D":
            Console.WriteLine("GPA point: 1");
            break;
        case "F":
            Console.WriteLine("GPA point: 0");
            break;
        default:
            Console.WriteLine("Wrong Letter Grade!");
            break;     

            // Question 1 End
        }
            // Question 2 Begin 

        Console.WriteLine("Please input the first num:");
        string? num1 = Console.ReadLine();
            int num1_int = Convert.ToInt16(num1);
        Console.WriteLine("Please input the second num:");
        string? num2 = Console.ReadLine();
            int num2_int = Convert.ToInt16(num2);
        Console.WriteLine("Please input the third num:");
        string? num3 = Console.ReadLine();
            int num3_int = Convert.ToInt16(num3);
        if(num1_int<num2_int){
            if(num1_int<num3_int){
                Console.WriteLine("The smallest value is: "  + num1_int);
            }
            else{
                Console.WriteLine("The smallest value is: " + num3_int);
            }
        }
        else{
            if(num2_int<num3_int){
                Console.WriteLine("the smallest value is: " + num2_int);
            }
            else{
                Console.WriteLine("The smallest value is: " + num3_int);

                // Question 2 end
            }
        }

    }
        
        
}
