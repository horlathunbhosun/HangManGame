using Microsoft.VisualBasic.ApplicationServices;

namespace HangMan
{
    public partial class Form1 : Form
    {
        char[] wordToGuess = { '*', '*', '*', '*', '*', '*', '*' };
        char[] word = { 'H', 'E', 'L', 'L', 'O', 'M', 'E' };
        int attempts = 7;
        List<char> usedLetters = new List<char>();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtGuess.Text))
            {
                //check if the user has entered a letter

                char enteredCharacter = txtGuess.Text.ToUpper()[0];

                if (!char.IsLetter(enteredCharacter))
                {
                    MessageBox.Show("Please enter a letter.");
                    return;
                }

                if (usedLetters.Contains(enteredCharacter))
                {
                    MessageBox.Show($"You already guessed this letter: {enteredCharacter}. Try again.");
                    return;
                }

                usedLetters.Add(enteredCharacter);

                if (word.Contains(enteredCharacter))
                {
                    Replace(wordToGuess, word, enteredCharacter);
                }
                else
                {
                    attempts--;
                    UpdateHangmanImage();
                }

                UpdateWordDisplay();
                UpdateAttemptsDisplay();

                if (SameAs(wordToGuess, word))
                {
                    MessageBox.Show("YOU WON!!!!");
                    ResetGame();
                }
                else if (attempts == 0)
                {
                    MessageBox.Show($"You lost. The word was {new string(word)}.");
                    ResetGame();
                }
            }
            else
            {
                MessageBox.Show("Please enter a letter.");

            }

        }

        private void UpdateWordDisplay()
        {
            lblWordToGuess.Text = new string(wordToGuess);
        }

        private void UpdateAttemptsDisplay()
        {
            lblAttemptsLeft.Text = $"{attempts}";
        }


        private void UpdateHangmanImage()
        {
            string imagePath = $@"C:\Users\Horla\source\repos\HangMan\HangMan\Images\hang_{attempts}.bmp";
            Console.WriteLine(imagePath);

            MessageBox.Show(imagePath + "" + attempts);

            if (File.Exists(imagePath))
            {
                pbHangman.Image = Image.FromFile(imagePath);


            }
            else
            {
                pbHangman.Image = null; // If image not found, clear the picture box.
            }
        }

        public static bool SameAs(char[] wordToGuess, char[] word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (wordToGuess[i] != word[i])
                {
                    return false;
                }
            }
            return true;
        }

        public static void Replace(char[] wordToGuess, char[] word, char enteredCharacter)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == enteredCharacter)
                {
                    wordToGuess[i] = enteredCharacter;
                }
            }
        }

        private void ResetGame()
        {
            wordToGuess = new char[] { '*', '*', '*', '*', '*', '*', '*' };
            attempts = 7;
            usedLetters.Clear();
            UpdateWordDisplay();
            UpdateAttemptsDisplay();
            pbHangman.Image = null;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
