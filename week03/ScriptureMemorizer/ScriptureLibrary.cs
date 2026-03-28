using System;
using System.Collections.Generic;

namespace ScriptureMemorizer
{
    
    // Manages a library of scriptures for random selection.
    // This class exceeds requirements by adding a library feature.
   
    public class ScriptureLibrary
    {
        private List<(Reference reference, string text)> _scriptures;
        private Random _random;

        public ScriptureLibrary()
        {
            _scriptures = new List<(Reference, string)>();
            _random = new Random();
            InitializeLibrary();
        }

        private void InitializeLibrary()
        {
            // Add multiple scriptures to the library
            _scriptures.Add((
                new Reference("John", 3, 16),
                "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."
            ));
            
            _scriptures.Add((
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all your heart and lean not on your own understanding in all your ways submit to him and he will make your paths straight."
            ));
            
            _scriptures.Add((
                new Reference("Philippians", 4, 13),
                "I can do all things through Christ who strengthens me."
            ));
            
            _scriptures.Add((
                new Reference("Psalm", 23, 1),
                "The Lord is my shepherd I shall not want."
            ));
            
            _scriptures.Add((
                new Reference("Jeremiah", 29, 11),
                "For I know the plans I have for you declares the Lord plans to prosper you and not to harm you plans to give you hope and a future."
            ));
        }

        public Scripture GetRandomScripture()
        {
            int index = _random.Next(_scriptures.Count);
            var (reference, text) = _scriptures[index];
            return new Scripture(reference, text);
        }

        public int GetScriptureCount()
        {
            return _scriptures.Count;
        }
    }
}