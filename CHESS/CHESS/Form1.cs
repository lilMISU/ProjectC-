using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHESS
{
    public partial class Form1 : Form
    {

        static Chessboard myBoard = new Chessboard(8);
        public Image[,] previous = new Image[myBoard.returnSize(), myBoard.returnSize()];
        public bool getPiece=false;
        Image img = null;
        int prevX;
        int prevY;

        public Form1()
        {
            InitializeComponent();
            initializeBoard();
  
        }

   
        private void initializeBoard()
        {
            int buttonSize = panel2.Width / myBoard.returnSize();
            panel2.Height = panel2.Width;

            for(int i=0;i<myBoard.returnSize();i++)
                for (int j = 0; j < myBoard.returnSize(); j++)
                {
                    
                    myBoard.theGrid[i, j].Height = buttonSize;
                    myBoard.theGrid[i, j].Width = buttonSize;
                    myBoard.theGrid[i, j].Click += new EventHandler(this.btn_Click);
                    panel2.Controls.Add(myBoard.theGrid[i, j]);
                    myBoard.theGrid[i, j].Location = new Point(i * buttonSize, j * buttonSize);
                    
                    
                }

        }

       

        private void btn_Click(object sender,EventArgs e)
       {
           
            Cell clickedButton = (Cell)sender;
            if (getPiece == false)
            {
                if (clickedButton.BackgroundImage != null)
                {
                    getPiece = true;
                    img = clickedButton.BackgroundImage;
                }
                prevX = clickedButton.returnRowNumber(); 
                prevY = clickedButton.returnColumnNumber();
                for (int i = 0; i < 8; i++)
                    for (int j = 0; j < 8; j++)
                        previous[i, j] = myBoard.theGrid[i, j].BackgroundImage;
            }
            else
            {
                clickedButton.BackgroundImage = img;
                clickedButton.BackgroundImageLayout = ImageLayout.Center;
                myBoard.theGrid[prevX, prevY].BackgroundImage = null;
                getPiece = false;

            }

       }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i=0;i<8;i++)
                for(int j=0;j<8;j++)
               myBoard.theGrid[i,j].BackgroundImage = previous[i,j];
        }
    }
}
