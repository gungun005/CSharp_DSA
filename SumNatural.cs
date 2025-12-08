using System;
class Program
{
static void Main()
{
Console.WriteLine("Enter the number:");
int num=Convert.ToInt32(Console.ReadLine());
int sum=0;
for(int i=1;i<=num;i++)
{
sum+=i;
}
Console.WriteLine($"Sum of first {num} natural numbers is: {sum}");
}
}

