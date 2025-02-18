using System.Reflection.Metadata;

namespace Homework4;

class Program
{
    static void Main(string[] args)
    {
                // Call Q1 method
        Console.WriteLine("Input an integer for a:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input an integer for b:");
        int b = Convert.ToInt32(Console.ReadLine());
        string result = BiggerLess(a, b);
        Console.WriteLine(result);

                // Call Q2 method
        Console.WriteLine("Input an integer for N");
        int N = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input a shape: left or right");
        string? shape = Console.ReadLine();
        Triangle(N, shape);
    }
                // Q1 method
    static string BiggerLess(int a, int b){
        if (a>b){
            return $"a={a}; b={b}\nThe largest number is: {a}";
        }
        else{
            return $"a={a}; b={b}\nThe largest number is: {b}";
        }
    }
                // Q2 method
        static void Triangle(int N, string? shape){
            Console.WriteLine($"N is: {N}; shape is {shape}");
            if (shape == "left"){
                for (int r = 0; r < N; r++){
                    for (int c = 0; c < N; c++){
                        if(r >= c)
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            if (shape == "right"){
                 for (int r = 0; r < N; r++){
                    for (int c = 0; c < N; c++){
                        Console.Write(" ");
                    }
                    for (int c = 0; c <= r; c++){
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}


