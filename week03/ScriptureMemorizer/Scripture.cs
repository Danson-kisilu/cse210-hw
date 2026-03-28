using System;
using System.Collections.Generic;
using System.Linq;

namespace ScriptureMemorizer
{
    
    /// Manages the scripture text and hiding functionality.
    /// Contains a reference and a list of Word objects.
    
    public class Scripture
    {
        private Reference _reference;
        private List<Word> _words;
        private Random _random;

        public Scripture(Reference reference, string text)
        {
            _reference = reference;
            _words = new List<Word>();
            _random = new Random();
            
            // Parse the text into individual words
            string[] wordArray = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string wordText in wordArray)
            {
                _words.Add(new Word(wordText));
            }
        }

        public void HideRandomWords(int count)
        {
            
            List<Word> visibleWords = _words.Where(w => !w.IsHidden()).ToList();
            
            // If no visible words left, return
            if (visibleWords.Count == 0)
                return;
            
            // Ensure we don't try to hide more than available
            int wordsToHide = Math.Min(count, visibleWords.Count);
            
            for (int i = 0; i < wordsToHide; i++)
            {
                int index = _random.Next(visibleWords.Count);
                visibleWords[index].Hide();
                
                // Remove the hidden word from the list so we don't select it again
                visibleWords.RemoveAt(index);
            }
        }

        public bool IsCompletelyHidden()
        {
            return _words.All(w => w.IsHidden());
        }

        public string GetDisplayText()
        {
            string referenceText = _reference.GetDisplayText();
            string wordsText = string.Join(" ", _words.Select(w => w.GetDisplayText()));
            return $"{referenceText}\n\n{wordsText}";
        }

        // Additional method to get progress information (exceeding requirements)
        public int GetVisibleWordCount()
        {
            return _words.Count(w => !w.IsHidden());
        }

        public int GetTotalWordCount()
        {
            return _words.Count;
        }
    }
}