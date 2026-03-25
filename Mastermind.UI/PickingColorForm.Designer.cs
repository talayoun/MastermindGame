namespace MastermindGame.UI
{
    partial class PickingColorForm
    { 
        private void InitializeComponent()
        {
            this.purpleButton = new System.Windows.Forms.Button();
            this.purpleButton.Tag = MastermindGame.Logic.eGuessSymbol.Purple;
            this.redButton = new System.Windows.Forms.Button();
            this.redButton.Tag = MastermindGame.Logic.eGuessSymbol.Red;
            this.greenButton = new System.Windows.Forms.Button();
            this.greenButton.Tag = MastermindGame.Logic.eGuessSymbol.Green;
            this.lightBlueButton = new System.Windows.Forms.Button();
            this.lightBlueButton.Tag = MastermindGame.Logic.eGuessSymbol.LightBlue;
            this.whiteButton = new System.Windows.Forms.Button();
            this.whiteButton.Tag = MastermindGame.Logic.eGuessSymbol.White;
            this.brownButton = new System.Windows.Forms.Button();
            this.brownButton.Tag = MastermindGame.Logic.eGuessSymbol.Brown;
            this.yellowButton = new System.Windows.Forms.Button();
            this.yellowButton.Tag = MastermindGame.Logic.eGuessSymbol.Yellow;
            this.darkBlueButton = new System.Windows.Forms.Button();
            this.darkBlueButton.Tag = MastermindGame.Logic.eGuessSymbol.DarkBlue;
            this.SuspendLayout();
            // 
            // purpleButton
            // 
            this.purpleButton.BackColor = System.Drawing.Color.MediumPurple;
            this.purpleButton.Location = new System.Drawing.Point(12, 12);
            this.purpleButton.Name = "purpleButton";
            this.purpleButton.Size = new System.Drawing.Size(58, 59);
            this.purpleButton.TabIndex = 0;
            this.purpleButton.UseVisualStyleBackColor = false;
            this.purpleButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // redButton
            // 
            this.redButton.BackColor = System.Drawing.Color.Red;
            this.redButton.Location = new System.Drawing.Point(76, 12);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(58, 59);
            this.redButton.TabIndex = 1;
            this.redButton.UseVisualStyleBackColor = false;
            this.redButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // greenButton
            // 
            this.greenButton.BackColor = System.Drawing.Color.LightGreen;
            this.greenButton.Location = new System.Drawing.Point(140, 12);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(58, 59);
            this.greenButton.TabIndex = 2;
            this.greenButton.UseVisualStyleBackColor = false;
            this.greenButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // lightBlueButton
            // 
            this.lightBlueButton.BackColor = System.Drawing.Color.PowderBlue;
            this.lightBlueButton.Location = new System.Drawing.Point(204, 12);
            this.lightBlueButton.Name = "lightBlueButton";
            this.lightBlueButton.Size = new System.Drawing.Size(58, 59);
            this.lightBlueButton.TabIndex = 3;
            this.lightBlueButton.UseVisualStyleBackColor = false;
            this.lightBlueButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // whiteButton
            // 
            this.whiteButton.BackColor = System.Drawing.Color.White;
            this.whiteButton.Location = new System.Drawing.Point(204, 77);
            this.whiteButton.Name = "whiteButton";
            this.whiteButton.Size = new System.Drawing.Size(58, 59);
            this.whiteButton.TabIndex = 4;
            this.whiteButton.UseVisualStyleBackColor = false;
            this.whiteButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // brownButton
            // 
            this.brownButton.BackColor = System.Drawing.Color.Peru;
            this.brownButton.Location = new System.Drawing.Point(140, 77);
            this.brownButton.Name = "brownButton";
            this.brownButton.Size = new System.Drawing.Size(58, 59);
            this.brownButton.TabIndex = 5;
            this.brownButton.UseVisualStyleBackColor = false;
            this.brownButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // yellowButton
            // 
            this.yellowButton.BackColor = System.Drawing.Color.Khaki;
            this.yellowButton.Location = new System.Drawing.Point(76, 77);
            this.yellowButton.Name = "yellowButton";
            this.yellowButton.Size = new System.Drawing.Size(58, 59);
            this.yellowButton.TabIndex = 6;
            this.yellowButton.UseVisualStyleBackColor = false;
            this.yellowButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // darkBlueButton
            // 
            this.darkBlueButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.darkBlueButton.Location = new System.Drawing.Point(12, 77);
            this.darkBlueButton.Name = "darkBlueButton";
            this.darkBlueButton.Size = new System.Drawing.Size(58, 59);
            this.darkBlueButton.TabIndex = 7;
            this.darkBlueButton.UseVisualStyleBackColor = false;
            this.darkBlueButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // PickingColorForm
            // 
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(268, 148);
            this.Controls.Add(this.darkBlueButton);
            this.Controls.Add(this.yellowButton);
            this.Controls.Add(this.brownButton);
            this.Controls.Add(this.whiteButton);
            this.Controls.Add(this.lightBlueButton);
            this.Controls.Add(this.greenButton);
            this.Controls.Add(this.redButton);
            this.Controls.Add(this.purpleButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PickingColorForm";
            this.Text = "Pick A Color:";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button purpleButton;
        private System.Windows.Forms.Button redButton;
        private System.Windows.Forms.Button greenButton;
        private System.Windows.Forms.Button lightBlueButton;
        private System.Windows.Forms.Button whiteButton;
        private System.Windows.Forms.Button brownButton;
        private System.Windows.Forms.Button yellowButton;
        private System.Windows.Forms.Button darkBlueButton;
    } 
}