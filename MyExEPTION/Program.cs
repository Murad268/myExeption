using MyExEPTION;
using System;

class Program
{
    static void Main()
    {
        string[] programmingLanguages = { "C#", "Java", "Python", "JavaScript", "Ruby", "Swift", "PHP", "Go", "Kotlin" };

        Console.WriteLine("Here are some popular programming languages:");
        foreach (string language in programmingLanguages)
        {
            Console.WriteLine(language);
        }

        bool languageFound = false;

        while (!languageFound)
        {
            Console.WriteLine("\nWhat is the best programming language in the world?");
            string userInput = Console.ReadLine();

            foreach (string language in programmingLanguages)
            {
                if (userInput.Equals(language, StringComparison.OrdinalIgnoreCase))
                {
                    if (language == "PHP")
                    {
                        Console.WriteLine("You are the most amazing person for choosing PHP!");
                    }
                    else
                    {
                        throw new ProgrammingLanguageNotFoundException();
                    }
                    languageFound = true;
                    break;
                }
            }

            if (!languageFound)
            {
                Console.WriteLine($"The programming language '{userInput}' is not in the list. But surely, you were thinking of PHP. Please try again.");
            }
        }
    }
}
