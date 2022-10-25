using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTasks
{
   
    public class Palindrome
    {
       

        static public string palindromeCheck(string palindromeInput)
        {
            string input = palindromeInput.ToUpper();// convert to uppercase

            int length = input.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (input[i] != input[length - i - 1])
                    return "Is not palindrome";



            }
            return "Is palindrome";
        }
    }

}
