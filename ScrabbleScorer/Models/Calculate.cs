using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ScrabbleScorer.Models
{
  public class Calculate
  {
    public int FindScore(string input)
    {
      int score = 0;
      char[] letterArray = input.ToUpper().ToArray();
      foreach(char letter in letterArray)
      {
        if(letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U' || letter == 'L' || letter == 'N' || letter == 'R' || letter == 'S' || letter == 'T')
        {
          score += 1;
        }
        else if (letter == 'D' || letter == 'G') 
        {
          score += 2;
        } 
        else if (letter == 'B' || letter == 'C' || letter == 'M' || letter == 'P') 
        {
          score += 3;
        } 
        else if (letter == 'F' || letter == 'H' || letter == 'V' || letter == 'W' || letter == 'Y') 
        {
          score += 4;
        } 
        else if (letter == 'K' ) 
        {
          score += 5;
        } 
        else if (letter == 'J' || letter == 'X') 
        {
          score += 8;
        } 
        else if (letter == 'Q' || letter == 'Z') 
        {
          score += 10;
        }
      }
    return score;
    }

    public string[] GetArray(string input)
    {
      string[] array = new string[1] { input };
      return array;
    }

    public int CheckScore(string input)
    {
      int OnePointSquares = Regex.Matches(input, "[aeioulnrst]", RegexOptions.IgnoreCase).Count;
      int TwoPointSquares = Regex.Matches(input, "[dg]", RegexOptions.IgnoreCase).Count * 2;
      int ThreePointSquares =  Regex.Matches(input, "[bcmp]", RegexOptions.IgnoreCase).Count * 3;
      int FourPointSquares =  Regex.Matches(input, "[fhvwy]", RegexOptions.IgnoreCase).Count * 4;
      int FivePointSquares =  Regex.Matches(input, "[k]", RegexOptions.IgnoreCase).Count * 5;
      int EightPointSquares =  Regex.Matches(input, "[jx]", RegexOptions.IgnoreCase).Count * 8;
      int TenPointSquares =  Regex.Matches(input, "[qz]", RegexOptions.IgnoreCase).Count * 10;
      int TotalPoints = OnePointSquares + TwoPointSquares + ThreePointSquares + FourPointSquares + FivePointSquares + EightPointSquares + TenPointSquares;
      return TotalPoints;
    }
  }
}
