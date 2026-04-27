

do
{
    Console.WriteLine("Please enter a word:");
    string? userInput =Console.ReadLine();
    
    if (userInput != null)
    {
        if (IsAPalindrome(userInput))
        {
            Console.WriteLine($"{userInput} is a palindrome!");
        }
        else
        {
            Console.WriteLine($"{userInput} is not a palindrome.");
        }
    }

} while (true);


static bool IsAPalindrome(string input)
{
    for(int i = 0; i < input.Length / 2; i++)
    {
        if (input[i] != input[input.Length - 1 - i])
        {
            return false;
        }
    }
    return true;
}