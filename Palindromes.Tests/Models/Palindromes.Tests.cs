using System.Runtime.InteropServices;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindromes;

namespace Palindromes.Tests
{
  [TestClass]
  public class PalindromesTests
  {
    [TestMethod]
    public void StringToArray_StringToArray_array()
    {
      //testing code will go here
      Palindromes myPalindrome = new Palindromes("array");
      char[] array = new char[] {'a', 'r', 'r', 'a', 'y'};
      CollectionAssert.AreEqual(array, myPalindrome.StringToArray());

    }

    public void FlipTheArray_FlipsTheArray_yarra()
    {
      Palindromes myPalindrome = new Palindromes("array");
      char[] yarra = new char[] {'y', 'a', 'r', 'r', 'a'};
      CollectionAssert.AreEqual(yarra, myPalindrome.FlipTheArray());
    }

  }
}