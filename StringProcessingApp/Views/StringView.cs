using System;
using StringProcessingApp.Services;

namespace StringProcessingApp.Views
{
    public class StringView
    {
        private readonly StringService _service;

        public StringView()
        {
            _service = new StringService();
        }

        public void Run()
        {
            bool running = true;

            while (running)
            {
                DisplayMenu();
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter text: ");
                        string text = Console.ReadLine();
                        _service.SetText(text);
                        break;

                    case "2":
                        Console.WriteLine("Current Text: " + _service.GetCurrentText());
                        break;

                    case "3":
                        Console.WriteLine("UPPERCASE: " + _service.ToUpperCase());
                        break;

                    case "4":
                        Console.WriteLine("lowercase: " + _service.ToLowerCase());
                        break;

                    case "5":
                        Console.WriteLine("Character Count: " + _service.CountCharacters());
                        break;

                    case "6":
                        Console.Write("Enter word to search: ");
                        string word = Console.ReadLine();
                        bool contains = _service.ContainsWord(word);
                        Console.WriteLine("Contains word? " + contains);
                        break;

                    case "7":
                        Console.Write("Enter word to replace: ");
                        string oldWord = Console.ReadLine();
                        Console.Write("Enter new word: ");
                        string newWord = Console.ReadLine();
                        Console.WriteLine("Updated Text: " + _service.ReplaceWord(oldWord, newWord));
                        break;

                    case "8":
                        Console.Write("Enter start index: ");
                        int start = int.Parse(Console.ReadLine());
                        Console.Write("Enter length: ");
                        int length = int.Parse(Console.ReadLine());
                        Console.WriteLine("Substring: " + _service.ExtractSubstring(start, length));
                        break;

                    case "9":
                        Console.WriteLine("Trimmed Text: " + _service.TrimSpaces());
                        break;

                    case "10":
                        _service.ResetText();
                        Console.WriteLine("Text has been reset.");
                        break;

                    case "11":
                        running = false;
                        Console.WriteLine("Exiting program...");
                        break;

                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }

                Console.WriteLine();
            }
        }

        private void DisplayMenu()
        {
            Console.WriteLine("===== String Processing System =====");
            Console.WriteLine("1. Enter Text");
            Console.WriteLine("2. View Current Text");
            Console.WriteLine("3. Convert to UPPERCASE");
            Console.WriteLine("4. Convert to lowercase");
            Console.WriteLine("5. Count Characters");
            Console.WriteLine("6. Check if Contains Word");
            Console.WriteLine("7. Replace Word");
            Console.WriteLine("8. Extract Substring");
            Console.WriteLine("9. Trim Spaces");
            Console.WriteLine("10. Reset Text");
            Console.WriteLine("11. Exit");
            Console.WriteLine("=====================================");
        }
    }
}
