using System.Collections.Generic;

namespace LeetSpeak
{
  public class Translate
  {
    private string _userInput;
    public translate(string userInput)
    {
      _userInput = userInput;
    }

    public string GetuserInput()
    {
      return _userInput;
    }

    public void translator(userInput)
    {
      char[] letters = userInput.ToCharArray();
      string[] result = new string [];
      for(i = 0 ; i < letters.Length; i++){
        if(letters[i-1] == " ")
        {
          if(letters[i] == "s")
          {
            result.Add("s")
          }
          else if(letters[i] == "S")
          {
            result.Add("S")
          }
        }
        else if(letters[i] == "s")
        {
          result.Add("z");
        }
        else if(letters[i] == "S")
        {
          result.Add("Z");
        }
        else if (letters[i] == "e" || letters[i] == "E")
        {
          result.Add("3");
        }
        else if(letters[i] == "o" || letters[i] =="O")
        {
          result.Add("0");
        }
        else if(letters[i] == "I")
        {
          result.Add("1");
        }
        else if(letters[i] == "t" || letters[i] == "T")
        {
          result.Add("7");
        }
        else{
          result.add(letters[i]);
        }
      }
      string output_sentence = string.Join("", result);
      return output_sentence;
    }

  }
}
