using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CheckersGame
{
    public class ChessSnapshot : ISnapshot
    {
        public ChessSnapshot(int[,] map, int currentPlayer, ButtonSnapshot[,] _buttons, Button _pressedButton
            , Button _prevButton, bool isMoving, bool isContinue)/*, List<ButtonSnapshot> simpleSteps*/
        {
            Map = map;
            CurrentPlayer = currentPlayer;
            Buttons = _buttons;
            PressedButton = _pressedButton;
            PrevButton = _prevButton;
            Date = DateTime.Now;
            this.IsMoving = isMoving;
            IsContinue = isContinue; 
            //SimpleSteps = simpleSteps;
        }

        public int[,] Map { get; set; }
        public int CurrentPlayer { get; set; }
        public ButtonSnapshot[,] Buttons { get; }
        public Button PressedButton { get; }
        public Button PrevButton { get; }
        public DateTime Date { get; set; }
        public bool IsContinue { get; set; }
        public bool IsMoving { get; set; }
        public string AccessibleDescription { get; set; }
        public List<ButtonSnapshot> SimpleSteps { get; set; }

    }
    
    public class ButtonSnapshot
    {
        public ButtonSnapshot(Button button)
        {
            BackColor = button.BackColor;
            Enabled = button.Enabled;
            Text = button.Text;
            Image = button.Image;
            AccessibleDescription = button.AccessibleDescription;
    }
        public string AccessibleDescription { get; set; }

        public Color BackColor  { get; set; }
        public bool Enabled { get; set; }
        public string Text { get; set; }
        public Image Image { get; set; } 

        public void RestoreTo(Button button)
        {
            button.Enabled = Enabled;
            button.BackColor = BackColor;
            button.Text = Text;
            button.Image = Image;
            button.AccessibleDescription = AccessibleDescription;
        } 
    }
}
