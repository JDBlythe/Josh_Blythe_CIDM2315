using System.Dynamic;
using System.Runtime.InteropServices;

namespace Homework6;

class Program
{
    static void Main(string[] args)
    {
        // Code for Question 1 
        Professor p1 = new Professor();
        p1.profName = "Alice";
        p1.classTeach = "Java";
        p1.SetSalary(9000);

        Professor p2 = new Professor();
        p2.profName = "Bob";
        p2.classTeach = "Math";
        p2.SetSalary(8000);

        Student s1 = new Student();
        s1.studentName = "Lisa";
        s1.classEnroll = "Java";
        s1.SetGrade(90);

         Student s2 = new Student();
        s2.studentName = "Tom";
        s2.classEnroll = "Math";
        s2.SetGrade(80);

        p1.PrintInfo();
        p2.PrintInfo();
        s1.PrintInfo();
        s2.PrintInfo();

        double salaryDifference = p1.GetSalary() - p2.GetSalary();
        Console.WriteLine($"The salary difference between Alice and Tom is: {salaryDifference}");

        Double totalGrades = s1.GetGrade() + s2.GetGrade();
        Console.WriteLine($"The total grade of lisa and tom is: {totalGrades}");
    }
}
class Professor{
    public string profName;
    public string classTeach;
    private double salary=0;
    public void PrintInfo(){
        Console.WriteLine($"Professor {profName} teaches {classTeach}, and the salary is: {salary}");
    }
    public void SetSalary(double salary_amount){
        salary = salary_amount;
    }
    public double GetSalary(){
        return salary;
    }
}
class Student
{
    public string studentName;
    public string classEnroll;
    private double studentGrade=0;
    public void PrintInfo(){
        Console.WriteLine($"Student {studentName} enrolls in {classEnroll}, and their grade is: {studentGrade}");
    }
    public void SetGrade(double newGrade){
        studentGrade = newGrade;
    }
    public double GetGrade(){
        return studentGrade;
    }
    
}
