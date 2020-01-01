using System;

class MainClass {

  // example of method without parameter
  static void SayHi(){
    Console.WriteLine("Hello");
  }

  //example of method with parameter
  static int Double(int x){
    int result = x + x;
    return result;
  }

  //example of multiple parameters and default value
  static int Diff(int x, int y = 2){
    int result = x - y;
    return result;
  }

  //example of different data type parameters
  static string NameAge(string name, int age){
    string result = $"{name} is {age} years old";
    return result;
  }

  // example of method overloading
  static string YourAge(int input){
    string result = $"You're {input} years old.";
    return result;
  }

  static string YourAge(double input){
    string result = $"You're {input} years old.";
    return result;
  }

  static string YourAge(string input){
    string result = $"You're {input} years old.";
    return result;
  }
  // -------------end of method overloading------------

  public static void Main (string[] args) {
    Console.WriteLine ("Method");

  //basic method
  SayHi();

  //to skip a line for better viewing experience in terminal
  Console.WriteLine(" ");

  // method with one parameter
  Console.WriteLine(Double(3));

  Console.WriteLine(" ");

  // method with multiple parameter, default parameter and named arguments
  Console.WriteLine(Diff(4, 1));
  Console.WriteLine(Diff(4));
  Console.WriteLine(Diff(y:4, x:8));

  Console.WriteLine(" ");

  //method with different data type parameters
  Console.WriteLine(NameAge("Bob", 5));

  Console.WriteLine(" ");

  //method overloading
  Console.WriteLine(YourAge(6));
  Console.WriteLine(YourAge(6.6));
  Console.WriteLine(YourAge("six"));

  }
}