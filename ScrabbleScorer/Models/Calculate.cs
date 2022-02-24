using System;
using System.Collections.Generic;
using System.Linq;

namespace ScrabbleScorer
{
  public class Calculate
  {
    public int Score { get; set; }

    public int FindScore(string input)
    {
      int score = 0;
      string input = "birthday";
      char[] letterArray = input.ToUpper().ToArray();
    //   foreach(char letter in letterArray)
    //   {
    //     if(letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U' || letter == 'L' || letter == 'N' || letter == 'R' || letter == 'S' || letter == 'T')
    //     {
    //       score += 1;
    //     }
    //     else if (letter == 'D' || letter == 'G') 
    //     {
    //       score += 2;
    //     } 
    //     else if (letter == 'B' || letter == 'C' || letter == 'M' || letter == 'P') 
    //     {
    //       score += 3;
    //     } 
    //     else if (letter == 'F' || letter == 'H' || letter == 'V' || letter == 'W' || letter == 'Y') 
    //     {
    //       score += 4;
    //     } 
    //     else if (letter == 'K' ) 
    //     {
    //       score += 5;
    //     } 
    //     else if (letter == 'J' || letter == 'X') 
    //     {
    //       score += 8;
    //     } 
    //     else if (letter == 'Q' || letter == 'Z') 
    //     {
    //       score += 10;
    //     }
    //   }
    // return score;
    }
  }
}