using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced.Collections
{
    class TextEditor
    {
        private Stack<string> undoStack;
        private Stack<string> redoStack;
        private string currentText;

        public TextEditor()
        {
            undoStack = new Stack<string>();
            redoStack = new Stack<string>();
            currentText = string.Empty;
        }

        public void DisplayText()
        {
            Console.WriteLine("Current Text: \"" + currentText + "\"");
        }

        public void TypeText(string newText)
        {
            undoStack.Push(currentText);
            currentText += newText;
            redoStack.Clear();
            Console.WriteLine("New text added.");
            DisplayText();
        }

        public void Undo()
        {
            if (undoStack.Count > 0)
            {
                redoStack.Push(currentText);
                currentText = undoStack.Pop();
                Console.WriteLine("Undo performed.");
            }
            else
            {
                Console.WriteLine("No more actions to undo.");
            }
            DisplayText();
        }

        public void Redo()
        {
            if (redoStack.Count > 0)
            {
                undoStack.Push(currentText);
                currentText = redoStack.Pop();
                Console.WriteLine("Redo performed.");
            }
            else
            {
                Console.WriteLine("No more actions to redo.");
            }
            DisplayText();
        }
    }
}
