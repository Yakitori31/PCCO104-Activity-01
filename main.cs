using System;

class Program {
  public static void Main (string[] args) {
    string Firstname = "Andre";
    string Lastname = "Francisco";
    int Age = 20;
    string Address = "Mabolo, City of Malolos, Bulacan";
    Console.WriteLine ($"Hello World {Firstname} {Lastname} {Age} {Address}");
    Console.WriteLine ("Hello World" + " " + Firstname + " " + Lastname + " " + Age + " " + Address);;
  }
}