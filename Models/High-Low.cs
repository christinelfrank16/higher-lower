using System;
namespace Game {
class HigherLower 
{
 private int _number; 
 public int GenerateRandomNumbers(int min, int max) {
   Random rnd = new Random();
    _number = rnd.Next(min, max);
   return _number;
}
public int AskQuestions(int min, int max) {
    int randomNum = GenerateRandomNumbers(min, max);
    Console.WriteLine(randomNum);
    Console.WriteLine("Is this number is Higher or lower than the guessed number?");
    return randomNum;
}
}

}
