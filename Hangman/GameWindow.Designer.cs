
namespace HangmanApp
{
    partial class GameWindow
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
            this.DrawingLabel = new System.Windows.Forms.Label();
            this.KeyboardPanel = new System.Windows.Forms.Panel();
            this.HintButton = new System.Windows.Forms.Button();
            this.KeyMButton = new System.Windows.Forms.Button();
            this.KeyNButton = new System.Windows.Forms.Button();
            this.KeyBButton = new System.Windows.Forms.Button();
            this.KeyVButton = new System.Windows.Forms.Button();
            this.KeyCButton = new System.Windows.Forms.Button();
            this.KeyXButton = new System.Windows.Forms.Button();
            this.KeyZButton = new System.Windows.Forms.Button();
            this.KeyLButton = new System.Windows.Forms.Button();
            this.KeyKButton = new System.Windows.Forms.Button();
            this.KeyJButton = new System.Windows.Forms.Button();
            this.KeyHButton = new System.Windows.Forms.Button();
            this.KeyGButton = new System.Windows.Forms.Button();
            this.KeyFButton = new System.Windows.Forms.Button();
            this.KeyDButton = new System.Windows.Forms.Button();
            this.KeySButton = new System.Windows.Forms.Button();
            this.KeyAButton = new System.Windows.Forms.Button();
            this.KeyPButton = new System.Windows.Forms.Button();
            this.KeyOButton = new System.Windows.Forms.Button();
            this.KeyIButton = new System.Windows.Forms.Button();
            this.KeyUButton = new System.Windows.Forms.Button();
            this.KeyYButton = new System.Windows.Forms.Button();
            this.KeyTButton = new System.Windows.Forms.Button();
            this.KeyRButton = new System.Windows.Forms.Button();
            this.KeyEButton = new System.Windows.Forms.Button();
            this.KeyWButton = new System.Windows.Forms.Button();
            this.KeyQButton = new System.Windows.Forms.Button();
            this.WordLabel = new System.Windows.Forms.Label();
            this.TriesPanel = new System.Windows.Forms.Panel();
            this.TriesNumLabel = new System.Windows.Forms.Label();
            this.TriesTitleLabel = new System.Windows.Forms.Label();
            this.QuitButton = new System.Windows.Forms.Button();
            this.SaveQuitButton = new System.Windows.Forms.Button();
            this.GameOverPanel = new System.Windows.Forms.Panel();
            this.PlayAgainButton = new System.Windows.Forms.Button();
            this.GameOverWordLabel = new System.Windows.Forms.Label();
            this.GameOverSubtitleLabel = new System.Windows.Forms.Label();
            this.GameOverLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.HintsNumLabel = new System.Windows.Forms.Label();
            this.HintsTitleLabel = new System.Windows.Forms.Label();
            this.KeyboardPanel.SuspendLayout();
            this.TriesPanel.SuspendLayout();
            this.GameOverPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DrawingLabel
            // 
            this.DrawingLabel.BackColor = System.Drawing.Color.Transparent;
            this.DrawingLabel.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DrawingLabel.ForeColor = System.Drawing.Color.White;
            this.DrawingLabel.Location = new System.Drawing.Point(164, 33);
            this.DrawingLabel.Name = "DrawingLabel";
            this.DrawingLabel.Size = new System.Drawing.Size(141, 197);
            this.DrawingLabel.TabIndex = 1;
            this.DrawingLabel.Text = "  +---+\r\n  |   |\r\n  O   |\r\n /|\\  |\r\n / \\  |\r\n      |\r\n=========)";
            // 
            // KeyboardPanel
            // 
            this.KeyboardPanel.Controls.Add(this.HintButton);
            this.KeyboardPanel.Controls.Add(this.KeyMButton);
            this.KeyboardPanel.Controls.Add(this.KeyNButton);
            this.KeyboardPanel.Controls.Add(this.KeyBButton);
            this.KeyboardPanel.Controls.Add(this.KeyVButton);
            this.KeyboardPanel.Controls.Add(this.KeyCButton);
            this.KeyboardPanel.Controls.Add(this.KeyXButton);
            this.KeyboardPanel.Controls.Add(this.KeyZButton);
            this.KeyboardPanel.Controls.Add(this.KeyLButton);
            this.KeyboardPanel.Controls.Add(this.KeyKButton);
            this.KeyboardPanel.Controls.Add(this.KeyJButton);
            this.KeyboardPanel.Controls.Add(this.KeyHButton);
            this.KeyboardPanel.Controls.Add(this.KeyGButton);
            this.KeyboardPanel.Controls.Add(this.KeyFButton);
            this.KeyboardPanel.Controls.Add(this.KeyDButton);
            this.KeyboardPanel.Controls.Add(this.KeySButton);
            this.KeyboardPanel.Controls.Add(this.KeyAButton);
            this.KeyboardPanel.Controls.Add(this.KeyPButton);
            this.KeyboardPanel.Controls.Add(this.KeyOButton);
            this.KeyboardPanel.Controls.Add(this.KeyIButton);
            this.KeyboardPanel.Controls.Add(this.KeyUButton);
            this.KeyboardPanel.Controls.Add(this.KeyYButton);
            this.KeyboardPanel.Controls.Add(this.KeyTButton);
            this.KeyboardPanel.Controls.Add(this.KeyRButton);
            this.KeyboardPanel.Controls.Add(this.KeyEButton);
            this.KeyboardPanel.Controls.Add(this.KeyWButton);
            this.KeyboardPanel.Controls.Add(this.KeyQButton);
            this.KeyboardPanel.Location = new System.Drawing.Point(27, 309);
            this.KeyboardPanel.Name = "KeyboardPanel";
            this.KeyboardPanel.Size = new System.Drawing.Size(431, 123);
            this.KeyboardPanel.TabIndex = 2;
            // 
            // HintButton
            // 
            this.HintButton.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HintButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.HintButton.Location = new System.Drawing.Point(323, 88);
            this.HintButton.Name = "HintButton";
            this.HintButton.Size = new System.Drawing.Size(72, 33);
            this.HintButton.TabIndex = 27;
            this.HintButton.TabStop = false;
            this.HintButton.Text = "Hint..";
            this.HintButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.HintButton.UseVisualStyleBackColor = true;
            this.HintButton.Click += new System.EventHandler(this.HintButton_Click);
            // 
            // KeyMButton
            // 
            this.KeyMButton.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyMButton.Location = new System.Drawing.Point(266, 88);
            this.KeyMButton.Name = "KeyMButton";
            this.KeyMButton.Size = new System.Drawing.Size(33, 33);
            this.KeyMButton.TabIndex = 26;
            this.KeyMButton.TabStop = false;
            this.KeyMButton.Text = "M";
            this.KeyMButton.UseVisualStyleBackColor = true;
            this.KeyMButton.Click += new System.EventHandler(this.OnScreenKeyboardButton_Click);
            // 
            // KeyNButton
            // 
            this.KeyNButton.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyNButton.Location = new System.Drawing.Point(227, 88);
            this.KeyNButton.Name = "KeyNButton";
            this.KeyNButton.Size = new System.Drawing.Size(33, 33);
            this.KeyNButton.TabIndex = 25;
            this.KeyNButton.TabStop = false;
            this.KeyNButton.Text = "N";
            this.KeyNButton.UseVisualStyleBackColor = true;
            this.KeyNButton.Click += new System.EventHandler(this.OnScreenKeyboardButton_Click);
            // 
            // KeyBButton
            // 
            this.KeyBButton.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyBButton.Location = new System.Drawing.Point(188, 88);
            this.KeyBButton.Name = "KeyBButton";
            this.KeyBButton.Size = new System.Drawing.Size(33, 33);
            this.KeyBButton.TabIndex = 24;
            this.KeyBButton.TabStop = false;
            this.KeyBButton.Text = "B";
            this.KeyBButton.UseVisualStyleBackColor = true;
            this.KeyBButton.Click += new System.EventHandler(this.OnScreenKeyboardButton_Click);
            // 
            // KeyVButton
            // 
            this.KeyVButton.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyVButton.Location = new System.Drawing.Point(149, 88);
            this.KeyVButton.Name = "KeyVButton";
            this.KeyVButton.Size = new System.Drawing.Size(33, 33);
            this.KeyVButton.TabIndex = 23;
            this.KeyVButton.TabStop = false;
            this.KeyVButton.Text = "V";
            this.KeyVButton.UseVisualStyleBackColor = true;
            this.KeyVButton.Click += new System.EventHandler(this.OnScreenKeyboardButton_Click);
            // 
            // KeyCButton
            // 
            this.KeyCButton.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyCButton.Location = new System.Drawing.Point(110, 88);
            this.KeyCButton.Name = "KeyCButton";
            this.KeyCButton.Size = new System.Drawing.Size(33, 33);
            this.KeyCButton.TabIndex = 22;
            this.KeyCButton.TabStop = false;
            this.KeyCButton.Text = "C";
            this.KeyCButton.UseVisualStyleBackColor = true;
            this.KeyCButton.Click += new System.EventHandler(this.OnScreenKeyboardButton_Click);
            // 
            // KeyXButton
            // 
            this.KeyXButton.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyXButton.Location = new System.Drawing.Point(71, 88);
            this.KeyXButton.Name = "KeyXButton";
            this.KeyXButton.Size = new System.Drawing.Size(33, 33);
            this.KeyXButton.TabIndex = 21;
            this.KeyXButton.TabStop = false;
            this.KeyXButton.Text = "X";
            this.KeyXButton.UseVisualStyleBackColor = true;
            this.KeyXButton.Click += new System.EventHandler(this.OnScreenKeyboardButton_Click);
            // 
            // KeyZButton
            // 
            this.KeyZButton.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyZButton.Location = new System.Drawing.Point(32, 88);
            this.KeyZButton.Name = "KeyZButton";
            this.KeyZButton.Size = new System.Drawing.Size(33, 33);
            this.KeyZButton.TabIndex = 20;
            this.KeyZButton.TabStop = false;
            this.KeyZButton.Text = "Z";
            this.KeyZButton.UseVisualStyleBackColor = true;
            this.KeyZButton.Click += new System.EventHandler(this.OnScreenKeyboardButton_Click);
            // 
            // KeyLButton
            // 
            this.KeyLButton.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyLButton.Location = new System.Drawing.Point(332, 49);
            this.KeyLButton.Name = "KeyLButton";
            this.KeyLButton.Size = new System.Drawing.Size(33, 33);
            this.KeyLButton.TabIndex = 18;
            this.KeyLButton.TabStop = false;
            this.KeyLButton.Text = "L";
            this.KeyLButton.UseVisualStyleBackColor = true;
            this.KeyLButton.Click += new System.EventHandler(this.OnScreenKeyboardButton_Click);
            // 
            // KeyKButton
            // 
            this.KeyKButton.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyKButton.Location = new System.Drawing.Point(293, 49);
            this.KeyKButton.Name = "KeyKButton";
            this.KeyKButton.Size = new System.Drawing.Size(33, 33);
            this.KeyKButton.TabIndex = 17;
            this.KeyKButton.TabStop = false;
            this.KeyKButton.Text = "K";
            this.KeyKButton.UseVisualStyleBackColor = true;
            this.KeyKButton.Click += new System.EventHandler(this.OnScreenKeyboardButton_Click);
            // 
            // KeyJButton
            // 
            this.KeyJButton.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyJButton.Location = new System.Drawing.Point(254, 49);
            this.KeyJButton.Name = "KeyJButton";
            this.KeyJButton.Size = new System.Drawing.Size(33, 33);
            this.KeyJButton.TabIndex = 16;
            this.KeyJButton.TabStop = false;
            this.KeyJButton.Text = "J";
            this.KeyJButton.UseVisualStyleBackColor = true;
            this.KeyJButton.Click += new System.EventHandler(this.OnScreenKeyboardButton_Click);
            // 
            // KeyHButton
            // 
            this.KeyHButton.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyHButton.Location = new System.Drawing.Point(215, 49);
            this.KeyHButton.Name = "KeyHButton";
            this.KeyHButton.Size = new System.Drawing.Size(33, 33);
            this.KeyHButton.TabIndex = 15;
            this.KeyHButton.TabStop = false;
            this.KeyHButton.Text = "H";
            this.KeyHButton.UseVisualStyleBackColor = true;
            this.KeyHButton.Click += new System.EventHandler(this.OnScreenKeyboardButton_Click);
            // 
            // KeyGButton
            // 
            this.KeyGButton.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyGButton.Location = new System.Drawing.Point(176, 49);
            this.KeyGButton.Name = "KeyGButton";
            this.KeyGButton.Size = new System.Drawing.Size(33, 33);
            this.KeyGButton.TabIndex = 14;
            this.KeyGButton.TabStop = false;
            this.KeyGButton.Text = "G";
            this.KeyGButton.UseVisualStyleBackColor = true;
            this.KeyGButton.Click += new System.EventHandler(this.OnScreenKeyboardButton_Click);
            // 
            // KeyFButton
            // 
            this.KeyFButton.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyFButton.Location = new System.Drawing.Point(137, 49);
            this.KeyFButton.Name = "KeyFButton";
            this.KeyFButton.Size = new System.Drawing.Size(33, 33);
            this.KeyFButton.TabIndex = 13;
            this.KeyFButton.TabStop = false;
            this.KeyFButton.Text = "F";
            this.KeyFButton.UseVisualStyleBackColor = true;
            this.KeyFButton.Click += new System.EventHandler(this.OnScreenKeyboardButton_Click);
            // 
            // KeyDButton
            // 
            this.KeyDButton.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyDButton.Location = new System.Drawing.Point(98, 49);
            this.KeyDButton.Name = "KeyDButton";
            this.KeyDButton.Size = new System.Drawing.Size(33, 33);
            this.KeyDButton.TabIndex = 12;
            this.KeyDButton.TabStop = false;
            this.KeyDButton.Text = "D";
            this.KeyDButton.UseVisualStyleBackColor = true;
            this.KeyDButton.Click += new System.EventHandler(this.OnScreenKeyboardButton_Click);
            // 
            // KeySButton
            // 
            this.KeySButton.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeySButton.Location = new System.Drawing.Point(59, 49);
            this.KeySButton.Name = "KeySButton";
            this.KeySButton.Size = new System.Drawing.Size(33, 33);
            this.KeySButton.TabIndex = 11;
            this.KeySButton.TabStop = false;
            this.KeySButton.Text = "S";
            this.KeySButton.UseVisualStyleBackColor = true;
            this.KeySButton.Click += new System.EventHandler(this.OnScreenKeyboardButton_Click);
            // 
            // KeyAButton
            // 
            this.KeyAButton.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyAButton.Location = new System.Drawing.Point(20, 49);
            this.KeyAButton.Name = "KeyAButton";
            this.KeyAButton.Size = new System.Drawing.Size(33, 33);
            this.KeyAButton.TabIndex = 10;
            this.KeyAButton.TabStop = false;
            this.KeyAButton.Text = "A";
            this.KeyAButton.UseVisualStyleBackColor = true;
            this.KeyAButton.Click += new System.EventHandler(this.OnScreenKeyboardButton_Click);
            // 
            // KeyPButton
            // 
            this.KeyPButton.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyPButton.Location = new System.Drawing.Point(362, 10);
            this.KeyPButton.Name = "KeyPButton";
            this.KeyPButton.Size = new System.Drawing.Size(33, 33);
            this.KeyPButton.TabIndex = 9;
            this.KeyPButton.TabStop = false;
            this.KeyPButton.Text = "P";
            this.KeyPButton.UseVisualStyleBackColor = true;
            this.KeyPButton.Click += new System.EventHandler(this.OnScreenKeyboardButton_Click);
            // 
            // KeyOButton
            // 
            this.KeyOButton.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyOButton.Location = new System.Drawing.Point(322, 10);
            this.KeyOButton.Name = "KeyOButton";
            this.KeyOButton.Size = new System.Drawing.Size(33, 33);
            this.KeyOButton.TabIndex = 8;
            this.KeyOButton.TabStop = false;
            this.KeyOButton.Text = "O";
            this.KeyOButton.UseVisualStyleBackColor = true;
            this.KeyOButton.Click += new System.EventHandler(this.OnScreenKeyboardButton_Click);
            // 
            // KeyIButton
            // 
            this.KeyIButton.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyIButton.Location = new System.Drawing.Point(284, 10);
            this.KeyIButton.Name = "KeyIButton";
            this.KeyIButton.Size = new System.Drawing.Size(33, 33);
            this.KeyIButton.TabIndex = 7;
            this.KeyIButton.TabStop = false;
            this.KeyIButton.Text = "I";
            this.KeyIButton.UseVisualStyleBackColor = true;
            this.KeyIButton.Click += new System.EventHandler(this.OnScreenKeyboardButton_Click);
            // 
            // KeyUButton
            // 
            this.KeyUButton.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyUButton.Location = new System.Drawing.Point(245, 10);
            this.KeyUButton.Name = "KeyUButton";
            this.KeyUButton.Size = new System.Drawing.Size(33, 33);
            this.KeyUButton.TabIndex = 6;
            this.KeyUButton.TabStop = false;
            this.KeyUButton.Text = "U";
            this.KeyUButton.UseVisualStyleBackColor = true;
            this.KeyUButton.Click += new System.EventHandler(this.OnScreenKeyboardButton_Click);
            // 
            // KeyYButton
            // 
            this.KeyYButton.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyYButton.Location = new System.Drawing.Point(206, 10);
            this.KeyYButton.Name = "KeyYButton";
            this.KeyYButton.Size = new System.Drawing.Size(33, 33);
            this.KeyYButton.TabIndex = 5;
            this.KeyYButton.TabStop = false;
            this.KeyYButton.Text = "Y";
            this.KeyYButton.UseVisualStyleBackColor = true;
            this.KeyYButton.Click += new System.EventHandler(this.OnScreenKeyboardButton_Click);
            // 
            // KeyTButton
            // 
            this.KeyTButton.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyTButton.Location = new System.Drawing.Point(167, 10);
            this.KeyTButton.Name = "KeyTButton";
            this.KeyTButton.Size = new System.Drawing.Size(33, 33);
            this.KeyTButton.TabIndex = 4;
            this.KeyTButton.TabStop = false;
            this.KeyTButton.Text = "T";
            this.KeyTButton.UseVisualStyleBackColor = true;
            this.KeyTButton.Click += new System.EventHandler(this.OnScreenKeyboardButton_Click);
            // 
            // KeyRButton
            // 
            this.KeyRButton.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyRButton.Location = new System.Drawing.Point(128, 10);
            this.KeyRButton.Name = "KeyRButton";
            this.KeyRButton.Size = new System.Drawing.Size(33, 33);
            this.KeyRButton.TabIndex = 3;
            this.KeyRButton.TabStop = false;
            this.KeyRButton.Text = "R";
            this.KeyRButton.UseVisualStyleBackColor = true;
            this.KeyRButton.Click += new System.EventHandler(this.OnScreenKeyboardButton_Click);
            // 
            // KeyEButton
            // 
            this.KeyEButton.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyEButton.Location = new System.Drawing.Point(89, 10);
            this.KeyEButton.Name = "KeyEButton";
            this.KeyEButton.Size = new System.Drawing.Size(33, 33);
            this.KeyEButton.TabIndex = 2;
            this.KeyEButton.TabStop = false;
            this.KeyEButton.Text = "E";
            this.KeyEButton.UseVisualStyleBackColor = true;
            this.KeyEButton.Click += new System.EventHandler(this.OnScreenKeyboardButton_Click);
            // 
            // KeyWButton
            // 
            this.KeyWButton.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyWButton.Location = new System.Drawing.Point(50, 10);
            this.KeyWButton.Name = "KeyWButton";
            this.KeyWButton.Size = new System.Drawing.Size(33, 33);
            this.KeyWButton.TabIndex = 1;
            this.KeyWButton.TabStop = false;
            this.KeyWButton.Text = "W";
            this.KeyWButton.UseVisualStyleBackColor = true;
            this.KeyWButton.Click += new System.EventHandler(this.OnScreenKeyboardButton_Click);
            // 
            // KeyQButton
            // 
            this.KeyQButton.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyQButton.Location = new System.Drawing.Point(11, 10);
            this.KeyQButton.Name = "KeyQButton";
            this.KeyQButton.Size = new System.Drawing.Size(33, 33);
            this.KeyQButton.TabIndex = 0;
            this.KeyQButton.TabStop = false;
            this.KeyQButton.Text = "Q";
            this.KeyQButton.UseVisualStyleBackColor = true;
            this.KeyQButton.Click += new System.EventHandler(this.OnScreenKeyboardButton_Click);
            // 
            // WordLabel
            // 
            this.WordLabel.BackColor = System.Drawing.Color.Transparent;
            this.WordLabel.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WordLabel.ForeColor = System.Drawing.Color.White;
            this.WordLabel.Location = new System.Drawing.Point(0, 243);
            this.WordLabel.Name = "WordLabel";
            this.WordLabel.Size = new System.Drawing.Size(495, 46);
            this.WordLabel.TabIndex = 3;
            this.WordLabel.Text = "s u p e r c o n d u c t i v i t y";
            this.WordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TriesPanel
            // 
            this.TriesPanel.Controls.Add(this.TriesNumLabel);
            this.TriesPanel.Controls.Add(this.TriesTitleLabel);
            this.TriesPanel.Location = new System.Drawing.Point(320, 33);
            this.TriesPanel.Name = "TriesPanel";
            this.TriesPanel.Size = new System.Drawing.Size(164, 55);
            this.TriesPanel.TabIndex = 4;
            // 
            // TriesNumLabel
            // 
            this.TriesNumLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TriesNumLabel.ForeColor = System.Drawing.Color.White;
            this.TriesNumLabel.Location = new System.Drawing.Point(9, 24);
            this.TriesNumLabel.Name = "TriesNumLabel";
            this.TriesNumLabel.Size = new System.Drawing.Size(57, 18);
            this.TriesNumLabel.TabIndex = 1;
            this.TriesNumLabel.Text = "5";
            this.TriesNumLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TriesTitleLabel
            // 
            this.TriesTitleLabel.AutoSize = true;
            this.TriesTitleLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TriesTitleLabel.ForeColor = System.Drawing.Color.White;
            this.TriesTitleLabel.Location = new System.Drawing.Point(9, 6);
            this.TriesTitleLabel.Name = "TriesTitleLabel";
            this.TriesTitleLabel.Size = new System.Drawing.Size(118, 18);
            this.TriesTitleLabel.TabIndex = 0;
            this.TriesTitleLabel.Text = "Tries Left:";
            // 
            // QuitButton
            // 
            this.QuitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.QuitButton.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QuitButton.Location = new System.Drawing.Point(16, 12);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(94, 25);
            this.QuitButton.TabIndex = 5;
            this.QuitButton.TabStop = false;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // SaveQuitButton
            // 
            this.SaveQuitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SaveQuitButton.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveQuitButton.Location = new System.Drawing.Point(16, 43);
            this.SaveQuitButton.Name = "SaveQuitButton";
            this.SaveQuitButton.Size = new System.Drawing.Size(94, 25);
            this.SaveQuitButton.TabIndex = 6;
            this.SaveQuitButton.TabStop = false;
            this.SaveQuitButton.Text = "Save && Quit";
            this.SaveQuitButton.UseVisualStyleBackColor = true;
            this.SaveQuitButton.Click += new System.EventHandler(this.SaveQuitButton_Click);
            // 
            // GameOverPanel
            // 
            this.GameOverPanel.Controls.Add(this.PlayAgainButton);
            this.GameOverPanel.Controls.Add(this.GameOverWordLabel);
            this.GameOverPanel.Controls.Add(this.GameOverSubtitleLabel);
            this.GameOverPanel.Controls.Add(this.GameOverLabel);
            this.GameOverPanel.Location = new System.Drawing.Point(12, 88);
            this.GameOverPanel.Name = "GameOverPanel";
            this.GameOverPanel.Size = new System.Drawing.Size(133, 130);
            this.GameOverPanel.TabIndex = 7;
            this.GameOverPanel.Visible = false;
            // 
            // PlayAgainButton
            // 
            this.PlayAgainButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PlayAgainButton.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayAgainButton.Location = new System.Drawing.Point(18, 98);
            this.PlayAgainButton.Name = "PlayAgainButton";
            this.PlayAgainButton.Size = new System.Drawing.Size(94, 25);
            this.PlayAgainButton.TabIndex = 6;
            this.PlayAgainButton.TabStop = false;
            this.PlayAgainButton.Text = "Play Again";
            this.PlayAgainButton.UseVisualStyleBackColor = true;
            this.PlayAgainButton.Click += new System.EventHandler(this.PlayAgainButton_Click);
            // 
            // GameOverWordLabel
            // 
            this.GameOverWordLabel.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GameOverWordLabel.ForeColor = System.Drawing.Color.White;
            this.GameOverWordLabel.Location = new System.Drawing.Point(1, 57);
            this.GameOverWordLabel.Name = "GameOverWordLabel";
            this.GameOverWordLabel.Size = new System.Drawing.Size(131, 35);
            this.GameOverWordLabel.TabIndex = 2;
            this.GameOverWordLabel.Text = "superconductivity";
            this.GameOverWordLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // GameOverSubtitleLabel
            // 
            this.GameOverSubtitleLabel.AutoSize = true;
            this.GameOverSubtitleLabel.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GameOverSubtitleLabel.ForeColor = System.Drawing.Color.White;
            this.GameOverSubtitleLabel.Location = new System.Drawing.Point(4, 39);
            this.GameOverSubtitleLabel.Name = "GameOverSubtitleLabel";
            this.GameOverSubtitleLabel.Size = new System.Drawing.Size(127, 18);
            this.GameOverSubtitleLabel.TabIndex = 1;
            this.GameOverSubtitleLabel.Text = "The word was:";
            // 
            // GameOverLabel
            // 
            this.GameOverLabel.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GameOverLabel.ForeColor = System.Drawing.Color.Brown;
            this.GameOverLabel.Location = new System.Drawing.Point(0, 1);
            this.GameOverLabel.Name = "GameOverLabel";
            this.GameOverLabel.Size = new System.Drawing.Size(133, 34);
            this.GameOverLabel.TabIndex = 0;
            this.GameOverLabel.Text = "You lose!";
            this.GameOverLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.HintsNumLabel);
            this.panel1.Controls.Add(this.HintsTitleLabel);
            this.panel1.Location = new System.Drawing.Point(320, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 55);
            this.panel1.TabIndex = 8;
            // 
            // HintsNumLabel
            // 
            this.HintsNumLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HintsNumLabel.ForeColor = System.Drawing.Color.White;
            this.HintsNumLabel.Location = new System.Drawing.Point(9, 24);
            this.HintsNumLabel.Name = "HintsNumLabel";
            this.HintsNumLabel.Size = new System.Drawing.Size(57, 18);
            this.HintsNumLabel.TabIndex = 1;
            this.HintsNumLabel.Text = "1";
            this.HintsNumLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HintsTitleLabel
            // 
            this.HintsTitleLabel.AutoSize = true;
            this.HintsTitleLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HintsTitleLabel.ForeColor = System.Drawing.Color.White;
            this.HintsTitleLabel.Location = new System.Drawing.Point(9, 6);
            this.HintsTitleLabel.Name = "HintsTitleLabel";
            this.HintsTitleLabel.Size = new System.Drawing.Size(118, 18);
            this.HintsTitleLabel.TabIndex = 0;
            this.HintsTitleLabel.Text = "Hints Left:";
            // 
            // GameWindow
            // 
            this.AcceptButton = this.HintButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(496, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GameOverPanel);
            this.Controls.Add(this.SaveQuitButton);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.TriesPanel);
            this.Controls.Add(this.WordLabel);
            this.Controls.Add(this.KeyboardPanel);
            this.Controls.Add(this.DrawingLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "GameWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hangman - ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameWindow_FormClosing);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GameWindow_KeyPress);
            this.KeyboardPanel.ResumeLayout(false);
            this.TriesPanel.ResumeLayout(false);
            this.TriesPanel.PerformLayout();
            this.GameOverPanel.ResumeLayout(false);
            this.GameOverPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        //private System.Windows.Forms.Label labelDrawing;
        //private System.Windows.Forms.Panel panelKeyboard;
        private System.Windows.Forms.Button KeyQButton;
        private System.Windows.Forms.Button KeyMButton;
        private System.Windows.Forms.Button KeyNButton;
        private System.Windows.Forms.Button KeyBButton;
        private System.Windows.Forms.Button KeyVButton;
        private System.Windows.Forms.Button KeyCButton;
        private System.Windows.Forms.Button KeyXButton;
        private System.Windows.Forms.Button KeyZButton;
        private System.Windows.Forms.Button KeyLButton;
        private System.Windows.Forms.Button KeyKButton;
        private System.Windows.Forms.Button KeyJButton;
        private System.Windows.Forms.Button KeyHButton;
        private System.Windows.Forms.Button KeyGButton;
        private System.Windows.Forms.Button KeyFButton;
        private System.Windows.Forms.Button KeyDButton;
        private System.Windows.Forms.Button KeySButton;
        private System.Windows.Forms.Button KeyAButton;
        private System.Windows.Forms.Button KeyPButton;
        private System.Windows.Forms.Button KeyOButton;
        private System.Windows.Forms.Button KeyIButton;
        private System.Windows.Forms.Button KeyUButton;
        private System.Windows.Forms.Button KeyYButton;
        private System.Windows.Forms.Button KeyTButton;
        private System.Windows.Forms.Button KeyRButton;
        private System.Windows.Forms.Button KeyEButton;
        private System.Windows.Forms.Button KeyWButton;
        //private System.Windows.Forms.Button button1;
        //private System.Windows.Forms.Label labelWord;
        //private System.Windows.Forms.Panel panelTries;
        //private System.Windows.Forms.Label labelTriesNum;
        //private System.Windows.Forms.Label labelTriesTitle;
        private System.Windows.Forms.Label DrawingLabel;
        private System.Windows.Forms.Panel KeyboardPanel;
        private System.Windows.Forms.Button HintButton;
        private System.Windows.Forms.Label WordLabel;
        private System.Windows.Forms.Panel TriesPanel;
        private System.Windows.Forms.Label TriesNumLabel;
        private System.Windows.Forms.Label TriesTitleLabel;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Button SaveQuitButton;
        private System.Windows.Forms.Panel GameOverPanel;
        private System.Windows.Forms.Label GameOverLabel;
        private System.Windows.Forms.Button PlayAgainButton;
        private System.Windows.Forms.Label GameOverWordLabel;
        private System.Windows.Forms.Label GameOverSubtitleLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label HintsNumLabel;
        private System.Windows.Forms.Label HintsTitleLabel;
    }
}

