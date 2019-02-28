//Group Six, Assignment 7 Tic-Tac-Toe Game
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_Game_Button_
{
    class VM : INotifyPropertyChanged
    {
        private int turn = 1;
        private int[,] click = new int[,] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
        const int MODULUS = 2;

        public int[,] getClick()
        {
            return click;
        }

        #region Property
        //Property for button content
        private string textOne = "";
        public string TextOne
        {
            get { return textOne; }
            set { textOne = value; NotifyChanged(); }
        }

        private string textTwo = "";
        public string TextTwo
        {
            get { return textTwo; }
            set { textTwo = value; NotifyChanged(); }
        }

        private string textThree = "";
        public string TextThree
        {
            get { return textThree; }
            set { textThree = value; NotifyChanged(); }
        }

        private string textFour = "";
        public string TextFour
        {
            get { return textFour; }
            set { textFour = value; NotifyChanged(); }
        }

        private string textFive = "";
        public string TextFive
        {
            get { return textFive; }
            set { textFive = value; NotifyChanged(); }
        }

        private string textSix = "";
        public string TextSix
        {
            get { return textSix; }
            set { textSix = value; NotifyChanged(); }
        }

        private string textSeven = "";
        public string TextSeven
        {
            get { return textSeven; }
            set { textSeven = value; NotifyChanged(); }
        }

        private string textEight = "";
        public string TextEight
        {
            get { return textEight; }
            set { textEight = value; NotifyChanged(); }
        }

        private string textNine = "";
        public string TextNine
        {
            get { return textNine; }
            set { textNine = value; NotifyChanged(); }
        }

        //property to show who's turn
        private string displayTurn = "";
        public string DisplayTurn
        {
            get { return displayTurn; }
            set { displayTurn = value; NotifyChanged(); }
        }
        //property to display game result
        private string labelResult = "";
        public string LabelResult
        {
            get { return labelResult; }
            set { labelResult = value; NotifyChanged(); }
        }
        #endregion

        #region Logic
        //Display each button's content and check who's turn and game result when click it
        public void Button1Click(int click)
        {
            if (click == 0)
            {
                if (turn % MODULUS != 0)
                {
                    TextOne = "X";
                    click++;
                }
                else
                {
                    TextOne = "O";
                    click++;
                }
                turn++;
            }
            else
            {
                TextOne = TextOne;
            }
            DisplayTurns();
            CheckResult();
        }

        public void Button2Click(int click)
        {
            if (click == 0)
            {
                if (turn % MODULUS != 0)
                {
                    TextTwo = "X";
                    click++;
                }
                else
                {
                    TextTwo = "O";
                    click++;
                }
                turn++;
            }
            else
            {
                TextTwo = TextTwo;
            }
            DisplayTurns();
            CheckResult();
        }

        public void Button3Click(int click)
        {
            if (click == 0)
            {
                if (turn % MODULUS != 0)
                {
                    TextThree = "X";
                    click++;
                }
                else
                {
                    TextThree = "O";
                    click++;
                }
                turn++;
            }
            else
            {
                TextThree = TextThree;
            }
            DisplayTurns();
            CheckResult();
        }

        public void Button4Click(int click)
        {
            if (click == 0)
            {
                if (turn % MODULUS != 0)
                {
                    TextFour = "X";
                    click++;
                }
                else
                {
                    TextFour = "O";
                    click++;
                }
                turn++;
            }
            else
            {
                TextFour = TextFour;
            }
            DisplayTurns();
            CheckResult();
        }

        public void Button5Click(int click)
        {
            if (click == 0)
            {
                if (turn % MODULUS != 0)
                {
                    TextFive = "X";
                    click++;
                }
                else
                {
                    TextFive = "O";
                    click++;
                }
                turn++;
            }
            else
            {
                TextFive = TextFive;
            }
            DisplayTurns();
            CheckResult();
        }

        public void Button6Click(int click)
        {
            if (click == 0)
            {
                if (turn % MODULUS != 0)
                {
                    TextSix = "X";
                    click++;
                }
                else
                {
                    TextSix = "O";
                    click++;
                }
                turn++;
            }
            else
            {
                TextSix = TextSix;
            }
            DisplayTurns();
            CheckResult();
        }

        public void Button7Click(int click)
        {
            if (click == 0)
            {
                if (turn % MODULUS != 0)
                {
                    TextSeven = "X";
                    click++;
                }
                else
                {
                    TextSeven = "O";
                    click++;
                }
                turn++;
            }
            else
            {
                TextSeven = TextSeven;
            }
            DisplayTurns();
            CheckResult();
        }

        public void Button8Click(int click)
        {
            if (click == 0)
            {
                if (turn % MODULUS != 0)
                {
                    TextEight = "X";
                    click++;
                }
                else
                {
                    TextEight = "O";
                    click++;
                }
                turn++;
            }
            else
            {
                TextEight = TextEight;
            }
            DisplayTurns();
            CheckResult();
        }

        public void Button9Click(int click)
        {
            if (click == 0)
            {
                if (turn % MODULUS != 0)
                {
                    TextNine = "X";
                    click++;
                }
                else
                {
                    TextNine = "O";
                    click++;
                }
                turn++;
            }
            else
            {
                TextNine = TextNine;
            }
            DisplayTurns();
            CheckResult();
        }

        //Display whose turn is
        public void DisplayTurns()
        {
            if (turn % MODULUS != 0)
            {
                DisplayTurn = "Player 1";
            }
            else
            {
                DisplayTurn = "Player 2";
            }
        }

        //Check the result of this game
        public void CheckResult()
        {
            //first row
            if (TextOne != "" && TextTwo != "" && TextThree != "")
            {
                if (TextOne == TextTwo && TextTwo == TextThree)
                {
                    if (TextOne == "X")
                    {
                        LabelResult = "X Wins!";
                    }
                    else
                    {
                        LabelResult = "O Wins!";
                    }
                }
            }
            //second row
            if (TextFour != "" && TextFive != "" && TextSix != "")
            {
                if (TextFour == TextFive && TextFive == TextSix)
                {
                    if (TextFour == "X")
                    {
                        LabelResult = "X Wins!";
                    }
                    else
                    {
                        LabelResult = "O Wins!";
                    }
                }
            }
            //third row
            if (TextSeven != "" && TextEight != "" && TextNine != "")
            {
                if (TextSeven == TextEight && TextEight == TextNine)
                {
                    if (TextSeven == "X")
                    {
                        LabelResult = "X Wins!";
                    }
                    else
                    {
                        LabelResult = "O Wins!";
                    }
                }
            }
            //first column
            if (TextOne != "" && TextFour != "" && TextSeven != "")
            {
                if (TextOne == TextFour && TextFour == TextSeven)
                {
                    if (TextOne == "X")
                    {
                        LabelResult = "X Wins!";
                    }
                    else
                    {
                        LabelResult = "O Wins!";
                    }
                }
            }
            //second column
            if (TextTwo != "" && TextFive != "" && TextEight != "")
            {
                if (TextTwo == TextFive && TextFive == TextEight)
                {
                    if (TextTwo == "X")
                    {
                        LabelResult = "X Wins!";
                    }
                    else
                    {
                        LabelResult = "O Wins!";
                    }
                }
            }
            //third column
            if (TextThree != "" && TextSix != "" && TextNine != "")
            {
                if (TextThree == TextSix && TextSix == TextNine)
                {
                    if (TextThree == "X")
                    {
                        LabelResult = "X Wins!";
                    }
                    else
                    {
                        LabelResult = "O Wins!";
                    }
                }
            }
            //diagonal column
            if (TextOne != "" && TextFive != "" && TextNine != "")
            {
                if (TextOne == TextFive && TextOne == TextNine)
                {
                    if (TextOne == "X")
                    {
                        LabelResult = "X Wins!";
                    }
                    else
                    {
                        LabelResult = "O Wins!";
                    }
                }
            }
            //diagonal column
            if (TextThree != "" && TextFive != "" && TextSeven != "")
            {
                if (TextThree == TextFive && TextThree == TextSeven)
                {
                    if (TextThree == "X")
                    {
                        LabelResult = "X Wins!";
                    }
                    else
                    {
                        LabelResult = "O Wins!";
                    }
                }
            }
            //tie situation
            if (TextOne != "" && TextTwo != "" && TextThree != "" && TextFour != "" && TextFive != "" && TextSix != "" && TextSeven != "" && TextEight != "" && TextNine != "")
            {
                    LabelResult = "It's a tie";                
            }
        }

        //Clear currant game to start a new one
        public void NewGame()
        {
            DisplayTurn = "";
            turn = 1;
            for(int i = 0; i < click.GetLength(0); i++)
            {
                for(int j = 0; j < click.GetLength(1); j++)
                {
                    click[i,j] = 0;
                }               
            }
            TextOne = "";
            TextTwo = "";
            TextThree = "";
            TextFour = "";
            TextFive = "";
            TextSix = "";
            TextSeven = "";
            TextEight = "";
            TextNine = "";
            LabelResult = "";
        }
        #endregion

        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion
    }
}
