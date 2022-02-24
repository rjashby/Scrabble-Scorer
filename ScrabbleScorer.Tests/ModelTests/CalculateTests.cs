using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScorer.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ScrabbleScorer.Tests 
{
  [TestClass]
  public class CalculateTests
  {
    [TestMethod]
    public void FindScore_ConvertsLettersToScore_Score()
    {
      Calculate score = new Calculate();
      string word = "birthday";
      Assert.AreEqual(17, score.FindScore(word));
    }
    

    [TestMethod]
    public void GetArray_ConvertWordToArray_Array()
    {
      Calculate score = new Calculate();
      string input = "four";
      string[] test = score.GetArray(input);
      string[] against = new string[1] { input };

      // Are the types the same?
      Assert.IsInstanceOfType(score.GetArray(input), typeof(string[]));

      // Are the arrays equal?
      CollectionAssert.AreEqual(test, against);
    }
  }
}