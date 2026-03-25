namespace MastermindGame.UI
{
    partial class FormGame
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.secretCodeButton1 = new System.Windows.Forms.Button();
            this.secretCodeButton2 = new System.Windows.Forms.Button();
            this.secretCodeButton3 = new System.Windows.Forms.Button();
            this.secretCodeButton4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // secretCodeButton1
            // 
            this.secretCodeButton1.BackColor = System.Drawing.Color.Black;
            this.secretCodeButton1.Enabled = false;
            this.secretCodeButton1.Location = new System.Drawing.Point(6, 10);
            this.secretCodeButton1.Margin = new System.Windows.Forms.Padding(2);
            this.secretCodeButton1.Name = "secretCodeButton1";
            this.secretCodeButton1.Size = new System.Drawing.Size(49, 53);
            this.secretCodeButton1.TabIndex = 0;
            this.secretCodeButton1.UseVisualStyleBackColor = false;
            // 
            // secretCodeButton2
            // 
            this.secretCodeButton2.BackColor = System.Drawing.Color.Black;
            this.secretCodeButton2.Enabled = false;
            this.secretCodeButton2.Location = new System.Drawing.Point(66, 10);
            this.secretCodeButton2.Margin = new System.Windows.Forms.Padding(2);
            this.secretCodeButton2.Name = "secretCodeButton2";
            this.secretCodeButton2.Size = new System.Drawing.Size(49, 53);
            this.secretCodeButton2.TabIndex = 1;
            this.secretCodeButton2.UseVisualStyleBackColor = false;
            // 
            // secretCodeButton3
            // 
            this.secretCodeButton3.BackColor = System.Drawing.Color.Black;
            this.secretCodeButton3.Enabled = false;
            this.secretCodeButton3.Location = new System.Drawing.Point(126, 10);
            this.secretCodeButton3.Margin = new System.Windows.Forms.Padding(2);
            this.secretCodeButton3.Name = "secretCodeButton3";
            this.secretCodeButton3.Size = new System.Drawing.Size(49, 53);
            this.secretCodeButton3.TabIndex = 2;
            this.secretCodeButton3.UseVisualStyleBackColor = false;
            // 
            // secretCodeButton4
            // 
            this.secretCodeButton4.BackColor = System.Drawing.Color.Black;
            this.secretCodeButton4.Enabled = false;
            this.secretCodeButton4.Location = new System.Drawing.Point(186, 10);
            this.secretCodeButton4.Margin = new System.Windows.Forms.Padding(2);
            this.secretCodeButton4.Name = "secretCodeButton4";
            this.secretCodeButton4.Size = new System.Drawing.Size(49, 53);
            this.secretCodeButton4.TabIndex = 3;
            this.secretCodeButton4.UseVisualStyleBackColor = false;
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(388, 469);
            this.Controls.Add(this.secretCodeButton4);
            this.Controls.Add(this.secretCodeButton3);
            this.Controls.Add(this.secretCodeButton2);
            this.Controls.Add(this.secretCodeButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bool Pgia";
            this.Load += new System.EventHandler(this.FormGame_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button secretCodeButton1;
        private System.Windows.Forms.Button secretCodeButton2;
        private System.Windows.Forms.Button secretCodeButton3;
        private System.Windows.Forms.Button secretCodeButton4;
    }
}