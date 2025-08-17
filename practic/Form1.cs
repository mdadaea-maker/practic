using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int g = 5;
        private void btnEncryptCaesar_Click(object sender, EventArgs e)
        {
            try
            {
                string text = txtInput.Text;
                int shift = (int)numShift.Value;

                if (string.IsNullOrEmpty(text))
                {
                    MessageBox.Show("Введите текст для шифрования!");
                    return;
                }

                string result = "";
                foreach (char c in text)
                {
                    if (char.IsLetter(c))
                    {
                        char offset = char.IsUpper(c) ? 'A' : 'a';
                        result += (char)(((c + shift - offset) % 26) + offset);
                    }
                    else
                    {
                        result += c;
                    }
                }

                txtOutput.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void btnDecryptCaesar_Click(object sender, EventArgs e)
        {
            try
            {
                string text = txtInput.Text;
                int shift = (int)numShift.Value;

                if (string.IsNullOrEmpty(text))
                {
                    MessageBox.Show("Введите текст для расшифровки!");
                    return;
                }

                string result = "";
                foreach (char c in text)
                {
                    if (char.IsLetter(c))
                    {
                        char offset = char.IsUpper(c) ? 'A' : 'a';
                        result += (char)(((c - shift - offset + 26) % 26) + offset);
                    }
                    else
                    {
                        result += c;
                    }
                }

                txtOutput.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void btnEncryptVigenere_Click(object sender, EventArgs e)
        {
            try
            {
                string text = txtInput.Text;
                string key = txtKey.Text;

                if (string.IsNullOrEmpty(text))
                {
                    MessageBox.Show("Введите текст для шифрования!");
                    return;
                }

                if (string.IsNullOrEmpty(key))
                {
                    MessageBox.Show("Введите ключ!");
                    return;
                }

                string result = "";
                key = key.ToUpper();
                int keyIndex = 0;

                foreach (char c in text)
                {
                    if (char.IsLetter(c))
                    {
                        char offset = char.IsUpper(c) ? 'A' : 'a';
                        int keyShift = key[keyIndex % key.Length] - 'A';
                        result += (char)(((c + keyShift - offset) % 26) + offset);
                        keyIndex++;
                    }
                    else
                    {
                        result += c;
                    }
                }

                txtOutput.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void btnDecryptVigenere_Click(object sender, EventArgs e)
        {
            try
            {
                string text = txtInput.Text;
                string key = txtKey.Text;

                if (string.IsNullOrEmpty(text))
                {
                    MessageBox.Show("Введите текст для расшифровки!");
                    return;
                }

                if (string.IsNullOrEmpty(key))
                {
                    MessageBox.Show("Введите ключ!");
                    return;
                }

                string result = "";
                key = key.ToUpper();
                int keyIndex = 0;

                foreach (char c in text)
                {
                    if (char.IsLetter(c))
                    {
                        char offset = char.IsUpper(c) ? 'A' : 'a';
                        int keyShift = key[keyIndex % key.Length] - 'A';
                        result += (char)(((c - keyShift - offset + 26) % 26) + offset);
                        keyIndex++;
                    }
                    else
                    {
                        result += c;
                    }
                }

                txtOutput.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
            txtOutput.Text = "";
            txtKey.Text = "";
            numShift.Value = 3;
        }
    }
}