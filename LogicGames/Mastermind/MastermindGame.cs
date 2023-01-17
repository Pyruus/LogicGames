namespace LogicGames.Mastermind
{
    class MastermindGame
    {
        private int[] solution;
        public static Color[] colors = { Color.Green, Color.Blue, Color.Red, Color.Yellow, Color.Purple, Color.Black };

        public int[] GetSolution()
        {
            return solution;
        }

        public MastermindGame()
        {
            solution = new int[4];
            GenerateSolution();
            System.Diagnostics.Debug.WriteLine(solution[0]);
            System.Diagnostics.Debug.WriteLine(solution[1]);
            System.Diagnostics.Debug.WriteLine(solution[2]);
            System.Diagnostics.Debug.WriteLine(solution[3]);
        }

        private void GenerateSolution()
        {
            Random rng = new Random();

            solution[0] = rng.Next(6);
            solution[1] = rng.Next(6);
            solution[2] = rng.Next(6);
            solution[3] = rng.Next(6);
        }

        public int CheckExact(int[] code)
        {
            int exact = 0;
            for (int i = 0; i < 4; i++)
            {
                if(solution[i] == code[i])
                {
                    exact++;
                }
            }
            return exact;
        }

        public int CheckNear(int[] code)
        {
            int near = 0;
            List<int> found = new List<int>();
            for (int i = 0; i < 4; i++)
            {
                if (solution[i] == code[i])
                {
                    continue;
                }
                for (int j = 0; j < 4; j++)
                {
                    if (solution[i] == code[j] && !found.Contains(j))
                    {
                        if (i != j)
                        {
                            near++;
                        }
                        found.Add(j);
                        break;
                    }
                }
            }
            return near;
        }
    }
}
