/*
UNDERSTANDING THE OBJECT CLASS

In C# every type implicitly inherits from System.Object Class
That means every type automatically gets-

1->ToString()
2->Equals()
3->GetHashCode()
4->GetType()
*/
/*
GETTING ON ToString() of Default Object Class:-

1->If you don't override it it just returns the Namespace.ClassName of the object


using System;

class Practise
{
void Func()
{
Console.WriteLine("Hi ! I am function");
}
}

class Program
{

public static void Main()
{
Practise p=new Practise();
Console.WriteLine(p.ToString());
}
}


 Why we should override ToString()?
  1->Readable debug output
  2->It will represent data meaningfully
  3->Useful in collections to print data
  4->We mainly do it class to provide a custom string representation 
  */

//How to override ToString in c#? I guess this is usually done for the custom string representation 

using System;
public class Employee
{
public string Fname;
public string Lname;
public override string ToString()
{
return ($"{Fname}:{Lname}");
}
}
class Program
{
public static void Main()
{
Employee e=new Employee();
e.Fname="gungun";
e.Lname="s";
Console.WriteLine(e.ToString());
}
}

//BEST PRACTISE WHEN OVERRIDING TO STRING()-make it readable and use string interpolation!






