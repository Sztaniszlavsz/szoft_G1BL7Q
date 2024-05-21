using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_v2
{
        public class Word
        {
            private readonly string wordToGuess;

            public string OriginalWord { get; private set; }
            public string WordMask { get; private set; }

            public Word(string wordToGuess)
            {
                this.wordToGuess = wordToGuess.ToUpper();
                this.OriginalWord = wordToGuess;
                this.WordMask = new string('_', wordToGuess.Length);
            }

            public bool Guess(char letter)
            {
                bool found = false;
                char upperLetter = char.ToUpper(letter);
                char[] tempWordMask = WordMask.ToCharArray();

                for (int i = 0; i < wordToGuess.Length; i++)
                {
                    if (wordToGuess[i] == upperLetter)
                    {
                        tempWordMask[i] = letter;
                        found = true;
                    }
                }

                WordMask = new string(tempWordMask);
                return found;
            }
        }
    }

