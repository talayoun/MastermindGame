using MastermindGame.Logic;
namespace MastermindGame.UI
{
    partial class LoginForm
    {
        private void InitializeComponent()
        {
            this.chancesButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chancesButton
            // 
            this.chancesButton.BackColor = System.Drawing.Color.White;
            this.chancesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.chancesButton.Location = new System.Drawing.Point(22, 21);
            this.chancesButton.Name = "chancesButton";
            this.chancesButton.Size = new System.Drawing.Size(234, 37);
            this.chancesButton.TabIndex = 0;
            this.chancesButton.Text = "";
            this.chancesButton.UseVisualStyleBackColor = false;
            this.chancesButton.Click += new System.EventHandler(this.chancesButton_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.White;
            this.startButton.Location = new System.Drawing.Point(150, 113);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(106, 30);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // LoginForm
            // 
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(282, 153);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.chancesButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginForm";
            this.Text = "Bool Pgia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button chancesButton;
        private System.Windows.Forms.Button startButton;
    }
}