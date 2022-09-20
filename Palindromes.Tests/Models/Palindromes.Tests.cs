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
      char[] array = new char[] {'a', 'r', 'r', 'a', 'y'};
      CollectionAssert.AreEqual(myPalindrome.StringToArray(), array);
    }
  }
}