using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckersGame
{
    public partial class Form1 :  ChessGameForm
    {

        public void Backup()
        {
            Console.WriteLine("\nCaretaker: Saving Originator's state...");
            this.Mementos.Add(this.Save());
        }

        public void Undo()
        {
            if (this.Mementos.Count == 0)
            {
                return;
            }

            var memento = this.Mementos.Last();
            this.Mementos.Remove(memento);



            try
            {
                this.Restore(memento);
            }
            catch (Exception)
            {
                this.Undo();
            }
        }

        public BindingList<ChessMomento> Mementos = new BindingList<ChessMomento>();
        public Form1()
        {
            InitializeComponent();

            this.Text = "Checkers";
            
            this.listBox1.DataSource = Mementos;
            listBox1.DisplayMember = "Name";
            //listBox1.Refresh();
            //listBox1.Update(); 
        } 


        protected override void onFigurePress(object sender, EventArgs e)
        {
            Backup();
            if (!Process(sender))
                Mementos.Remove(Mementos.Last());
            //listBox1.Refresh();
            //listBox1.Update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Undo();
            //listBox1.Refresh();
            //listBox1.Update();
        }
    }
}
