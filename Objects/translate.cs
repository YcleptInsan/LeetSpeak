using System.Collections.Generic;
using System;
namespace LeetSpeak
{
  public class Translate
  {
    private string _userInput;

    public Translate(string userInput)
    {
      _userInput = userInput;

    }

    public string GetuserInput()
    {
      return _userInput;
    }

    public string translator(string sentence)
    {
      List<char> CharList = new List<char>();
      char[] letters = sentence.ToCharArray();
      foreach(char letter in letters){
        CharList.Add(letter);
      }
      Console.WriteLine("3.5 " + CharList[0]);
      char[] string_letters = CharList.ToArray();
      Console.WriteLine("4 " + string_letters[1]);
      //new list to store the converted letters
      List<char> LetterList = new List<char>();
      Console.WriteLine("5 " + string_letters.Length);
      for(int i = 0 ; i < string_letters.Length; i++)
      {

         if (string_letters[i] == 'e' || string_letters[i] == 'E')
          {
            LetterList.Add('3');
            Console.WriteLine(LetterList[0]);
          }
          else if(string_letters[i] == 'o' || string_letters[i] =='O')
          {
            LetterList.Add('0');
          }
          else if(string_letters[i] == 'I')
          {
            LetterList.Add('1');
          }
          else if(string_letters[i] == 't' || string_letters[i] == 'T')
          {
            LetterList.Add('7');
          }
          else if((string_letters[i] == 'S' || string_letters[i] == 's') && i != 0 && (Char.IsLetter(string_letters[i-1]) || Char.IsDigit(string_letters[i-1])))
          {
            if(string_letters[i] == 's')
            {
              LetterList.Add('z');
              Console.WriteLine(LetterList[0]);
            }
            else if(string_letters[i] == 'S')
            {
              LetterList.Add('Z');
            }
          }
          else
          {
            LetterList.Add(string_letters[i]);
          }
        }

      char[] LetterArray = LetterList.ToArray();
      string output_sentence = string.Join("", LetterArray);
      Console.WriteLine("6,output " + output_sentence);
      return output_sentence;
    }

  }
}
