using System;
class Program
{
static void Main()
{
Console.WriteLine("Enter the number:");
int num=Convert.ToInt32(Console.ReadLine());
//First we have to take out the no of digits in a number
int temp=num;
int cnt_digit=0;

while(temp>0)
{
temp=temp/10;
cnt_digit++;
}

Console.WriteLine($"The number is of {cnt_digit} digits");
double rev_num=0;
int tempi=num;
while(num>0)
{
int rem=num%10;
rev_num+=rem*Math.Pow(10,--cnt_digit);
num=num/10;
}
Console.WriteLine($"The reverse of {tempi} is :{rev_num}");
}
}

