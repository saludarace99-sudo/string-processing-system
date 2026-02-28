using System;

namespace StringProcessingApp.Services
{
    public class StringService
    {
        private string _originalText = "";
        private string _currentText = "";

        public void SetText(string text)
        {
            _originalText = text;
            _currentText = text;
        }

        public string GetCurrentText()
        {
            return _currentText;
        }

        public string ToUpperCase()
        {
            _currentText = _currentText.ToUpper();
            return _currentText;
        }

        public string ToLowerCase()
        {
            _currentText = _currentText.ToLower();
            return _currentText;
        }

        public int CountCharacters()
        {
            return _currentText.Length;
        }

        public bool ContainsWord(string word)
        {
            return _currentText.Contains(word);
        }

        public string ReplaceWord(string oldWord, string newWord)
        {
            _currentText = _currentText.Replace(oldWord, newWord);
            return _currentText;
        }

        public string ExtractSubstring(int startIndex, int length)
        {
            if (startIndex >= 0 && startIndex + length <= _currentText.Length)
            {
                return _currentText.Substring(startIndex, length);
            }
            return "Invalid substring range.";
        }

        public string TrimSpaces()
        {
            _currentText = _currentText.Trim();
            return _currentText;
        }

        public void ResetText()
        {
            _currentText = _originalText;
        }
    }
}
