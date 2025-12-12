//Assignment 1 — Classes, Objects & Constructors
using System;
class Student
{
private string fname;
private string lname;
int age;
char gender;
public Student(string Fname,string Lname,int Age,char Gender)
{
this.fname=Fname;
this.lname=Lname;
this.age=Age;
this.gender=Gender;
}
public void GetFullInfo()
{
Console.WriteLine($"{fname}|{lname}|{age}|{gender}");
}
}
class Program{
public static void Main()
{
Student s1=new Student("Gungun","S",22,'a');
Student s2=new Student("Hancy","L",22,'a');
Student s3=new Student("Devanshi","M",22,'a');
s1.GetFullInfo();
s2.GetFullInfo();
s3.GetFullInfo();
}
}
/*WHAT EXTRA I SHOULD THINK IS
 1->TO USE CAMEL CASING 
2-> USING ACCESSORS!{ get; } means it is read-only
You can read it, but you cannot change it from outside the class
e.g.
public string FirstName { get; }
*/
