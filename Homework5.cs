using System.Security.Cryptography;
using System.Transactions;
using Microsoft.VisualBasic;

namespace Homework5;

class Program
{
    static void Main(string[] args)
    {
        // Q1 code
        Console.WriteLine("Please input two integers");
        int A = GetInteger();
        int B = GetInteger();
        int BigNum = BiggestNum1(A, B);
        Console.WriteLine("a= " + A + ", " + "b= " + B + "\nThe largest number is: " + BigNum);
        // Q2 code
        Console.WriteLine("Please input four integers");
        int num1 = GetInteger();
        int num2 = GetInteger();
        int num3 = GetInteger();
        int num4 = GetInteger();
        int BigNum2 = BiggestNum2(num1, num2, num3, num4);
        Console.WriteLine("a= " + num1 + ", b= " + num2 + ", c= "+ num3 + ", d= "+ num4 + "\nThe largest number is: " + BigNum2);
        // Q3 code
        CreateAccount();
    }
    
    static int GetInteger(){
        string? str_input = Console.ReadLine();
        int int_input = Convert.ToInt16(str_input);
        return int_input;
    }
    static int BiggestNum1(int A, int B){
            return A > B ? A : B;
        // Q2 calling method from Q1 to find largest number of 4
    } static int BiggestNum2(int num1, int num2, int num3, int num4){
        int AB = BiggestNum1(num1, num2);
        int CD = BiggestNum1(num3, num4);
        int BiggestOf4 = BiggestNum1(AB, CD);
        return BiggestOf4;
    }
    static bool CheckAge(int birth_year){
        int current_year = 2025;
        int age = current_year - birth_year;
        return age >= 18;     
   }
   static void CreateAccount(){
        Console.WriteLine("Enter your Username:");
        string? username = Console.ReadLine();
        Console.WriteLine("Enter Your Password");
        string? password = Console.ReadLine();
        Console.WriteLine("Enter Your Password Again:");
        string? ConfirmPassword = Console.ReadLine();
        Console.WriteLine("Enter Your Birthyear:");
        int birth_year = Convert.ToInt16(Console.ReadLine());
        if(CheckAge(birth_year)){
            if (password == ConfirmPassword){
                Console.WriteLine("Account is created successfully");
            }
            else{
                Console.WriteLine("Wrong Password");
            }
        }
        else{
            Console.WriteLine("Could not create account");
        }
   }
   
}