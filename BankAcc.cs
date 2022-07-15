using System;
using System.Collections.Generic;
using System.Linq;
using System;

namespace BankEncapsulation;

public class BankAcc
{
    private double balance = 0;

    public void Deposit(double userAmount)
    {
        
        balance += userAmount;
    }

    public double Getbalance()
    {
        return balance;
    }

    public void Withdraw(double userAmount)
    {
        balance -= userAmount;
    }
}
