using Microsoft.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Variables
            /*
            double number;
            number = 4.82;
            Console.WriteLine(number);
            
            
            
            Console.WriteLine("**Menu**");
            Console.WriteLine();

            double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            applePrice = 14.85;
            orangePrice = 20.95;
            strawberryPrice = 45;
            potatoPrice = 9.74;
            tomatoPrice = 6.88;

            Console.WriteLine("---Apple Unit Price: " + applePrice);
            Console.WriteLine("---Orange Unit Price: " + orangePrice);
            Console.WriteLine("---Strawberry Unit Price: " + strawberryPrice);
            Console.WriteLine("---Potato Unit Price: " + potatoPrice);
            Console.WriteLine("---Tomato Unit Price: " + tomatoPrice);

            double appleGram, orangeGram, strawBerryGram, potatoGram, tomatoGram;
            appleGram = 1.245;
            orangeGram = 2.650;
            strawBerryGram = 0.750;
            potatoGram = 4.859;
            tomatoGram = 3.745;

            double appleTotalPrice = appleGram * applePrice;
            double orangeTotalPrice = orangeGram * orangePrice;
            double strawBerryTotalPrice = strawBerryGram * strawberryPrice;
            double potatoTotalPrice = potatoGram * potatoPrice;
            double tomatoTotalPrice = tomatoGram * tomatoPrice;
            double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawBerryTotalPrice +potatoTotalPrice + tomatoTotalPrice;

            Console.WriteLine("\nProduct Received : Apple " + "\nUnit Price : " + applePrice + "\nWeight : " + appleGram + "\nTotal Price : " + appleTotalPrice + "\n*******************");
            Console.WriteLine("Product Received : Orange  " + "\nUnit Price : " + orangePrice + "\nWeight : " + orangeGram + "\nTotal Price : " + orangeTotalPrice + "\n*******************");
            Console.WriteLine("Product Received : Strawberry  " + "\nUnit Price : " + strawberryPrice + "\nWeight : " + strawBerryGram + "\nTotal Price : " + strawBerryTotalPrice + "\n*******************");
            Console.WriteLine("Product Received : Potato " + "\nUnit Price : " + potatoPrice + "\nWeight : " + potatoPrice + "\nTotal Price : " + potatoTotalPrice + "\n*******************");
            Console.WriteLine("Product Received :   " + "\nUnit Price : " + tomatoPrice + "\nWeight : " + tomatoGram + "\nTotal Price : " + tomatoTotalPrice + "\n*******************");

            Console.WriteLine("\nTotal Price : " + shoppingTotalPrice );
            */
            #endregion

            #region Char Variables
            /*
            char symbol;
            symbol = 'a';
            Console.WriteLine(symbol);
            */
            #endregion

            #region Keyboard Data Input String Variables
            /*
            Console.WriteLine("*** X Airline Passenger Information ***\n");
            string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            Console.Write("Passenger Name : ");
            passengerName = Console.ReadLine();

            Console.Write("Passenger Surname : ");
            passengerSurname = Console.ReadLine();

            Console.Write("District Info : ");
            passengerDistrict = Console.ReadLine();

            Console.Write("City Info : ");
            passengerCity = Console.ReadLine();

            Console.Write("Passenger Age : ");
            passengerAge = Console.ReadLine();

            Console.Write("Passenger Id Number : ");
            passengerIdentityNumber = Console.ReadLine();

            Console.WriteLine("\n-----------------------------------\n");

            Console.WriteLine("Passenger Id Number: " + passengerIdentityNumber + " || " + "Passenger Name and Surname: " + passengerName + " " + passengerSurname + " || " + "Passenger District and City: " + passengerDistrict + " , " + passengerCity + " || " + "Passenger Age: " + passengerAge);
            */
            #endregion

            #region Integer Inputs and Conversions from the Keyboard
            /*
            int shoePrice, computerPrice, chairPrice, televisionPrice;
            shoePrice = 1000;
            computerPrice = 20000;
            chairPrice = 5000;
            televisionPrice = 12000;

            int shoeCount, computerCount, chairCount, televisionCount;

            Console.Write("Please enter the number of shoes you bought : ");
            shoeCount = int.Parse(Console.ReadLine());

            Console.Write("Please enter the number of computers you bought : ");
            computerCount = int.Parse(Console.ReadLine());

            Console.Write("Please enter the number of chairs you bought : ");
            chairCount = int.Parse(Console.ReadLine());

            Console.Write("Please enter the number of televisions you bought : ");
            televisionCount = int.Parse(Console.ReadLine());

            int totalPrice = shoePrice * shoeCount + computerPrice * computerCount + chairPrice * chairCount + televisionPrice * televisionCount;

            Console.WriteLine("Total Price : " + totalPrice );
            */
            #endregion

            #region Decimal Number Operations from the Keyboard
            /*
            double exam1, exam2, exam3, result;

            Console.Write("Please enter the 1st exam grade: ");
            exam1 = double.Parse(Console.ReadLine());

            Console.Write("Please enter the 2nd exam grade: ");
            exam2 = double.Parse(Console.ReadLine());

            Console.Write("Please enter the 3rd exam grade: ");
            exam3 = double.Parse(Console.ReadLine());

            result = (exam1 + exam2 + exam3) / 3;
            Console.Write("\nExams Average " + result);
            */

            #endregion

            #region Character Selections from the Keyboard
            /*
            char gender;
            Console.WriteLine("Please enter gender (M / F): ");
            gender = char.Parse(Console.ReadLine());

            Console.WriteLine("Selected Gender: " + gender);
            */

            #endregion

            Console.Read();
        }
    }
}   
