using System;

namespace MastermindGame.Logic
{
    public class InputValidation : Exception
    {
        public InputValidation(eGuessSymbol symbol) : base($"Color '{symbol}' is already selected in this guess.") { }
    }
}
