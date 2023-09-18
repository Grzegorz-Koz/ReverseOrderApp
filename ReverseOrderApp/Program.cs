namespace ReverseOrderApp
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to ReverseOrderApp!");
            Console.WriteLine("\r");
            
            Console.WriteLine("Please enter the number of characters you want to display in reverse order (2-10 characters):");

            HelperLibrary hlp = new HelperLibrary();
            int numberOfCharacters = hlp.NumberOfCharacters();
            
            Console.WriteLine("\r");
            Console.WriteLine("Please enter your characters!");

            // string.Empty - Necessary in order to be able to concatenate a string with the character entered by the user.
            string stringToReverse = string.Empty;
            for (int i = 1; i <= numberOfCharacters; i++)
            {
                stringToReverse = hlp.CreateStringToReverse(stringToReverse, i);
            }
            Console.WriteLine("\r");
            Console.WriteLine($"Your text: {stringToReverse}");
            Console.WriteLine($"Your reversed text: {hlp.GetReversedText(stringToReverse)}");            
        }        
    }
}