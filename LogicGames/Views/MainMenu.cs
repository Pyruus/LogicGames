using LogicGames.Memento;
using System.Runtime.CompilerServices;

namespace LogicGames.Views;

public partial class MainMenu : Form
{
    public static MainMenu singleton = null;

    private MainMenu()
    {
        InitializeComponent();
    }

    public static MainMenu getInstance()
    {
        if (singleton == null)
        {
            singleton = new MainMenu();
        }
        if (Caretaker.Count() > 0)
        {
            singleton.Controls.Find("continueSudokuGame", true)[0].Visible = true;
        }
        else
        {
            singleton.Controls.Find("continueSudokuGame", true)[0].Visible = false;
        }
        return singleton;
    }

    private void solverRedirectButton_Click(object sender, EventArgs e)
    {
        SudokuSolver solver = new SudokuSolver();
        solver.Show();
        Hide();
    }

    private void sudokuGameRedirectButton_Click(object sender, EventArgs e)
    {
        SudokuGame game = new SudokuGame(35, false);
        game.Show();
        Hide();
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
        SudokuGame game = new SudokuGame(60, false);
        game.Show();
        Hide();
    }

    private void playMastermindRedirect_Click(object sender, EventArgs e)
    {
        Mastermind game = new Mastermind();
        game.Show();
        Hide();
    }

    private void continueSudokuGame_Click(object sender, EventArgs e)
    {
        SudokuGame game = new SudokuGame(0, true);
        game.Show();
        Hide();
    }
}
