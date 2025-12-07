using System;
class Program
{
static void Main()
{
Console.WriteLine("Enter number1:");
int a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number2:");
int b=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the choice of operation you want to perform");
char ch=Convert.ToChar(Console.ReadLine());
switch(ch)
{
case '+':
int sum=a+b;
Console.WriteLine("The Sum is:"+sum);
break;
case '-':
int diff=a-b;
Console.WriteLine("The Diff is:" +diff);
break;
case '/':
int div=a/b;
Console.WriteLine("The Div is :" +div);
break;
case '*':
int mul=a*b;
Console.WriteLine("The Mul is :" +mul);
break;
default:
Console.WriteLine("Invalid Case!");
break;
}
}
}



