using MastermindGame.Logic;
using System;
using System.Windows.Forms;

namespace MastermindGame.UI
{
    public partial class PickingColorForm : Form
    {
        public eGuessSymbol SelectedSymbol { get; private set; }

        public PickingColorForm()
        {
            InitializeComponent();
            this.Load += PickingColorForm_Load;
        }

        private void PickingColorForm_Load(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button colorButton && colorButton.Tag is eGuessSymbol)
                {
                    colorButton.Click += colorButton_Click;
                }
            }
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            if (sender is Button colorButton && colorButton.Tag is eGuessSymbol symbol)
            {
                SelectedSymbol = symbol;
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
