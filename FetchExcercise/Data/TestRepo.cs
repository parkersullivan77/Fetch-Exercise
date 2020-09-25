using System;
using System.Collections.Generic;
using System.Linq;
using FetchExcercise.Modles;

namespace FetchExcercise.Data
{
    public class TestRepo : IPyramidRepo
    {
        private readonly  HashSet<int> _lenghts =new HashSet<int>();
        private Dictionary<int, int> correctLengths = new Dictionary<int, int> 
        { { 6, 3 }, { 10, 4 }, { 15, 5 }, { 21, 6 }, { 28, 7 }, { 36, 8 }, { 45, 9 }, { 55, 10 } };

        public Pyramid isPyramidWord(string word)
        {
        var p = new Pyramid{isPyramid =false};
         if (string.IsNullOrEmpty(word))
        return p;

    if (correctLengths.Keys.Contains(word.Length))
    {
        var lowerCaseWord = word.ToLower();
        var maxLetterFrequency = correctLengths[lowerCaseWord.Length];                 
        var distinctLetters = lowerCaseWord.Distinct();
        if (distinctLetters.Count() != maxLetterFrequency) // cheap check
            return p;  
        HashSet<int> letterCounts = new HashSet<int>();  // lookup on HashSet is a little faster
        // Adds up how many times each distinct letter is seen in the word
        foreach (var letter in distinctLetters)
        {
            var numLetters = lowerCaseWord.Count(x => x == letter);
            letterCounts.Add(numLetters);
        }
        for (var i = maxLetterFrequency; i >= 1; i--)
        {
            if (!letterCounts.Contains(i)) return p;
        }
        p.isPyramid = true;
        return p;
    }
    else
        return p;          
}
        }
    }
