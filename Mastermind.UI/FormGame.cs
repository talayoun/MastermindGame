using MastermindGame.Logic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MastermindGame.UI
{
    public partial class FormGame : Form
    {
        private int m_NumberOfChances = GameLogicManager.k_SecretCodeLength;
        private int m_CurrentRowIndex = 0;
        private List<List<Button>> m_GuessButtons = new List<List<Button>>();
        private List<Button> m_CompareButtons = new List<Button>();
        private List<List<Button>> m_ResultButtons = new List<List<Button>>();
        private List<Guess> m_CurrentGuess = new List<Guess>();
        private List<Button> m_SecretCodeButtons = new List<Button>();
        private GameLogicManager m_GameLogicManager = new GameLogicManager();

        public FormGame(int i_NuberOfChances)
        {
            m_NumberOfChances = i_NuberOfChances;
            InitializeComponent();
        }

        private void FormGame_Load(object sender, EventArgs e)
        {
            createSecretCodeButtons();
            for (int i = 0; i < m_NumberOfChances; i++)
            {
                createEmptyGuessRow(i);
            }

            int topMargin = 100;
            int rowHeight = 72;
            int bottomPadding = 20;
            int neededHeight = topMargin + m_NumberOfChances * rowHeight + bottomPadding;

            this.ClientSize = new Size(this.ClientSize.Width, neededHeight);
            enableCurrentRow();
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            PickingColorForm pickingColorForm = new PickingColorForm();

            if (pickingColorForm.ShowDialog() == DialogResult.OK)
            {
                eGuessSymbol selectedSymbol = pickingColorForm.SelectedSymbol;

                if (clickedButton.Tag is eGuessSymbol previousSymbol)
                {
                    m_CurrentGuess.RemoveAll(guess => guess.GuessSymbol == previousSymbol);
                }

                try
                {
                    m_GameLogicManager.ValidateChosenColor(m_CurrentGuess, selectedSymbol);
                    clickedButton.BackColor = convertSymbolToColor(selectedSymbol);
                    clickedButton.Tag = selectedSymbol;
                    m_CurrentGuess.Add(new Guess(selectedSymbol));
                    if (m_GameLogicManager.IsGuessComplete(m_CurrentGuess))
                    {
                        m_CompareButtons[m_CurrentRowIndex].Enabled = true;
                    }
                }
                catch (InputValidation ex)
                {
                    MessageBox.Show(ex.Message, "Duplicate Color", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private Color convertSymbolToColor(eGuessSymbol i_ChosenSymbol)
        {
            Color colorResult;

            switch (i_ChosenSymbol)
            {
                case eGuessSymbol.Purple:
                    colorResult = Color.MediumPurple;
                    break;
                case eGuessSymbol.Red:
                    colorResult = Color.Red;
                    break;
                case eGuessSymbol.Green:
                    colorResult = Color.LightGreen;
                    break;
                case eGuessSymbol.LightBlue:
                    colorResult = Color.PowderBlue;
                    break;
                case eGuessSymbol.DarkBlue:
                    colorResult = Color.CornflowerBlue;
                    break;
                case eGuessSymbol.Yellow:
                    colorResult = Color.Khaki;
                    break;
                case eGuessSymbol.Brown:
                    colorResult = Color.Peru;
                    break;
                case eGuessSymbol.White:
                    colorResult = Color.White;
                    break;
                default:
                    colorResult = Color.Beige;
                    break;
            }

            return colorResult;
        }

        private void compareButton_Click(object sender, EventArgs e)
        {
            foreach (Button button in m_GuessButtons[m_CurrentRowIndex])
            {
                button.Enabled = false;
                button.Click -= guessButton_Click;
            }

            m_CompareButtons[m_CurrentRowIndex].Enabled = false;
            m_GameLogicManager.CompareGuessToSecretCode(m_CurrentGuess, out int numberOfExactMatch, out int numberOfPartialMatch);
            m_GameLogicManager.IncrementAttemptCount();
            diaplayFeddback(numberOfExactMatch, numberOfPartialMatch);
            m_CurrentRowIndex++;
            if (!m_GameLogicManager.AreGuessesOver())
            {
                m_CurrentGuess.Clear();
                enableCurrentRow();
            }
            else
            {
                revealSecretCode();
            }
        }

        private void diaplayFeddback(int i_NumberOfExactMatch, int i_NumberOfPartialMatch)
        {
            for (int i = 0; i < i_NumberOfExactMatch; i++)
            {
                m_ResultButtons[m_CurrentRowIndex][i].BackColor = Color.Black;
            }

            for (int i = i_NumberOfExactMatch; i < i_NumberOfExactMatch + i_NumberOfPartialMatch; i++)
            {
                m_ResultButtons[m_CurrentRowIndex][i].BackColor = Color.Yellow;
            }

            if (m_GameLogicManager.IsWinningFeedback(i_NumberOfExactMatch))
            {
                revealSecretCode();
                MessageBox.Show("Good Job! You Won!", "Win", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
        }

        private void revealSecretCode()
        {
            for (int i = 0; i < GameLogicManager.k_SecretCodeLength; i++)
            {
                m_SecretCodeButtons[i].BackColor = convertSymbolToColor(m_GameLogicManager.SecretCode[i].GuessSymbol);
            }
        }

        private void enableCurrentRow()
        {
            foreach (Button button in m_GuessButtons[m_CurrentRowIndex])
            {
                button.Enabled = true;
                button.Click += guessButton_Click;
            }
        }

        private void createSecretCodeButtons()
        {
            m_SecretCodeButtons.Add(secretCodeButton1);
            m_SecretCodeButtons.Add(secretCodeButton2);
            m_SecretCodeButtons.Add(secretCodeButton3);
            m_SecretCodeButtons.Add(secretCodeButton4);
        }

        private void createEmptyGuessRow(int i_RowIndex)
        {
            int rowVerticalOffset = 100 + i_RowIndex * 72;
            List<Button> guessRow = createGuessButtons(i_RowIndex, rowVerticalOffset);
            Button compareButton = createCompareButton(rowVerticalOffset);
            List<Button> resultRow = createResultButtons(rowVerticalOffset);

            m_GuessButtons.Add(guessRow);
            m_CompareButtons.Add(compareButton);
            m_ResultButtons.Add(resultRow);
        }

        private List<Button> createGuessButtons(int i_RowIndex, int i_RowVerticalOffset)
        {
            List<Button> guessButtons = new List<Button>();

            for (int i = 0; i < GameLogicManager.k_SecretCodeLength; i++)
            {
                Button guessButton = new Button
                {
                    Size = new Size(49, 53),
                    BackColor = Color.Beige,
                    Location = new Point(6 + i * 60, i_RowVerticalOffset),
                    Enabled = false
                };

                this.Controls.Add(guessButton);
                guessButtons.Add(guessButton);
            }

            return guessButtons;
        }

        private Button createCompareButton(int i_RowVerticalOffset)
        {
            Button compareButton = new Button
            {
                Size = new Size(36, 23),
                Text = "-->",
                Location = new Point(245, i_RowVerticalOffset + 16),
                Enabled = false
            };

            compareButton.Click += compareButton_Click;
            this.Controls.Add(compareButton);

            return compareButton;
        }

        private List<Button> createResultButtons(int i_RowVerticalOffset)
        {
            List<Button> resultButtons = new List<Button>();

            for (int i = 0; i < 4; i++)
            {
                Button resultButton = new Button
                {
                    Size = new Size(24, 23),
                    Location = new Point(290 + (i % 2) * 30, i_RowVerticalOffset + (i / 2) * 32),
                    Enabled = false
                };

                this.Controls.Add(resultButton);
                resultButtons.Add(resultButton);
            }

            return resultButtons;
        }
    }
}
