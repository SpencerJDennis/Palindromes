
using System.Reflection.Metadata.Ecma335;
using System.Reflection.Metadata;
using System.IO;
using System.Security.AccessControl;
using System.Collections.Generic;
using System.Buffers;
using System.Collections;
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
using System.Linq;

namespace Palindromes
{
  public class Palindromes
  {

    public string MyString{ get; set; }

    public static void Main()
    {
      Console.WriteLine("Please input a word:");
      string input = Console.ReadLine();
      Palindromes myPalindromes = new Palindromes(input.ToLower());
      char[] myPalindromeArray = myPalindromes.StringToArray();
      List<char> flipped = Palindromes.FlipTheArray(myPalindromeArray);
      for(int i=0;i<flipped.Count;i++)
      {
        Console.WriteLine(flipped[i]);
      }
      bool result = myPalindromes.IsPalindrome(myPalindromeArray);
      Console.WriteLine(result);
    }

    public Palindromes(string input)
    {
      MyString = input.ToLower();
    }

  //get rid of
    public char[] StringToArray()
    {
      string toConvert = MyString;
      char[] array = toConvert.ToCharArray();
      return array;
    }

    public static List<char> FlipTheArray( char[] array)
    {
      // char[] arrayFlip = new char[array.Length];
      // arrayFlip = array;
      List<char> arrayList = array.ToList();
      List<char> flippedList = new List<char>();
      for (int i = array.Length -1; i >= 0; --i)
      {
        // toAdd = arrayp[i];
        // flippedList.Add(toAdd);
        flippedList.Add(arrayList[i]);
      }
      return flippedList;
    }

    public bool IsPalindrome( char[] array)
    {
      List<char> arrayList = array.ToList();
      List<char> flipped = Palindromes.FlipTheArray(array);

      for(int i=0;i<arrayList.Count;i++)
      {
        Console.WriteLine(arrayList[i]);
      }
      for(int i=0;i<flipped.Count;i++)
      {
        Console.WriteLine(flipped[i]);
      }

      return arrayList.SequenceEqual(flipped);
    }
  }
}




