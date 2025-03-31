using System.Diagnostics;
using System.Reflection;

namespace Homework8;

class Program
{
    static void Main(string[] args)
    {
        Customer cus1 = new Customer(customerName:"Alice", customerAge:33, customerCity:"Amarillo", customerCredit:198.5);
        Customer cus2 = new Customer(customerName:"Bob", customerAge:23, customerCity:"Amarillo", customerCredit:226);
        Customer cus3 = new Customer(customerName:"Cathy", customerAge:45, customerCity:"Amarillo", customerCredit:89.0);
        Customer cus4 = new Customer(customerName:"David", customerAge:58, customerCity:"Amarillo", customerCredit:198.5);
        Customer cus5 = new Customer(customerName:"Jack", customerAge:28, customerCity:"Canyon", customerCredit:561.6);
        Customer cus6 = new Customer(customerName:"Tom", customerAge:36, customerCity:"Canyon", customerCredit:98.4);
        Customer cus7 = new Customer(customerName:"Tony", customerAge:24, customerCity:"Canyon", customerCredit:18.5);
        Customer cus8 = new Customer(customerName:"Sam", customerAge:35, customerCity:"Canyon", customerCredit:228.3);


 	    Customer[] customer_list = {cus1, cus2, cus3, cus4, cus5, cus6, cus7, cus8};

        TotalCredits(customer_list);

        AmarilloAverageAge(customer_list);

        CanyonAge(customer_list);

    }
    // Q1 code
    public static void TotalCredits(Customer[] customer_list){
        double totalCredits = 0;
        foreach(Customer cusNumber in customer_list){
            totalCredits += cusNumber.customerCredit;
        }
        Console.WriteLine($"Q1: The total credits: {totalCredits}");
    }
    // Q2 code
    public static void AmarilloAverageAge(Customer[] customer_list){
        double totalAge = 0;
        int countAge = 0;
        foreach(var cusNumber in customer_list)
        if (cusNumber.customerCity == "Amarillo"){
            totalAge += cusNumber.customerAge;
            countAge++;
        }
        if(countAge > 0){
            double AmarilloAverageAge = totalAge/countAge;
            Console.WriteLine($"Q2: The average age of customers in Amarillo: {AmarilloAverageAge}");
        }
        else{
            Console.WriteLine("Q2: No customers are living in Amarillo");
        }
    }
    // Q3 code
    public static void CanyonAge(Customer[] customer_list){
        string namesOver30 = "";
        foreach(var cusNumber in customer_list){
            if(cusNumber.customerCity == "Canyon" && cusNumber.customerAge>30){
                if(namesOver30 != "" )
                namesOver30 += " , ";
                // Console.WriteLine($"Q3: Customers who live in Canyon and are over 30 years old: {cusNumber.customerName}");
                namesOver30 += cusNumber.customerName;
            }
            }
            if(namesOver30 != ""){
                Console.WriteLine($"Q3: Customers who live in Canyon and are over 30 years old: {namesOver30}");
            }
        }
    }   
    
    public class Customer{
        // Q0 code
        public string customerName {get;set;} = string.Empty;
        public int customerAge {get;set;} = 0;
        public string customerCity {get;set;} = string.Empty;
        public double customerCredit {get;set;} = 0;
        public Customer(string customerName, int customerAge, string customerCity, double customerCredit){
            this.customerName = customerName;
            this.customerAge = customerAge;
            this.customerCity = customerCity;
            this.customerCredit = customerCredit;
        }
    } 

