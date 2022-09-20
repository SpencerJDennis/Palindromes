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
    public void StringToArray_StringToArray_Array()
    {
      //testing code will go here
      Palindromes myPalindrome = new Palindromes("array");
      string[] array = new string[] {"a", "r", "r", "a", "y"};
      Assert.AreEqual(myPalindrome.StringToArray(), array);
    }
  }
}