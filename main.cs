using System;

class MainClass {
  public static void Main (string[] args) {
    string answer = "no";
    int counter = 0;
    do
    {
      Console.WriteLine("Is there another customer to calculate? (lowercase)");
      answer = Console.ReadLine();
      counter++;
      CalculateCharges();
    }
    while (answer != "no");
  }
  public static void CalculateCharges () 
  {
    Console.WriteLine("How many hours was the customer parked at the garage.");
    int hours = Convert.ToInt32(Console.ReadLine());
    double total = (hours * 0.50) + .50;

    if(total < 2.00)
    {
      total = 2.00;
      Console.WriteLine("The custormer's fee is $" + total +".");
    }
    else
    {
      if (total > 10)
      {total = 10.00;}
      Console.WriteLine("The custormer's fee is $" + total +".");
    }
  }
}