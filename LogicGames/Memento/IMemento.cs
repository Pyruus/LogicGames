using LogicGames.Sudoku;

namespace LogicGames.Memento
{
    interface IMemento
    {
        SudokuBoard GetState();
    }
}
