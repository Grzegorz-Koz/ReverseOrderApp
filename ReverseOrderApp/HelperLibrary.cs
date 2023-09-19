using System.Text.RegularExpressions;

namespace ReverseOrderApp
{
        internal class HelperLibrary
        {            
            public string GetCharacter(string stringToReverse, int characterIndex)
            {                                
                Console.WriteLine($"Character {characterIndex}: ");
                string enteredValue = Console.ReadLine();
                while (enteredValue.Length != 1)
                {
                    Console.WriteLine("You entered more than 1 character. Try again:");
                    enteredValue = Console.ReadLine();
                }
                stringToReverse = stringToReverse + enteredValue;
                return stringToReverse;
            }

            public int NumberOfCharacters()
            {
                string inputValue = Console.ReadLine();
                bool correctValue = false;
                string errorInfo = ""; // = "" - Protection against using an unassigned variable in Console.WriteLine.                                
                int numberOfCharacters = 0; // Protection against "Compiler Error CS0177" 
                while (!correctValue)
                {
                    if (!Regex.IsMatch(inputValue, @"^[0-9]+$"))
                    {
                        errorInfo = "Entered value is not a number. Try once again:";
                    } 
                    else
                    {
                        numberOfCharacters = int.Parse(inputValue);
                        if (!(numberOfCharacters >= 2 && numberOfCharacters <= 10))
                        {
                            errorInfo = "Entered value is not in 2-10 range. Try once again:";

                        }
                        else
                        {
                            correctValue = true;
                        }
                    }
                    if (!correctValue)
                    {
                        Console.WriteLine($"{errorInfo}");
                        inputValue = Console.ReadLine();
                    }

                }
                return numberOfCharacters;
            }

            public string GetReversedText (string inputString)
            {
                char[] stringArray = inputString.ToCharArray();
                Array.Reverse(stringArray);
                string reversedStr = new string (stringArray);
                return reversedStr;
            }
        }
        

    
}