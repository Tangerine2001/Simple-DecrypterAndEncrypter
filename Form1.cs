using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecryptionSoftware
{
    public partial class DecryptionForm : Form
    {
        string output = "";
        List<string> alphabet = new List<string>{"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"};

        public DecryptionForm()
        {
            InitializeComponent();
            backButton.Visible = false;
            EncryptPanel.Visible = false;
            EncryptPanel.Dock = DockStyle.Fill;
            EncryptPanel.Dock = DockStyle.Left;
            encryptedText.TextAlign = HorizontalAlignment.Center;
            DecryptPanel.Visible = false;
            DecryptPanel.Dock = DockStyle.Right;
            solutionsLabel.TextAlign = HorizontalAlignment.Center;
            HomePanel.Visible = true;
            HomePanel.Dock = DockStyle.Fill;
            HomePanel.Controls.Add(eButton);
            HomePanel.Controls.Add(dButton);
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            if (decryptComboBox.SelectedItem.ToString() == "Caesarean")
            {
                output = "";

                for (int i = 1; i < 26; i++)
                {
                    string answer = decryptCaesar(inputTextBox.Text, i);
                    output = output + answer + Environment.NewLine;
                }

                solutionsLabel.Multiline = true;
                solutionsLabel.Width = DecryptPanel.Width;
                solutionsLabel.Text = output;
            }
            else
            {
                
                solutionsLabel.Text = decryptVigenere(inputTextBox.Text, decryptKeyTextBox.Text);
            }
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            if (encryptComboBox.SelectedItem.ToString() == "Caesarean")
            {
                encryptCaesarCipher();
            }
            else if (encryptComboBox.SelectedItem.ToString() == "Vigenere")
            {
                encryptVigenereCipher();
            }
        }

        public void encryptCaesarCipher()
        {
            int check;
            if (!int.TryParse(keyTextBox.Text, out check))
            {
                label2.Text = "Shift Key: *Please input numbers only";
            }
            else
            {
                label2.Text = "Shift Key:";
                encryptedText.Text = encryptCaesar(stringTextBox.Text, Convert.ToInt32(keyTextBox.Text));
            }
        }

        public void encryptVigenereCipher()
        {
            int check = 0;
            if (int.TryParse(keyTextBox.Text, out check))
            {
                label2.Text = "Shift Key: *Please input a string only";
            }
            else
            {
                label2.Text = "Shift Key:";
                encryptedText.Text = encryptVigenere(stringTextBox.Text, keyTextBox.Text);
            }
        }

        public string decryptCaesar(string text, int key)
        {
            int index;
            int keyIndex;
            string outputChar;
            string outputString = "";


            for (int i = 0; i < text.Length; i++)
            {
                if (!alphabet.Where(x => string.Equals(text[i].ToString(), x, StringComparison.InvariantCultureIgnoreCase)).Any())
                {
                    outputString = outputString + text[i].ToString();
                }
                else
                {
                    index = alphabet.FindIndex(x => x.Equals(text[i].ToString(), StringComparison.InvariantCultureIgnoreCase));
                    keyIndex = index + key;
                    if (keyIndex > 25)
                    {
                        keyIndex = keyIndex - 26;
                    }
                    outputChar = alphabet[keyIndex];
                    outputString = outputString + outputChar;
                }
            }
            return outputString;
        }

        public string encryptCaesar(string text, int key)
        {
            int index;
            int keyIndex;
            string outputChar;
            string outputString = "";

            for (int i = 0; i < text.Length; i++)
            {
                if (!alphabet.Where(x => string.Equals(text[i].ToString(), x, StringComparison.InvariantCultureIgnoreCase)).Any())
                {
                    outputString = outputString + text[i].ToString();
                }
                else
                {
                    index = alphabet.FindIndex(x => x.Equals(text[i].ToString(), StringComparison.InvariantCultureIgnoreCase));
                    keyIndex = index + (key % 26);
                    if (keyIndex > 25)
                    {
                        keyIndex = keyIndex - 26;
                    }
                    outputChar = alphabet[keyIndex];
                    outputString = outputString + outputChar;
                }
            }
            return outputString;
        }

        public string decryptVigenere(string text, string key)
        {
            if (testProperKey(key))
            {
                string output = "";
                int offset = 0;
                for (int i = 0; i < text.Length; i++)
                {
                    if (!alphabet.Where(x => string.Equals(text[i].ToString(), x, StringComparison.InvariantCultureIgnoreCase)).Any())
                    {
                        output = output + text[i].ToString();
                        offset++;
                    }
                    else
                    {
                        int textIndex = alphabet.FindIndex(x => x.Equals(text[i].ToString(), StringComparison.InvariantCultureIgnoreCase));
                        int keyIndex = alphabet.FindIndex(x => x.Equals(key[Math.Abs(i - offset) % key.Length].ToString(), StringComparison.InvariantCultureIgnoreCase));
                        int alphabetIndex = textIndex - keyIndex;
                        if (alphabetIndex < 0)
                        {
                            output = output + alphabet[(alphabetIndex + 26) % 26];
                        }
                        else
                        {
                            output = output + alphabet[alphabetIndex % 26];
                        }
                    }

                }
                return output;
            }
            else
            {
                return "Enter a valid key. No spaces, punctuations, or symbols.";
            }
        }

        public string encryptVigenere(string text, string key)
        {
            if (testProperKey(key))
            {
                string output = "";
                int offset = 0;
                for (int i = 0; i < text.Length; i++)
                {
                    if (!alphabet.Where(x => string.Equals(text[i].ToString(), x, StringComparison.InvariantCultureIgnoreCase)).Any())
                    {
                        output = output + text[i].ToString();
                        offset++;
                    }
                    else
                    {
                        int textIndex = alphabet.FindIndex(x => x.Equals(text[i].ToString(), StringComparison.InvariantCultureIgnoreCase));
                        int keyIndex = alphabet.FindIndex(x => x.Equals(key[Math.Abs(i - offset) % key.Length].ToString(), StringComparison.InvariantCultureIgnoreCase));
                        output = output + alphabet[(textIndex + keyIndex) % 26];
                    }

                }
                return output;
            }
            else
            {
                return "Enter a valid key. No spaces, punctuations, or symbols.";
            }
        }

        public bool testProperKey(string key)
        {
            for (int i = 0; i < key.Length; i++)
            {
                string k = key[i].ToString();
                if (!alphabet.Where(x => string.Equals(key[i].ToString(), x, StringComparison.InvariantCultureIgnoreCase)).Any())
                {
                    return false;
                }
            }
            return true;
        }

        private void dButton_Click(object sender, EventArgs e)
        {
            backButton.Visible = true;
            DecryptPanel.Visible = true;
            DecryptPanel.Dock = DockStyle.Fill;
            EncryptPanel.Visible = false;
            EncryptPanel.Dock = DockStyle.Left;
            HomePanel.Visible = false;
            HomePanel.Dock = DockStyle.Top;
            inputTextBox.Location = new Point(215, 42);
            decryptButton.Location = new Point(227, 88);
            dInputLabel.Visible = false;
            dKeyLabel.Visible = false;
            decryptKeyTextBox.Visible = false;
            decryptComboBox.SelectedItem = "Caesarean";
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            backButton.Visible = false;
            EncryptPanel.Visible = false;
            EncryptPanel.Dock = DockStyle.Left;
            DecryptPanel.Visible = false;
            DecryptPanel.Dock = DockStyle.Right;
            HomePanel.Visible = true;
            HomePanel.Dock = DockStyle.Fill;
            stringTextBox.Text = "";
            keyTextBox.Text = "";
            solutionsLabel.Text = "";
            encryptedText.Text = "";
            decryptKeyTextBox.Text = "";
            inputTextBox.Text = "";
        }

        private void eButton_Click(object sender, EventArgs e)
        {
            backButton.Visible = true;
            EncryptPanel.Visible = true;
            EncryptPanel.Dock = DockStyle.Fill;
            DecryptPanel.Visible = false;
            DecryptPanel.Dock = DockStyle.Right;
            HomePanel.Visible = false;
            HomePanel.Dock = DockStyle.Top;
            encryptComboBox.SelectedItem = "Caesarean";
            encryptedText.Size = new Size(EncryptPanel.Width, EncryptPanel.Height);
        }

        private void decryptComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (decryptComboBox.SelectedItem.ToString() == "Vigenere")
            {
                inputTextBox.Location = new Point(152, 81);
                decryptButton.Location = new Point(227, 107);
                dInputLabel.Visible = true;
                dKeyLabel.Visible = true;
                decryptKeyTextBox.Visible = true;
            } 
            else
            {
                inputTextBox.Location = new Point(215, 42);
                decryptButton.Location = new Point(227, 88);
                dInputLabel.Visible = false;
                dKeyLabel.Visible = false;
                decryptKeyTextBox.Visible = false;
            }
        }
    }
}
