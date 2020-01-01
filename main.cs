using System;

class MainClass {

  static void SayHi(){
    Console.WriteLine("Hello");
  }

  static int Double(int x){
    int result = x + x;
    return result;
  }

  static int Diff(int x, int y = 2){
    int result = x - y;
    return result;
  }

  static string NameAge(string name, int age){
    string result = $"{name} is {age} years old";
    return result;
  }

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

  public static void Main (string[] args) {
    Console.WriteLine ("Method");

  SayHi();

  Console.WriteLine(Double(3));

  Console.WriteLine(Diff(4, 1));
  Console.WriteLine(Diff(4));

  Console.WriteLine(NameAge("Bob", 5));

  Console.WriteLine(YourAge(6));
  Console.WriteLine(YourAge(6.6));
  Console.WriteLine(YourAge("six"));

  }
}