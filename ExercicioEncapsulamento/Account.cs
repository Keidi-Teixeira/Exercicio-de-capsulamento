using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEncapsulamento
{
    internal class Account
    {
        private int number;
        private String holder;
        private double balance;

        public int getNumber() { return this.number; }
        public String getHolder() { return this.holder; }
        public void setHolder(String holder) { this.holder = holder; } 
        public double getBalance() { return balance; }

        public Account(int number, String holder) { this.number = number; this.holder = holder; }
        public Account(int number, String holder, double initialDeposit) { this.number = number; this.holder = holder; deposit(initialDeposit); }

        public void deposit(double amount) { this.balance += amount; }
        public void withdraw(double amount) { this.balance -= amount + 5.0; }
        
        public String toString()
        {
            return "Account " + this.number.ToString() + ", Holder: " + this.holder + ", Balance: $ " + Convert.ToString(this.balance) ;
            //String.Format("%.2f", this.balance)
        }


    }
}

