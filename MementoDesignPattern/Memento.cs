namespace MementoDesignPattern
{
    class Memento : IMemento
    {
        private readonly string _text;

        public Memento(string text)
        {
            _text = text;
        }

        public string ShowText()
        {
            return _text;
        }
    }
}
