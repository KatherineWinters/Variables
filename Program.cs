using System;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string accountType = "Checking";
            int accountNumber = 5645;
            char ownerLastInitial = 'W';
            bool hasSavings = true;
            double yearsOpen = 2.5;
            decimal balance = 2585.36M;

            Console.WriteLine($"Account: {accountType}\n" +
                $"Account Number: {accountNumber}\n" +
                $"Last Initial: {ownerLastInitial}\n" +
                $"Savings: {hasSavings}\n" +
                $"Years account has been open: {yearsOpen}\n" +
                $"Account Balance: {balance}\n");
        }
    }
}