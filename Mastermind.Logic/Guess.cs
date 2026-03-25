using System.Collections.Generic;
using System.Linq;

namespace MastermindGame.Logic
{
    public class Guess
    {
        public eGuessSymbol GuessSymbol { get; }

        public Guess(eGuessSymbol i_Symbol)
        {
            GuessSymbol = i_Symbol;
        }

        public bool IsExactMatch(Guess other)
        {
            return this.GuessSymbol == other.GuessSymbol;
        }

        public static bool ContainsSymbol(List<Guess> guesses, eGuessSymbol symbol)
        {
            return guesses.Any(g => g.GuessSymbol == symbol);
        }
    }
}
