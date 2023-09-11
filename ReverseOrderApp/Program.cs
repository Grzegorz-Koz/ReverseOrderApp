using System.Text.RegularExpressions;

namespace ReverseOrderApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ReverseOrderApp!");
            Console.WriteLine("\r");
            
            Console.WriteLine("Please enter the number of characters you want to display in reverse order (2-10 characters):");
            HelperLibrary hlp = new HelperLibrary();
            int numberOfCharacters;
            hlp.numberOfCharacters(out numberOfCharacters);

            Console.WriteLine("\r");
            Console.WriteLine("Please enter your characters!");
            
            // = "" - Necessary in order to be able to concatenate a string with the character entered by the user.
            string stringToReverse = "";
            for (int i = 1; i <= numberOfCharacters; i++)
            {
                stringToReverse = hlp.createStringToReverse(stringToReverse, i);
            }
            Console.WriteLine("\r");
            Console.WriteLine($"Your text: {stringToReverse}");
            Console.WriteLine($"Your reversed text: {hlp.getReversedText(stringToReverse)}");
            

        }

        internal class HelperLibrary
        {            
            public string getCharacter(string valueToCheck)
            {
                string properValue = valueToCheck;
                bool properLength;
                while (properValue.Length != 1)
                {
                    properLength = false;
                    Console.WriteLine("You entered more than 1 character. Try again:");
                    properValue = Console.ReadLine();
                }
                properLength = true;
                if (properLength)
                {
                    return properValue;
                }
                return properValue;
            }

            public string createStringToReverse (string stringToReverse, int characterIndex)
            {                
                char myCharacter;
                Console.WriteLine($"Character {characterIndex}: ");
                string enteredValue = Console.ReadLine();
                myCharacter = Convert.ToChar(getCharacter(enteredValue));
                stringToReverse = stringToReverse + myCharacter;
                return stringToReverse;
            }

            public void numberOfCharacters(out int numberOfCharacters)
            {
                string inputValue = Console.ReadLine();
                bool correctValue = false;
                string errorInfo = ""; // = "" - Protection against using an unassigned variable in Console.WriteLine.                                
                numberOfCharacters = 0; // Protection against "Compiler Error CS0177" 
                while (!correctValue)
                {
                    if (!Regex.IsMatch(inputValue, @"^[0-9]+$"))
                    {
                        errorInfo = "Entered value is not a number. Try once again:";
                    } 
                    else
                    {
                        numberOfCharacters = Convert.ToInt32(inputValue);
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
            }

            public string getReversedText (string inputString)
            {
                char[] stringArray = inputString.ToCharArray();
                Array.Reverse(stringArray);
                string reversedStr = new string (stringArray);
                return reversedStr;
            }
        }
        

    }
}