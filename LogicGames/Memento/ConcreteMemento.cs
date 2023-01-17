using LogicGames.Sudoku;

namespace LogicGames.Memento
{
    class ConcreteMemento : IMemento
    {
        private SudokuBoard state;

        public ConcreteMemento(SudokuBoard state)
        {
            this.state = state;
        } 

        public SudokuBoard GetState()
        {
            return state;
        }
    }
}
