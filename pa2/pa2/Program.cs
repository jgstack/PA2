using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pa2
{
    class Program
    {
        static void Main(string[] args)
        {
            //create the menu
            CreateMenu();
            Console.ReadKey();
        }

        static void CreateMenu()
        {
            //method for creating a menu
            //set variable menuChoice = method GetMenuChoice
            string menuChoice = GetMenuChoice();

            //close the program if the menu choice = 3 
            if (menuChoice == "3")
            {
                Console.WriteLine("Goodbye");
            }
                if (menuChoice == "1")
                {
                //welcome user to the program and begin conversions
                    Console.WriteLine("Welcome to our currency converter!");
                    convert();
                }
            if (menuChoice == "2")
            {
                Console.WriteLine("Welcome to the Restaurant POS Mennu!");
                GetChange();
            }
        }

        static string GetMenuChoice()
        {
            //select the choice for the menu you would like to go to
            Console.WriteLine("Please enter 1 to open Currency Exchange, 2 to open Restaurant POS, or 3 to exit: ");
            string choice = Console.ReadLine();

            //confirm that the number you entered was valid and actually led to a menu
            while (!(choice != "1" || choice != "2" || choice != "3")) ;
            {
                Console.WriteLine("Just to confirm, reenter the number! ");
                choice = Console.ReadLine();
            }
            return choice;
        }

        static void convert()
        {
            //get amount of USD the user has and assign to a variable
            Console.WriteLine("Please enter the amount of US Dollars you would like to convert");
            double amountInDollars;
            if (!double.TryParse(Console.ReadLine(), out amountInDollars))
            { }
        
            //declare conversion factors as variables
            double CanadianDollar = 0.9813;
            double Euro = 0.757;
            double Rupee = 52.53;
            double Yen = 80.92;
            double Peso = 13.1544;
            double Pounds = .6178;

            //ask for the currency you want to convert to and assign it to a variable
            Console.WriteLine("Please enter the converison factor of the currecny you wish to convert to " +
                "(options: " +
                "CanadianDollar = 0.9813 ," +
                "Euro = 0.757 ," +
                "Rupee = 52.53 ," +
                "Yen = 80.92 ," +
                "Peso = 13.1544 ," +
                "Pounds = 0.6178) : ");
            double conversionCurrency;
                if (!double.TryParse(Console.ReadLine(), out conversionCurrency))
            { }

                //find final conversion amount 
            double finalAmount = amountInDollars * conversionCurrency;
            Console.WriteLine("The final conversion amount is: " + finalAmount);

        }

        static void GetChange()
        {
            //get the total food bill and assign to a variable
            Console.WriteLine("Please enter the total for the food bill only: ");
            double foodBill;
            if (!double.TryParse(Console.ReadLine(), out foodBill))
            { }

            //get the total alcohol bill and assing to a variable
            Console.WriteLine("Please enter the total amount of the alcohol bill only: ");
            double alcoholBill;
            if (!double.TryParse(Console.ReadLine(), out alcoholBill))
            { }

            //get the tax amount and add to toal food and alcohol to get total bill
            double tax = (foodBill + alcoholBill) * 0.09;
            double totalBill = foodBill + alcoholBill + tax;

            //get the tip based on the food bill and then add the tip to the total
            double tip = foodBill * 0.18;
            double totalBillAndTip = totalBill + tip;

            //get the amount the customer payed from the user and assign it to a variable
            Console.WriteLine("Please enter the amount paid: ");
            double amountPaid;
            if (!double.TryParse(Console.ReadLine(), out amountPaid))
            { }

            //if they did not pay enough, display and error
            if (amountPaid < totalBillAndTip)
            {

                Console.WriteLine("ERROR");
            }

            //if they did pay enough, display the change you owe the customer
            else
            {
              Console.WriteLine("The change due is: " + (amountPaid - totalBillAndTip));
            } 
        }



        }
        
        



    }
