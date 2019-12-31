using System;

class MainClass {

  static void SayHi(){
    Console.WriteLine("Hello");
  }

  static int Sum(int x){
    int result = x + x;
    return result;
  }

  public static void Main (string[] args) {
    Console.WriteLine ("Method");

  SayHi();

  Console.WriteLine(Sum(3));

  }
}