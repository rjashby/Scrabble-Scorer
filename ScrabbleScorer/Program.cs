using System;
using ScrabbleScorer.Models;

namespace NumbersToWords
{
  public class Program
  {
    
    public static void Main()
    {
      string input = "440000";
      NumsToWords nums = new NumsToWords();
      Console.Write(nums.NumsToWordsFunc(input));
    }
  }
}