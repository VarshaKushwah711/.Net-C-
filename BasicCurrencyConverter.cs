using System;
class Program{
    static void Main(){
        char continueChoice;
        do{
            Console.WriteLine("------- Basic Currency Converter -------");
            Console.WriteLine("1. Convert USD to INR");
            Console.WriteLine("2. Convert INR to USD");
            Console.WriteLine("3. Exist");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice){
                case (1) : {
                    Console.WriteLine("Enter Amount in USD");
                    double usdAmt = Convert.ToDouble(Console.ReadLine());
                    double inrAmt = usdAmt * 86.90;
                    Console.WriteLine($"$ {usdAmt} USD is equal to ₹ {inrAmt} INR");
                    break;
                }
                case (2) : {
                    Console.WriteLine("Enter Amount in INR");
                    double inrAmt = Convert.ToDouble(Console.ReadLine());
                    double usdAmt = inrAmt * 0.012;
                    Console.WriteLine($"₹ {inrAmt} INR is equal to $ {usdAmt} INR");
                    break;
                }
                case (3) : {
                    Console.WriteLine("Existing....");
                    break;
                }
                default : {
                    Console.WriteLine("Invalid Choice! try again later....");
                    return;
                }
            }
            if(choice != 3){
                Console.WriteLine("Do you want to perform another conversion ? (y/n)");
                continueChoice = Convert.ToChar(Console.ReadKey().KeyChar);
            }
            else{
                continueChoice = 'n';
            }
            Console.WriteLine();
        }while(continueChoice == 'y' || continueChoice == 'Y');

        Console.WriteLine("Thank You for using Currency Converter! \n----------------------------------------");
    }
}
