
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
      Console.WriteLine(input + input.GetType());
      Palindromes myPalindromes = new Palindromes(input);
      Console.WriteLine(myPalindromes.MyString + " " + myPalindromes.GetType());
      string[] inputAsArray = input.Split();
      foreach (string element in inputAsArray){
        Console.WriteLine(element);
      }
    }

    public Palindromes(string input)
    {
      MyString = input;
    }

    public Array StringToArray()
    {
      string toConvert = MyString;
      string[] array = toConvert.Split("");
      return array;
    }

    // public Reverse(Array toReverse)
    // {
      
    // }
  }


}