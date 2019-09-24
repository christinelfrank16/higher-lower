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
    
    if (inputedNumber == "Higher" ) {
       max = forQuestions;

    } else if (inputedNumber == "Lower") {
       min = forQuestions;
    } else {
       Console.WriteLine("you win"); 
       repeat = false;
    }
  }
  }



}