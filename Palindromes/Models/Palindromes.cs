

using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Collections.Concurrent;
using System.Runtime.Serialization;
using System.Reflection.Emit;
using System.Data;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace Palindromes
{
  public class Palindromes
  {

    public string MyString{get; set;}

    public static void Main()
    {
      Console.WriteLine("Please input a word:");
      string input = Console.ReadLine();
      Palindromes myPalindromes = new Palindromes(input);

    }

    public Palindromes(string input)
    {
      MyString = input;
    }

  //get rid of
    public Array StringToArray()
    {
      string toConvert = MyString;
      char[] array = toConvert.ToCharArray();
      return array;
    }

    // public Reverse(Array toReverse)
    // {
      
    // }
  }


}