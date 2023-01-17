using LogicGames.Memento;
using LogicGames.Sudoku;
using System.Text.RegularExpressions;

namespace LogicGames.Views;

partial class SudokuGame : Form
{
    SudokuBoard board = new SudokuBoard();

    public IMemento Save()
    {
        return new ConcreteMemento(board);
    }

    public SudokuGame(int difficulty, bool isMemento)
    {
        InitializeComponent();
        if (isMemento)
        {
            board = Caretaker.Undo().GetState();
        }
        else
        {
            board.Generate(difficulty);
        }
        int x = 0;
        int y = 0;

        foreach (var table in this.Controls.OfType<TableLayoutPanel>())
        {
            foreach (var table2 in table.Controls.OfType<TableLayoutPanel>())
            {
                foreach (TextBox tb in table2.Controls.OfType<TextBox>())
                {
                    tb.TextAlign = HorizontalAlignment.Center;
                    if (board[y, x] != 0)
                    {
                        tb.Text = board[y, x].ToString();
                        tb.ReadOnly = true;
                        tb.BackColor = Color.Gray;
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


    private void solveSudokuButton_Click(object sender, EventArgs e)
    {
        int x = 0;
        int y = 0;

        foreach (var table in this.Controls.OfType<TableLayoutPanel>())
        {
            foreach (var table2 in table.Controls.OfType<TableLayoutPanel>())
            {
                foreach (TextBox tb in table2.Controls.OfType<TextBox>())
                {
                    if (!tb.ReadOnly && tb.Text != String.Empty)
                    {
                        if (!Regex.IsMatch(tb.Text, @"^[1-9]$"))
                        {
                            MessageBox.Show("All fields must have a numeric value in 1-9 range", "Wrong input", MessageBoxButtons.OK);
                        }
                        else
                        {
                            if (board.validNumber(y, x, int.Parse(tb.Text)))
                            {
                                tb.ForeColor = Color.Green;
                                board[y, x] = int.Parse(tb.Text);
                            }
                            else
                            {
                                tb.ForeColor = Color.Red;
                            }
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
        if (board.IsSolved())
        {
            MessageBox.Show("You have successfully filled all the gaps.", "Congratulations!", MessageBoxButtons.OK);
        }
    }

    private void backToMainMenuButton_Click(object sender, EventArgs e)
    {
        if (!board.IsSolved())
        {
            ConcreteMemento memento = new ConcreteMemento(board);
            Caretaker.Backup(memento);
        }
        MainMenu menu = MainMenu.getInstance();
        menu.Show();
        Hide();
    }

    private void button1_Click(object sender, EventArgs e)
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
}
