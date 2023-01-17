using LogicGames.Mastermind;
using System.ComponentModel.Design;
using System.Xml.Linq;

namespace LogicGames.Views;

public partial class Mastermind : Form
{
    private MastermindGame solution = new MastermindGame();
    private List<int> currentGuess = new List<int>();
    int turnCounter = 0;

    public Mastermind()
    {
        InitializeComponent();
    }

    private void guessGreen_Click(object sender, EventArgs e)
    {
        currentGuess.Add(0);
        int position = currentGuess.Count();
        if (position < 5)
        {
            string name = $"guess{position}";
            var button = this.Controls.Find(name, true);
            button[0].BackColor = Color.Green;
        }
    }

    private void guessBlue_Click(object sender, EventArgs e)
    {
        currentGuess.Add(1);
        int position = currentGuess.Count();
        if (position < 5)
        {
            string name = $"guess{position}";
            var button = this.Controls.Find(name, true);
            button[0].BackColor = Color.Blue;
        }
    }

    private void guessRed_Click(object sender, EventArgs e)
    {
        currentGuess.Add(2);
        int position = currentGuess.Count();
        if (position < 5)
        {
            string name = $"guess{position}";
            var button = this.Controls.Find(name, true);
            button[0].BackColor = Color.Red;
        }
    }

    private void guessYellow_Click(object sender, EventArgs e)
    {
        currentGuess.Add(3);
        int position = currentGuess.Count();
        if (position < 5)
        {
            string name = $"guess{position}";
            var button = this.Controls.Find(name, true);
            button[0].BackColor = Color.Yellow;
        }
    }

    private void guessPurple_Click(object sender, EventArgs e)
    {
        currentGuess.Add(4);
        int position = currentGuess.Count();
        if (position < 5)
        {
            string name = $"guess{position}";
            var button = this.Controls.Find(name, true);
            button[0].BackColor = Color.Purple;
        }
    }

    private void guessBlack_Click(object sender, EventArgs e)
    {
        currentGuess.Add(5);
        int position = currentGuess.Count();
        if (position < 5)
        {
            string name = $"guess{position}";
            var button = this.Controls.Find(name, true);
            button[0].BackColor = Color.Black;
        }
    }

    private void clearButton_Click(object sender, EventArgs e)
    {
        currentGuess.Clear();
        var button = this.Controls.Find("guess1", true);
        button[0].BackColor = Color.White;
        button = this.Controls.Find("guess2", true);
        button[0].BackColor = Color.White;
        button = this.Controls.Find("guess3", true);
        button[0].BackColor = Color.White;
        button = this.Controls.Find("guess4", true);
        button[0].BackColor = Color.White;
    }

    private void tryButton_Click(object sender, EventArgs e)
    {
        if (turnCounter >= 10)
        {
            return;
        }

        if (currentGuess.Count < 4)
        {
            MessageBox.Show("Fill all gaps", "Can't submit", MessageBoxButtons.OK);
            return;
        }

        var guess = currentGuess.ToArray();

        string firstButtonName = $"button{4+4*turnCounter}";
        string secondButtonName = $"button{3 + 4 * turnCounter}";
        string thirdButtonName = $"button{2 + 4 * turnCounter}";
        string fourthButtonName = $"button{1 + 4 * turnCounter}";
        string correctWrongName = $"cw{turnCounter + 1}";
        string correctCorrectName = $"cc{turnCounter + 1}";

        this.Controls.Find(firstButtonName, true)[0].BackColor = MastermindGame.colors[guess[0]];
        this.Controls.Find(secondButtonName, true)[0].BackColor = MastermindGame.colors[guess[1]];
        this.Controls.Find(thirdButtonName, true)[0].BackColor = MastermindGame.colors[guess[2]];
        this.Controls.Find(fourthButtonName, true)[0].BackColor = MastermindGame.colors[guess[3]];

        this.Controls.Find(correctWrongName, true)[0].Text = solution.CheckNear(guess).ToString();
        this.Controls.Find(correctCorrectName, true)[0].Text = solution.CheckExact(guess).ToString();

        

        turnCounter++;

        if(solution.CheckExact(guess) == 4)
        {
            MessageBox.Show("You have guessed correct color order!", "Congratulations!", MessageBoxButtons.OK);
        }
        else if(turnCounter == 10)
        {
            MessageBox.Show("You have failed to guess correct oder in 10 turns.", "Try again", MessageBoxButtons.OK);
            var btn = this.Controls.Find("guess1", true);
            btn[0].BackColor = MastermindGame.colors[solution.GetSolution()[0]];
            btn = this.Controls.Find("guess2", true);
            btn[0].BackColor = MastermindGame.colors[solution.GetSolution()[1]];
            btn = this.Controls.Find("guess3", true);
            btn[0].BackColor = MastermindGame.colors[solution.GetSolution()[2]];
            btn = this.Controls.Find("guess4", true);
            btn[0].BackColor = MastermindGame.colors[solution.GetSolution()[3]];
            this.Controls.Find("correctOrderLabel", true)[0].Visible = true;
            return;
        }

        currentGuess.Clear();
        var button = this.Controls.Find("guess1", true);
        button[0].BackColor = Color.White;
        button = this.Controls.Find("guess2", true);
        button[0].BackColor = Color.White;
        button = this.Controls.Find("guess3", true);
        button[0].BackColor = Color.White;
        button = this.Controls.Find("guess4", true);
        button[0].BackColor = Color.White;
    }

    private void backToMainMenuButton_Click(object sender, EventArgs e)
    {
        MainMenu menu = MainMenu.getInstance();
        menu.Show();
        Close();
    }
}
