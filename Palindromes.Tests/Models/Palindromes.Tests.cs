using System.Runtime;
using System.Runtime.InteropServices;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindromes;
using System.Collections.Generic;
using System.Collections;
using System;
using System.Linq;

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
    [TestMethod]  
    public void FlipTheArray_FlipsTheArray_yarra()
    {
      Palindromes myPalindrome = new Palindromes("array");
      List<char> yarra = new List<char>(){'y','a', 'r', 'r', 'a'};
      char[] myPalindromeArray = myPalindrome.StringToArray();
      CollectionAssert.AreEqual(yarra, Palindromes.FlipTheArray(ref myPalindromeArray));
    }
    [TestMethod]
    public void IsPalindrome_ChecksIfPalindrome_TRUE()
    {
      Palindromes myPalindrome = new Palindromes("raceCar");
      char[] myPalindromeArray = myPalindrome.StringToArray();
      Assert.AreEqual(true, myPalindrome.IsPalindrome(ref myPalindromeArray));
    }
    
    [TestMethod]
    public void IsPalindrome_ChecksIfPalindrom_FALSE()
    {
      Palindromes myPalindrome = new Palindromes("supercalifragilisticexpialidocious");
      char[] myPalindromeArray = myPalindrome.StringToArray();
      Assert.AreEqual(false, myPalindrome.IsPalindrome(ref myPalindromeArray));
    }
  }
}