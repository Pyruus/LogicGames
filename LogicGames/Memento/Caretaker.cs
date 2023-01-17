namespace LogicGames.Memento
{
    static class Caretaker
    {
        private static List<IMemento> mementos = new List<IMemento>();

        public static void Backup(IMemento memento)
        {
            if (mementos.Count != 0)
            {
                mementos.Clear();
            }
            mementos.Add(memento);
        }

        public static IMemento Undo()
        {
            if (mementos.Count == 0)
            {
                return null;
            }
            var memento = mementos.Last();
            mementos.Clear();
            return memento;
        }

        public static int Count()
        {
            return mementos.Count();
        }
    }
}
