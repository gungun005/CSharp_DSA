using System;
class Program{
static void Main()
{

Console.WriteLine("Enter number1:");
int a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number2:");
int b=Convert.ToInt32(Console.ReadLine());
//Now we have to perform swapping
int c=0;
c=b;
b=a;
a=c;
Console.WriteLine(a);
Console.WriteLine(b);
}
}
