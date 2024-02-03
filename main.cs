using System;

class Program {
  public static void Main (string[] args) {
    string Firstname = "Andre James";
    string Lastname = "Francisco";
    int Age = 20;
    string Address = "Mabolo, City of Malolos, Bulacan";
    string Course = "Bachelor of Science in Information Technology";
    Console.WriteLine ($"Hello World {Firstname} {Lastname} {Age} {Address} {Course}");
    Console.WriteLine ("Hello World" + " I am " + Firstname + " " + Lastname + " My age is " + Age + " My Address is " + Address + " My Course in college is " + Course);
  }
}