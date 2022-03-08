namespace MementoDesignPattern
{
    public class Editor  // originally - Originator
    {
        private string _text;

        public void SetText(string text)
        {
            _text = text;
        }

        public string GetText()
        {
            return _text;
        }

        public IMemento CreateMemento()
        {
            return new Memento(_text);
        }

        public void RestoreFromMemento(IMemento memento)
        {
            _text = memento.ShowText();
        }
    }
}
