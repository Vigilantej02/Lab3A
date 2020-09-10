using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Please enter a temperature in celsius");
    var celsius = Console.ReadLine();
    int cel1 = Convert.ToInt32(celsius);
    var farenheit = (cel1*9/5) + 32;
    int f1 = Convert.ToInt32(farenheit);
    Console.WriteLine ("Your temperature in Farenheit is " + f1);
    if (f1 <= 32){
      Console.WriteLine("This temperature is below freezing of 32 degree Farenheit");
    }
    if (f1 >= 212){
      Console.WriteLine("This temperature is above boiling point of 212 degree Farenheit");
    }
  }
}