using System;
using System.Windows.Forms;

namespace MementoDesignPattern
{
    public partial class Form1 : Form
    {
        Editor originator = new Editor();
        History caretaker = new History();

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            originator.SetText(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            originator.GetText();
        }

        private void Undo_btn_Click(object sender, EventArgs e)
        {
            try
            {
                originator.RestoreFromMemento(caretaker.Undo());
                textBox1.Text = originator.GetText();

                ShowHistory();
            }
            catch (Exception)
            {
                MessageBox.Show("Nothing to undo!");
            }
        }

        private void Redo_btn_Click(object sender, EventArgs e)
        {
            try
            {
                originator.RestoreFromMemento(caretaker.Redo());
                textBox1.Text = originator.GetText();

                ShowHistory();
            }
            catch (Exception)
            {
                MessageBox.Show("Nothing to redo!");
            }
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            caretaker.AddMemento(originator.CreateMemento());
            textBox2.Text = originator.GetText();

            ShowHistory();
        }

        private void ShowHistory()
        {
            UndoStack_listBox.DataSource = caretaker.ShowUndoStack();
            RedoStack_listBox.DataSource = caretaker.ShowRedoStack();
        }

        private void ClearHistory_btn_Click(object sender, EventArgs e)
        {
            caretaker.ClearStacks();
            ShowHistory();
        }
    }
}
