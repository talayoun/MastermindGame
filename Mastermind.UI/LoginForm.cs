using System;
using System.Windows.Forms;
using MastermindGame.Logic;


namespace MastermindGame.UI
{
    public partial class LoginForm : Form
    {
        GameLogicManager m_GameLogicManager = new GameLogicManager();
       
        public LoginForm()
        {
            InitializeComponent();
        }

        private void chancesButton_Click(object sender, EventArgs e)
        {
            m_GameLogicManager.m_NumberOfGuessesFromUser++;
            resetNumberOfGuessesIfExceededMax();
            updateChancesDisplay();
        }
        
        private void startButton_Click(object sender, EventArgs e)
        {
            this.Opacity = 0;
            FormGame gameForm = new FormGame(m_GameLogicManager.m_NumberOfGuessesFromUser);
            this.ShowInTaskbar = false;
            gameForm.ShowDialog();
            this.Close(); 
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            updateChancesDisplay();
        }

        private void updateChancesDisplay()
        {
            this.chancesButton.Text = $"Number of chances: {m_GameLogicManager.m_NumberOfGuessesFromUser}";
        }

        private void resetNumberOfGuessesIfExceededMax()
        {
            if (m_GameLogicManager.m_NumberOfGuessesFromUser > GameLogicManager.k_MaxSecretCodeLength)
            {
                m_GameLogicManager.m_NumberOfGuessesFromUser = GameLogicManager.k_SecretCodeLength;
            }
        }
    }
}
