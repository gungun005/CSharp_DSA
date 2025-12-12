using System;
class BankAccount
{
private string accountNumber{get;}
private string ownerName{get;set;}
public double balance{get;set;}

public BankAccount(string AccNo,string name,double bal)
{
if(AccNo=="" || AccNo=="NULL")
{
Console.WriteLine("Account Number cannot be NULL or Empty");
}
if(bal<0)
{
Console.WriteLine("Initial Balance cannot be empty");
}
this.accountNumber=AccNo;
this.ownerName=name;
this.balance=bal;
}
public void Deposit(double amount)
{
if(amount>0)
{
this.balance=this.balance+amount;
Console.WriteLine("Amount deposited");
}
else
{
Console.WriteLine("Balance should not be -ve");
}
}

public void Withdraw(double amount)
{
if(amount>0 && this.balance>amount)
{
this.balance=this.balance-amount;
Console.WriteLine("Amount Withdrawn");
}
else
{
Console.WriteLine("Not Possible");
}
}

public void GetInfo()
{
Console.WriteLine($"{ownerName}:Your Account number is:{accountNumber} and your balance is:{balance}");
}


}
class Program
{
public static void Main()
{
BankAccount b1=new BankAccount("123445","Gungun",199990);
b1.Deposit(1234);
b1.GetInfo();
b1.Withdraw(12);
b1.GetInfo();
}
}

