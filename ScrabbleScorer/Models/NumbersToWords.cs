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
      {0, ""},
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
      {0, "ten"},
      {1, "eleven"},
      {2, "twelve"},
      {3, "thirteen"},
      {4, "forteen"},
      {5, "fifteen"},
      {6, "sixteen"},
      {7, "seventeen"},
      {8, "eighteen"},
      {9, "nineteen"}
    };
    Dictionary<int, string> tens = new Dictionary<int, string>()
    {
      {0, ""},
      {2, "twenty"},
      {3, "thirty"},
      {4, "forty"},
      {5, "fifty"},
      {6, "sixty"},
      {7, "seventy"},
      {8, "eighty"},
      {9, "ninety"}
    };
    public string NumsToWordsFunc(string input) {
      char[] inputArray = input.ToCharArray();
      string[] words = new string [inputArray.Length];
      Array.Reverse(inputArray);
      string [] strings = Array.ConvertAll(inputArray, c => Convert.ToString(c));
      for (int i = 0; i < strings.Length; i++) {
        int number = int.Parse(strings[i]);
        switch(i) {
          case 0: 
            words[i] = ones[number];
            break;
          case 1:
            if (strings[i] == "1") {
              int prev = int.Parse(strings[i-1]);
              words[i] = teens[prev];
              words[i-1] = "";
            } else {
              words[i] = tens[number];
            }
            break;
          case 2:
            if (number != 0) {
              words[i] = ones[number] + " hundred";
            }
            break; 
          case 3:
            if (number != 0) {
              words[i] = ones[number] + " thousand";
            } else {
              words[i] = "thousand";
            }
            break; 
          case 4:
           if (strings[i] == "1") {
              int prev = int.Parse(strings[i-1]);
              words[i] = teens[prev] + " thousand";
              words[i-1] = "";
            } else {
              words[i] = tens[number];
            }
            break; 
          case 5:
            words[i] = ones[number] + " hundred";
            break; 
          default:
            break;   
        }
      }
      Array.Reverse(words);
      string word = String.Join(' ', words);
      return word;
    }
  }
}