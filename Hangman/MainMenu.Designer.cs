
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
            this.AboutLabel = new System.Windows.Forms.LinkLabel();
            this.QuitButton = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.Button();
            this.LoadGameButton = new System.Windows.Forms.Button();
            this.NewGameButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SubtitleLabel = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.AboutLabel);
            this.MainPanel.Controls.Add(this.QuitButton);
            this.MainPanel.Controls.Add(this.AboutButton);
            this.MainPanel.Controls.Add(this.LoadGameButton);
            this.MainPanel.Controls.Add(this.NewGameButton);
            this.MainPanel.Location = new System.Drawing.Point(0, 98);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(258, 287);
            this.MainPanel.TabIndex = 0;
            // 
            // AboutLabel
            // 
            this.AboutLabel.AutoSize = true;
            this.AboutLabel.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.AboutLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.AboutLabel.Location = new System.Drawing.Point(207, 269);
            this.AboutLabel.Name = "AboutLabel";
            this.AboutLabel.Size = new System.Drawing.Size(44, 15);
            this.AboutLabel.TabIndex = 4;
            this.AboutLabel.TabStop = true;
            this.AboutLabel.Text = "About";
            this.AboutLabel.Visible = false;
            this.AboutLabel.Click += new System.EventHandler(this.AboutLabel_Click);
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
            // AboutButton
            // 
            this.AboutButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AboutButton.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AboutButton.Location = new System.Drawing.Point(60, 151);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(142, 39);
            this.AboutButton.TabIndex = 2;
            this.AboutButton.TabStop = false;
            this.AboutButton.Text = "About";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutLabel_Click);
            // 
            // LoadGameButton
            // 
            this.LoadGameButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoadGameButton.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoadGameButton.Location = new System.Drawing.Point(60, 97);
            this.LoadGameButton.Name = "LoadGameButton";
            this.LoadGameButton.Size = new System.Drawing.Size(142, 39);
            this.LoadGameButton.TabIndex = 1;
            this.LoadGameButton.TabStop = false;
            this.LoadGameButton.Text = "Load Game";
            this.LoadGameButton.UseVisualStyleBackColor = true;
            this.LoadGameButton.Click += new System.EventHandler(this.LoadGameButton_Click);
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
            this.AcceptButton = this.NewGameButton;
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
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Button LoadGameButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label SubtitleLabel;
        private System.Windows.Forms.LinkLabel AboutLabel;
    }
}

