using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Form1 : Form
    {
        private string word;
        private int lives = 3;
        private int lettersGuessed = 0;
        private HashSet<char> diffLetters = new HashSet<char>();
        
        public Form1()
        {
            InitializeComponent();
            InitPanels();
            UpdateLives();
        }

        private void UpdateLives()
        {
            labLives.Text = "Lives = " + lives.ToString();
        }

        private void InitPanels()
        {
            this.panEnterWord.Enabled = this.panEnterWord.Visible = true;
            this.panel1.Enabled = false;
            this.panel2.Enabled = this.panel2.Visible = true;
            this.panel3.Enabled = this.panel3.Visible = true;
            UpdateLives();
            diffLetters.Clear();
            btnHint.Visible = true;
        }

        private void EnablePanels()
        {
            this.panEnterWord.Enabled = this.panEnterWord.Visible = false;
            this.panel1.Enabled = true;
        }

        private bool validateInput(string s)
        {
            if (s.Length != 0 && !s.Contains(" "))
            {
                int i;
                for (i = 0; i < s.Length && Char.IsLetter(s[i]); i++) ;
                fillSet(s);
                if (i == s.Length && diffLetters.Count > 1)
                {
                    return true;
                }
            }
            diffLetters.Clear();
            return false;
        }

        private bool validateGuess(string s)
        {
            if(s.Length != 0 && !s.Contains(" "))
            {
                int i;
                for (i = 0; i < s.Length && Char.IsLetter(s[i]); i++) ;
                if (i == s.Length)
                    {
                        return true;
                    }
            }
            return false;
        }

        private void fillSet(string s)
        {
            if (s.Length != 0 && !s.Contains(" "))
            {
                int i;
                for (i = 0; i < s.Length && Char.IsLetter(s[i]); i++)
                {
                    diffLetters.Add(s[i]);
                }
            }
        }

        private bool validateLetter(string s)
        {
            if(s.Length == 1 && Char.IsLetter(s[0]))
            {
                return true;
            }
            return false;
        }

        private void Reset(bool winCond)
        {
            if (winCond)
            {
                MessageBox.Show("You Win!!!");
            } else
            {
                MessageBox.Show("You Suck!!!");
            }
            lives = 3;
            lettersGuessed = 0;
            lbWord.Items.Clear();
            InitPanels();
        }

        private void confirmWord_Click(object sender, EventArgs e)
        {
            setWord.Text = setWord.Text.ToUpper();
            if(validateInput(setWord.Text))
            {
                word = setWord.Text;
                EnablePanels();
                for(int i = 0; i < word.Length; i++)
                {
                    lbWord.Items.Add("*");
                }
            } else
            {
                MessageBox.Show("Invalid String, Try Again.");
            }
            setWord.Clear();
        }

        private void btnTestLetter_Click(object sender, EventArgs e)
        {
            bool found = false;

            if (validateLetter(tbGuessLetter.Text))
            {
                tbGuessLetter.Text = tbGuessLetter.Text.ToUpper();
                if (diffLetters.Contains(tbGuessLetter.Text[0]))
                {
                    for (int i = 0; i < word.Length; i++)
                    {
                        if (word[i].ToString() == tbGuessLetter.Text)
                        {
                            lbWord.Items[i] = tbGuessLetter.Text;
                            found = true;
                            lettersGuessed++;
                            diffLetters.Remove(word[i]);
                        }
                    }
                }
                if (!found)
                {
                    lives--;
                    UpdateLives();
                }

            } else
            {
                MessageBox.Show("Invalid Letter, Try Again");
            }
            tbGuessLetter.Clear();

            if (lives == 0)
            {
                panel2.Enabled = panel2.Visible = false;
            }
            if(diffLetters.Count < 2)
            {
                btnHint.Visible = false;
            }
            if(lettersGuessed == word.Length)
            {
                Reset(true);
            }
        }

        private void btnTestWord_Click(object sender, EventArgs e)
        {
            if (validateGuess(tbGuessWord.Text))
            {
                tbGuessWord.Text = tbGuessWord.Text.ToUpper();
                if(word == tbGuessWord.Text)
                {
                    Reset(true);
                } else
                {
                    Reset(false);
                }
            }
            tbGuessWord.Clear();
        }

        private void btnHint_Click(object sender, EventArgs e)
        {
            Random randomNumber = new Random();
            int randomLetter = randomNumber.Next(diffLetters.Count);

            char letter = diffLetters.ElementAt(randomLetter);

            for (int i = 0; i < word.Length; i++)
            {
                if(letter == word[i])
                {
                    lbWord.Items[i] = letter;
                    lettersGuessed++;
                }
            }
            diffLetters.Remove(letter);
            btnHint.Visible = false;
        }
    }
}
