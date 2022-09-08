using System;
using ExercicioEncapsulamento;

public class Program
{
    public static void Main(String[] args)
    {
        Account account = null;
        Console.WriteLine("Enter account number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter account holder: ");
        String holder = Console.ReadLine();

        Console.WriteLine("Is there an initial deposit (y/n)? ");
        char response = Convert.ToChar(Console.ReadLine());

        if(response == 'y')
        {
            Console.WriteLine("Enter initial deposit value: ");
            double initialDeposit = Convert.ToDouble(Console.ReadLine());
            account = new Account(number, holder, initialDeposit);
        }
        else if(response == 'n')
        {
            account = new Account(number, holder);
        }
        else
        {
            Console.WriteLine("You can just type 'y' or 'n'!");
        }

        Console.WriteLine();
        Console.WriteLine("Account data: ");
        Console.WriteLine(account.toString());

        Console.WriteLine();
        Console.WriteLine("Enter a deposit value: ");
        double depositValue = Convert.ToDouble(Console.ReadLine());
        account.deposit(depositValue);
        Console.WriteLine("Updated account data: ");
        Console.WriteLine(account.toString());

        Console.WriteLine();
        Console.WriteLine("Enter a withdraw value: ");
        double withdrawValue = Convert.ToDouble(Console.ReadLine());
        account.withdraw(withdrawValue);
        Console.WriteLine("Updated account data: ");
        Console.WriteLine(account.toString());


    }
}
