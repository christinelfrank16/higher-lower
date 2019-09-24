using System;



class HigherLower {
 
public static int GenerateRandomNumbers(int min, int max) {
   Random rnd = new Random();
   int number = rnd.Next(min, max);
   return number;
}
public static int AskQuestions(int min, int max) {
    int randomNum = HigherLower.GenerateRandomNumbers(min, max);
    Console.WriteLine(randomNum);
    Console.WriteLine("Is this number is Higher or lower than the guessed number?");
    return randomNum;
}
}

class Program
{
  static void Main()
  {
    Console.WriteLine("Choose a number from 1 to 100?");
    Console.WriteLine("------");

    int max = 101;
    int min = 1;
    bool repeat = true;

    while (repeat) {
    int forQuestions = HigherLower.AskQuestions(min, max); 
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