using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ScrabbleScorer.Models
{
  public class NumsToWords
  {
    Dictionary<int, string> ones = new Dictionary<int, string>()
    {
      {1, "one"},
      {2, "two"},
      {3, "three"},
      {4, "four"},
      {5, "five"},
      {6, "six"},
      {7, "seven"},
      {8, "eight"},
      {9, "nine"}
    };

    Dictionary<int, string> teens = new Dictionary<int, string>()
    {
      {10, "ten"},
      {11, "eleven"},
      {12, "twelve"},
      {13, "thirteen"},
      {14, "forteen"},
      {15, "fifteen"},
      {16, "sixteen"},
      {17, "seventeen"},
      {18, "eighteen"},
      {19, "nineteen"}
    };
    Dictionary<int, string> tens = new Dictionary<int, string>()
    {
      {2, "twenty"},
      {3, "thirty"},
      {4, "forty"},
      {5, "fifty"},
      {6, "sixty"},
      {7, "seventy"},
      {8, "eighty"},
      {9, "ninety"}
    };
    public string NumsToWordsFunc(int input) {
      int[] inputArray = input.ToArray();
      int number= int.Parse([i]);
    }
  }
}