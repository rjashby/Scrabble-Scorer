using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScorer.Models;

namespace ScrabbleScorer.Tests 
{
  [TestClass]
  public class CalculateTests
  {
    [TestMethod]
    public void FindScore_ConvertsLettersToScore_Score()
    {
      Calculate score = new Calculate();
      string word = "hotdog";
      Assert.AreEqual(17, score.FindScore(word));
    }
    
  }
}