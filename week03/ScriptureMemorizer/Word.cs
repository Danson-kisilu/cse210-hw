using System;

namespace ScriptureMemorizer
{
    
    /// Represents a single word in the scripture text.
    /// Encapsulates the word's text and hidden state.
    
    public class Word
    {
        private string _text;
        private bool _isHidden;

        public Word(string text)
        {
            _text = text;
            _isHidden = false;
        }

        public void Hide()
        {
            _isHidden = true;
        }

        public bool IsHidden()
        {
            return _isHidden;
        }

        public string GetDisplayText()
        {
            if (_isHidden)
            {
                // Replace each letter with underscore
                return new string('_', _text.Length);
            }
            return _text;
        }
    }
}