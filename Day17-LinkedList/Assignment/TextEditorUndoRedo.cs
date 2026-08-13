using System;

namespace Assignment
{
    class TextNode
    {
        public string Text;
        public TextNode Next;
        public TextNode Prev;

        public TextNode(string text)
        {
            Text = text;
        }
    }

    class TextEditorUndoRedo
    {
        private TextNode current;
        private int count;
        private const int MaxHistory = 10;

        public void AddState(string text)
        {
            TextNode newNode = new TextNode(text);

            if (current != null)
            {
                current.Next = newNode;
                newNode.Prev = current;
            }

            current = newNode;
            count++;

            RemoveOldest();
        }

        public void Undo()
        {
            if (current == null || current.Prev == null)
            {
                Console.WriteLine("Nothing to undo");
                return;
            }

            current = current.Prev;
            Console.WriteLine("Undo successful");
        }

        public void Redo()
        {
            if (current == null || current.Next == null)
            {
                Console.WriteLine("Nothing to redo");
                return;
            }

            current = current.Next;
            Console.WriteLine("Redo successful");
        }

        public void DisplayCurrentState()
        {
            if (current == null)
            {
                Console.WriteLine("No text available");
                return;
            }

            Console.WriteLine($"Current Text : {current.Text}");
        }

        private void RemoveOldest()
        {
            if (count <= MaxHistory)
                return;

            TextNode oldest = current;

            while (oldest.Prev != null)
            {
                oldest = oldest.Prev;
            }

            oldest.Next.Prev = null;
            count--;
        }
    }
}