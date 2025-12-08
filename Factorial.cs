using System;
class Program
{
static void Main()
{
Console.WriteLine("Enter the number :");
int num=Convert.ToInt32(Console.ReadLine());
int fact=1;
for(int i=1;i<=num;i++)
{
fact=fact*i;
}
Console.WriteLine($"The factorial of {num} is :{fact}");
}
}
