
namespace HangmanApp
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainPanel = new System.Windows.Forms.Panel();
            this.CreditsLabel = new System.Windows.Forms.Label();
            this.QuitButton = new System.Windows.Forms.Button();
            this.OptionsButton = new System.Windows.Forms.Button();
            this.LoadGameButton = new System.Windows.Forms.Button();
            this.NewGameButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SubtitleLabel = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.CreditsLabel);
            this.MainPanel.Controls.Add(this.QuitButton);
            this.MainPanel.Controls.Add(this.OptionsButton);
            this.MainPanel.Controls.Add(this.LoadGameButton);
            this.MainPanel.Controls.Add(this.NewGameButton);
            this.MainPanel.Location = new System.Drawing.Point(0, 98);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(258, 287);
            this.MainPanel.TabIndex = 0;
            // 
            // CreditsLabel
            // 
            this.CreditsLabel.AutoSize = true;
            this.CreditsLabel.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.CreditsLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.CreditsLabel.Location = new System.Drawing.Point(207, 269);
            this.CreditsLabel.Name = "CreditsLabel";
            this.CreditsLabel.Size = new System.Drawing.Size(48, 15);
            this.CreditsLabel.TabIndex = 4;
            this.CreditsLabel.Text = "Credits";
            this.CreditsLabel.Click += new System.EventHandler(this.CreditsLabel_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.QuitButton.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.QuitButton.Location = new System.Drawing.Point(60, 206);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(142, 39);
            this.QuitButton.TabIndex = 3;
            this.QuitButton.TabStop = false;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // OptionsButton
            // 
            this.OptionsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OptionsButton.Enabled = false;
            this.OptionsButton.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OptionsButton.Location = new System.Drawing.Point(60, 151);
            this.OptionsButton.Name = "OptionsButton";
            this.OptionsButton.Size = new System.Drawing.Size(142, 39);
            this.OptionsButton.TabIndex = 2;
            this.OptionsButton.TabStop = false;
            this.OptionsButton.Text = "Options";
            this.OptionsButton.UseVisualStyleBackColor = true;
            // 
            // LoadGameButton
            // 
            this.LoadGameButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoadGameButton.Enabled = false;
            this.LoadGameButton.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoadGameButton.Location = new System.Drawing.Point(60, 97);
            this.LoadGameButton.Name = "LoadGameButton";
            this.LoadGameButton.Size = new System.Drawing.Size(142, 39);
            this.LoadGameButton.TabIndex = 1;
            this.LoadGameButton.TabStop = false;
            this.LoadGameButton.Text = "Load Game";
            this.LoadGameButton.UseVisualStyleBackColor = true;
            // 
            // NewGameButton
            // 
            this.NewGameButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NewGameButton.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NewGameButton.Location = new System.Drawing.Point(60, 43);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(142, 39);
            this.NewGameButton.TabIndex = 0;
            this.NewGameButton.TabStop = false;
            this.NewGameButton.Text = "New Game";
            this.NewGameButton.UseVisualStyleBackColor = true;
            this.NewGameButton.Click += new System.EventHandler(this.NewGameButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Lucida Bright", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.TitleLabel.Location = new System.Drawing.Point(22, 25);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(215, 43);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Hangman!";
            // 
            // SubtitleLabel
            // 
            this.SubtitleLabel.Font = new System.Drawing.Font("Lucida Bright", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.SubtitleLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.SubtitleLabel.Location = new System.Drawing.Point(22, 68);
            this.SubtitleLabel.Name = "SubtitleLabel";
            this.SubtitleLabel.Size = new System.Drawing.Size(215, 27);
            this.SubtitleLabel.TabIndex = 2;
            this.SubtitleLabel.Text = "by Kyle Warner";
            this.SubtitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(258, 386);
            this.Controls.Add(this.SubtitleLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.MainPanel);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hangman!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button NewGameButton;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Button OptionsButton;
        private System.Windows.Forms.Button LoadGameButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label SubtitleLabel;
        private System.Windows.Forms.Label CreditsLabel;
    }
}

