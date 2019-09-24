using System;
using Game;
class Program
{
  static void Main()
  {
    Console.WriteLine("Choose a number from 1 to 100?");
    Console.WriteLine("------");

    int max = 101;
    int min = 1;
    bool repeat = true;
    HigherLower newInstance = new HigherLower();
    while (repeat) {
    int forQuestions = newInstance.AskQuestions(min, max); 
    string inputedNumber = Console.ReadLine(); 
    
    if (inputedNumber.ToLower() == "higher" ) {
       max = forQuestions;

    } else if (inputedNumber.ToLower() == "lower") {
       min = forQuestions+1;
    } else {
       Console.WriteLine("you win"); 
       repeat = false;
    }
  }
  }



}