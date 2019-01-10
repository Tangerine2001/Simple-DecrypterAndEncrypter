namespace DecryptionSoftware
{
    partial class DecryptionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.decryptButton = new System.Windows.Forms.Button();
            this.DecryptPanel = new System.Windows.Forms.Panel();
            this.dKeyLabel = new System.Windows.Forms.Label();
            this.dInputLabel = new System.Windows.Forms.Label();
            this.decryptKeyTextBox = new System.Windows.Forms.TextBox();
            this.decryptComboBox = new System.Windows.Forms.ComboBox();
            this.solutionsLabel = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.HomePanel = new System.Windows.Forms.Panel();
            this.dButton = new System.Windows.Forms.Button();
            this.eButton = new System.Windows.Forms.Button();
            this.EncryptPanel = new System.Windows.Forms.Panel();
            this.cipherLabel = new System.Windows.Forms.Label();
            this.encryptComboBox = new System.Windows.Forms.ComboBox();
            this.encryptedText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.encryptButton = new System.Windows.Forms.Button();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.stringTextBox = new System.Windows.Forms.TextBox();
            this.DecryptPanel.SuspendLayout();
            this.HomePanel.SuspendLayout();
            this.EncryptPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(152, 81);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(100, 20);
            this.inputTextBox.TabIndex = 0;
            // 
            // decryptButton
            // 
            this.decryptButton.Location = new System.Drawing.Point(227, 107);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(75, 23);
            this.decryptButton.TabIndex = 1;
            this.decryptButton.Text = "Decrypt";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // DecryptPanel
            // 
            this.DecryptPanel.Controls.Add(this.dKeyLabel);
            this.DecryptPanel.Controls.Add(this.dInputLabel);
            this.DecryptPanel.Controls.Add(this.decryptKeyTextBox);
            this.DecryptPanel.Controls.Add(this.decryptComboBox);
            this.DecryptPanel.Controls.Add(this.solutionsLabel);
            this.DecryptPanel.Controls.Add(this.inputTextBox);
            this.DecryptPanel.Controls.Add(this.decryptButton);
            this.DecryptPanel.Location = new System.Drawing.Point(363, 215);
            this.DecryptPanel.Name = "DecryptPanel";
            this.DecryptPanel.Size = new System.Drawing.Size(135, 137);
            this.DecryptPanel.TabIndex = 3;
            this.DecryptPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DecryptPanel_Paint);
            // 
            // dKeyLabel
            // 
            this.dKeyLabel.AutoSize = true;
            this.dKeyLabel.Location = new System.Drawing.Point(274, 65);
            this.dKeyLabel.Name = "dKeyLabel";
            this.dKeyLabel.Size = new System.Drawing.Size(28, 13);
            this.dKeyLabel.TabIndex = 7;
            this.dKeyLabel.Text = "Key:";
            // 
            // dInputLabel
            // 
            this.dInputLabel.AutoSize = true;
            this.dInputLabel.Location = new System.Drawing.Point(149, 65);
            this.dInputLabel.Name = "dInputLabel";
            this.dInputLabel.Size = new System.Drawing.Size(31, 13);
            this.dInputLabel.TabIndex = 6;
            this.dInputLabel.Text = "Text:";
            // 
            // decryptKeyTextBox
            // 
            this.decryptKeyTextBox.Location = new System.Drawing.Point(277, 81);
            this.decryptKeyTextBox.Name = "decryptKeyTextBox";
            this.decryptKeyTextBox.Size = new System.Drawing.Size(100, 20);
            this.decryptKeyTextBox.TabIndex = 5;
            // 
            // decryptComboBox
            // 
            this.decryptComboBox.FormattingEnabled = true;
            this.decryptComboBox.Items.AddRange(new object[] {
            "Caesarean",
            "Vigenere"});
            this.decryptComboBox.Location = new System.Drawing.Point(203, 14);
            this.decryptComboBox.Name = "decryptComboBox";
            this.decryptComboBox.Size = new System.Drawing.Size(121, 21);
            this.decryptComboBox.TabIndex = 4;
            this.decryptComboBox.SelectedIndexChanged += new System.EventHandler(this.decryptComboBox_SelectedIndexChanged);
            // 
            // solutionsLabel
            // 
            this.solutionsLabel.BackColor = System.Drawing.SystemColors.Control;
            this.solutionsLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.solutionsLabel.Location = new System.Drawing.Point(0, 150);
            this.solutionsLabel.Multiline = true;
            this.solutionsLabel.Name = "solutionsLabel";
            this.solutionsLabel.Size = new System.Drawing.Size(555, 2000);
            this.solutionsLabel.TabIndex = 3;
            this.solutionsLabel.TabStop = false;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // HomePanel
            // 
            this.HomePanel.Controls.Add(this.dButton);
            this.HomePanel.Controls.Add(this.eButton);
            this.HomePanel.Location = new System.Drawing.Point(180, 64);
            this.HomePanel.Name = "HomePanel";
            this.HomePanel.Size = new System.Drawing.Size(179, 100);
            this.HomePanel.TabIndex = 3;
            // 
            // dButton
            // 
            this.dButton.Location = new System.Drawing.Point(282, 251);
            this.dButton.Name = "dButton";
            this.dButton.Size = new System.Drawing.Size(75, 23);
            this.dButton.TabIndex = 1;
            this.dButton.Text = "Decrypt";
            this.dButton.UseVisualStyleBackColor = true;
            this.dButton.Click += new System.EventHandler(this.dButton_Click);
            // 
            // eButton
            // 
            this.eButton.Location = new System.Drawing.Point(142, 251);
            this.eButton.Name = "eButton";
            this.eButton.Size = new System.Drawing.Size(75, 23);
            this.eButton.TabIndex = 0;
            this.eButton.Text = "Encrypt";
            this.eButton.UseVisualStyleBackColor = true;
            this.eButton.Click += new System.EventHandler(this.eButton_Click);
            // 
            // EncryptPanel
            // 
            this.EncryptPanel.Controls.Add(this.cipherLabel);
            this.EncryptPanel.Controls.Add(this.encryptComboBox);
            this.EncryptPanel.Controls.Add(this.encryptedText);
            this.EncryptPanel.Controls.Add(this.label2);
            this.EncryptPanel.Controls.Add(this.label1);
            this.EncryptPanel.Controls.Add(this.encryptButton);
            this.EncryptPanel.Controls.Add(this.keyTextBox);
            this.EncryptPanel.Controls.Add(this.stringTextBox);
            this.EncryptPanel.Location = new System.Drawing.Point(39, 215);
            this.EncryptPanel.Name = "EncryptPanel";
            this.EncryptPanel.Size = new System.Drawing.Size(136, 134);
            this.EncryptPanel.TabIndex = 2;
            this.EncryptPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.EncryptPanel_Paint);
            // 
            // cipherLabel
            // 
            this.cipherLabel.AutoSize = true;
            this.cipherLabel.Location = new System.Drawing.Point(173, 43);
            this.cipherLabel.Name = "cipherLabel";
            this.cipherLabel.Size = new System.Drawing.Size(40, 13);
            this.cipherLabel.TabIndex = 8;
            this.cipherLabel.Text = "Cipher:";
            // 
            // encryptComboBox
            // 
            this.encryptComboBox.FormattingEnabled = true;
            this.encryptComboBox.Items.AddRange(new object[] {
            "Caesarean",
            "Vigenere"});
            this.encryptComboBox.Location = new System.Drawing.Point(173, 62);
            this.encryptComboBox.Name = "encryptComboBox";
            this.encryptComboBox.Size = new System.Drawing.Size(121, 21);
            this.encryptComboBox.TabIndex = 7;
            this.encryptComboBox.SelectedIndexChanged += new System.EventHandler(this.encryptComboBox_SelectedIndexChanged);
            // 
            // encryptedText
            // 
            this.encryptedText.BackColor = System.Drawing.SystemColors.Control;
            this.encryptedText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.encryptedText.Location = new System.Drawing.Point(4, 205);
            this.encryptedText.Name = "encryptedText";
            this.encryptedText.Size = new System.Drawing.Size(550, 13);
            this.encryptedText.TabIndex = 6;
            this.encryptedText.TabStop = false;
            this.encryptedText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.encryptedText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Shift key:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Text to encrypt:";
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(209, 171);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(75, 23);
            this.encryptButton.TabIndex = 2;
            this.encryptButton.Text = "Encrypt";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(267, 132);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(100, 20);
            this.keyTextBox.TabIndex = 1;
            // 
            // stringTextBox
            // 
            this.stringTextBox.Location = new System.Drawing.Point(117, 132);
            this.stringTextBox.Name = "stringTextBox";
            this.stringTextBox.Size = new System.Drawing.Size(100, 20);
            this.stringTextBox.TabIndex = 0;
            // 
            // DecryptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 502);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.EncryptPanel);
            this.Controls.Add(this.HomePanel);
            this.Controls.Add(this.DecryptPanel);
            this.Name = "DecryptionForm";
            this.Text = "Software";
            this.Load += new System.EventHandler(this.DecryptionForm_Load);
            this.DecryptPanel.ResumeLayout(false);
            this.DecryptPanel.PerformLayout();
            this.HomePanel.ResumeLayout(false);
            this.EncryptPanel.ResumeLayout(false);
            this.EncryptPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Panel HomePanel;
        private System.Windows.Forms.Button dButton;
        private System.Windows.Forms.Button eButton;
        private System.Windows.Forms.Panel EncryptPanel;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.TextBox stringTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox encryptedText;
        private System.Windows.Forms.TextBox solutionsLabel;
        private System.Windows.Forms.Label cipherLabel;
        private System.Windows.Forms.ComboBox encryptComboBox;
        private System.Windows.Forms.ComboBox decryptComboBox;
        private System.Windows.Forms.TextBox decryptKeyTextBox;
        private System.Windows.Forms.Label dKeyLabel;
        private System.Windows.Forms.Label dInputLabel;
        private System.Windows.Forms.Panel DecryptPanel;
    }
}

