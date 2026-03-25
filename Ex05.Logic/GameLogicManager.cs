using System;
using System.Collections.Generic;
using System.Linq;

namespace MastermindGame.Logic
{
    public class GameLogicManager
    {
        public const int k_SecretCodeLength = 4;
        public const int k_MaxSecretCodeLength = 10;
        private List<Guess> m_SecretCodeByComputer;
        private static readonly Random sr_RandomGenerator = new Random();
        public int m_NumberOfGuessesFromUser;
        private int m_CurrentAttemptCount = 0;
        public int CurrentAttemptCount => m_CurrentAttemptCount;

        public List<Guess> SecretCode
        {
            get { return m_SecretCodeByComputer; }
        }

        public int MaxNumberOfGuesses
        {
            get { return m_NumberOfGuessesFromUser; }
        }

        public GameLogicManager()
        {
            m_NumberOfGuessesFromUser = k_SecretCodeLength;
            m_SecretCodeByComputer = generateTheGuessingSecretCode();
        }

        private List<Guess> generateTheGuessingSecretCode()
        {
            List<Guess> generatedSecretCode = new List<Guess>();
            Random randomGenerator = new Random();
            List<eGuessSymbol> guessSymbolOptions = new List<eGuessSymbol>(Enum.GetValues(typeof(eGuessSymbol)) as eGuessSymbol[]);

            for (int i = 0; i < k_SecretCodeLength; i++)
            {
                int randomIndex = sr_RandomGenerator.Next(guessSymbolOptions.Count);

                generatedSecretCode.Add(new Guess(guessSymbolOptions[randomIndex]));
                guessSymbolOptions.RemoveAt(randomIndex);
            }

            return generatedSecretCode;
        }

        public void CompareGuessToSecretCode(List<Guess> i_UserGuess, out int o_NumberOfExactMatch, out int o_NumberOfPartialMatch)
        {
            int numberOfExactMatch = 0;
            int numberOfPartialMatch = 0;
            List<eFeedbackSymbol> feedback = new List<eFeedbackSymbol>();

            for (int i = 0; i < k_SecretCodeLength; i++)
            {
                if (i_UserGuess[i].IsExactMatch(m_SecretCodeByComputer[i]))
                {
                    feedback.Add(eFeedbackSymbol.ExactMatch);
                    numberOfExactMatch++;
                }
                else
                {
                    bool isSymbolExistsElsewhere = false;

                    for (int j = 0; j < k_SecretCodeLength; j++)
                    {
                        if (i != j && i_UserGuess[i].GuessSymbol == m_SecretCodeByComputer[j].GuessSymbol)
                        {
                            isSymbolExistsElsewhere = true;
                            break;
                        }
                    }

                    if (isSymbolExistsElsewhere)
                    {
                        feedback.Add(eFeedbackSymbol.PartialMatch);
                        numberOfPartialMatch++;
                    }
                }
            }

            o_NumberOfExactMatch = numberOfExactMatch;
            o_NumberOfPartialMatch = numberOfPartialMatch;
        }

        public bool IsWinningFeedback(int i_ExactMatches)
        {
            return i_ExactMatches == k_SecretCodeLength;
        }

        public void ValidateChosenColor(List<Guess> i_CurrentGuess, eGuessSymbol i_NewSymbol)
        {
            if (Guess.ContainsSymbol(i_CurrentGuess, i_NewSymbol))
            {
                throw new InputValidation(i_NewSymbol);
            }
        }

        public bool IsGuessComplete(List<Guess> i_TotalGuess)
        {
            return i_TotalGuess.Count == k_SecretCodeLength;
        }

        public void ResetGame()
        {
            m_SecretCodeByComputer.Clear();
            m_SecretCodeByComputer.AddRange(generateTheGuessingSecretCode());
        }

        public static bool IsValidGuessCount(int i_GuessCount)
        {
            return i_GuessCount >= k_SecretCodeLength && i_GuessCount <= k_MaxSecretCodeLength;
        }

        public void IncrementAttemptCount()
        {
            m_CurrentAttemptCount++;
        }

        public bool AreGuessesOver()
        {
            return m_CurrentAttemptCount >= m_NumberOfGuessesFromUser;
        }
    }
}
