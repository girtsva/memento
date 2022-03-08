using System.Collections.Generic;

namespace MementoDesignPattern
{
    public class History  // originally - Caretaker
    {
        private readonly Stack<IMemento> _undoStack = new Stack<IMemento>();
        private readonly Stack<IMemento> _redoStack = new Stack<IMemento>();

        public void AddMemento(IMemento memento)  // Save to Undo Stack
        {
            _undoStack.Push(memento);
        }

        public IMemento Undo() // Get Memento from Undo Stack; Save to Redo Stack
        {
            var undoValue = _undoStack.Pop();
            _redoStack.Push(undoValue);
            return undoValue;
        }

        public IMemento Redo() // Get Memento from Redo Stack; Save to Undo Stack
        {
            var redoValue = _redoStack.Pop();
            _undoStack.Push(redoValue);
            return redoValue;
        }

        public List<string> ShowUndoStack()
        {
            List<string> undoValues = new List<string>();
            foreach (var memento in _undoStack)
            {
                undoValues.Add(memento.ShowText());
            }
            
            return undoValues;
        }

        public List<string> ShowRedoStack()
        {
            List<string> redoValues = new List<string>();
            foreach (var memento in _redoStack)
            {
                redoValues.Add(memento.ShowText());
            }

            return redoValues;
        }

        public void ClearStacks()
        {
            _undoStack.Clear();
            _redoStack.Clear();
        }
    }
}
