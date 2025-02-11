using System.Data;

namespace Homework3;

class Program
{
    static void Main(string[] args)
    {
        // Code for question 1
        Console.WriteLine("Input an integer:");
        int N1 = Convert.ToInt32(Console.ReadLine());
        for(int i = 0; i <= N1;){
            if(N1 == 1){
                Console.WriteLine("N is non-Prime");
                break;
            }
            if((N1 == 2) || (N1 % 2 == 1)){
                Console.WriteLine("N is prime");
                break;
            }
            else{
                Console.WriteLine("N is non-prime");
                break;
            }

    }
        // Code for question 2
    {
        Console.WriteLine("Assign an int value to N:");
        int N2 = Convert.ToInt32(Console.ReadLine());
        for(int r = 0; r < N2; r ++){
            for(int c = 0; c < N2; c ++){
                Console.Write('#');
            }
            Console.WriteLine();
        }
    }
        // Code for question 3

        Console.WriteLine("Assign an int value to N: ");
        int N3 = Convert.ToInt32(Console.ReadLine());
        for(int r = 0; r < N3; r ++){
            for(int c = 0; c < N3; c ++){
                if(r>=c)
                Console.Write('*');
            }
            Console.WriteLine();
        }

    }
}