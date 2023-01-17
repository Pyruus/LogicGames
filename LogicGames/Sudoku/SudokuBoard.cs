using System;

namespace LogicGames.Sudoku
{
    class SudokuBoard
    {
        private int[,] board;
        private int[,] solved_board = new int[9,9];


        public SudokuBoard()
        {
            board = new int[9,9];
        }

        public int this[int x, int y]
        {
            get => board[x, y];
            set => board[x, y] = value;
        }

        public bool IsValid()
        {
            for (int i = 0; i < 9; i++)
            {
                HashSet<int> rows = new HashSet<int>();
                HashSet<int> cols = new HashSet<int>();
                HashSet<int> square = new HashSet<int>();
                for (int j = 0; j < 9; j++)
                {
                    if (board[i, j] != 0 && !rows.Add(board[i, j]))
                        return false;
                    if (board[j, i] != 0 && !cols.Add(board[j, i]))
                        return false;

                    int row = (i / 3) * 3 + j / 3;
                    int col = (i % 3) * 3 + j % 3;
                    if (board[row, col] != 0 && !square.Add(board[row, col]))
                        return false;
                }
            }
            return true;
        }

        public void PrintBoard()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    System.Diagnostics.Debug.Write(board[i, j] + " ");
                }
                System.Diagnostics.Debug.WriteLine("");
            }
        }

        public bool Solve()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (board[i, j] == 0)
                    {
                        for (int k = 1; k <= 9; k++)
                        {
                            board[i, j] = k;
                            if (IsValid() && Solve())
                                return true;
                            board[i, j] = 0;
                        }
                        return false;
                    }
                }
            }
            return true;
        }

        public void Generate(int difficulty)
        {
            Random rng = new Random();
            do
            {
                int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

                Shuffle(numbers);
                for (int i = 0; i < 9; i++)
                {
                    board[i, 0] = numbers[i];
                }
                numbers = numbers.Where(val => val != numbers[0]).ToArray();
                Shuffle(numbers);
                for (int i = 3; i < 9; i++)
                {
                    board[0, i] = numbers[i - 1];
                }
            } while (!Solve());
            for (int i=0; i<9; i++)
            {
                for (int j=0; j<9; j++)
                {
                    solved_board[i, j] = board[i, j];
                }
            }
            PrintBoard();
            DeleteRandomCells(difficulty);
        }

        public bool validNumber(int x, int y, int num)
        {
            System.Diagnostics.Debug.WriteLine(solved_board[x, y]);
            return (num == solved_board[x, y]);
        }

        private void DeleteRandomCells(int count)
        {
            var random = new Random();

            for (int i = 0; i < count; i++)
            {
                int row = random.Next(9);
                int col = random.Next(9);
                board[row, col] = 0;
            }
        }

        private void Shuffle(int[] array)
        {
            var rng = new Random();
            int n = array.Length;
            while (n > 1)
            {
                int k = rng.Next(n--);
                int temp = array[n];
                array[n] = array[k];
                array[k] = temp;
            }
        }

        public bool IsSolved()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (board[i, j] == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
