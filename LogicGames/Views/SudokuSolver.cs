using LogicGames.Sudoku;
using System.Text.RegularExpressions;

namespace LogicGames.Views;

public partial class SudokuSolver : Form
{
    public SudokuSolver()
    {
        InitializeComponent();
    }

    private void solveSudokuButton_Click(object sender, EventArgs e)
    {
        SudokuBoard board = new SudokuBoard();

        System.Diagnostics.Debug.WriteLine("Working");

        int x = 0;
        int y = 0;

        foreach (var table in this.Controls.OfType<TableLayoutPanel>())
        {
            foreach (var table2 in table.Controls.OfType<TableLayoutPanel>())
            {
                foreach (TextBox tb in table2.Controls.OfType<TextBox>())
                {
                    if (tb.Text != String.Empty)
                    {
                        if (Regex.IsMatch(tb.Text, @"^[1-9]$"))
                        {
                            board[y, x] = int.Parse(tb.Text);
                        }
                        else
                        {
                            MessageBox.Show("All fields must have a numeric value in 1-9 range", "Can't solve", MessageBoxButtons.OK);
                            return;
                        }
                    }
                    x++;
                    if (x % 3 == 0)
                    {
                        y++;
                        if (y % 3 == 0)
                        {
                            if (x == 9)
                            {
                                x = 0;
                            }
                            else
                            {
                                y -= 3;
                            }
                        }
                        else
                        {
                            x -= 3;
                        }

                    }
                }
            }
        }
        if (!board.IsValid())
        {
            MessageBox.Show("Sudoku is not built correctly according to sudoku rules", "Can't solve", MessageBoxButtons.OK);
            return;
        }
        if (!board.Solve())
        {
            MessageBox.Show("Sudoku is unsolvable", "Can't solve", MessageBoxButtons.OK);
            return;
        }

        x = 0;
        y = 0;

        foreach (var table in this.Controls.OfType<TableLayoutPanel>())
        {
            foreach (var table2 in table.Controls.OfType<TableLayoutPanel>())
            {
                foreach (TextBox tb in table2.Controls.OfType<TextBox>())
                {
                    if (tb.Text == String.Empty)
                    {
                        tb.Text = board[y, x].ToString();
                        tb.ForeColor = Color.Green;
                    }
                    x++;
                    if (x % 3 == 0)
                    {
                        y++;
                        if (y % 3 == 0)
                        {
                            if (x == 9)
                            {
                                x = 0;
                            }
                            else
                            {
                                y -= 3;
                            }
                        }
                        else
                        {
                            x -= 3;
                        }

                    }
                }
            }
        }
    }

    private void backToMainMenuButton_Click(object sender, EventArgs e)
    {
        MainMenu menu = MainMenu.getInstance();
        menu.Show();
        Hide();
    }
}
