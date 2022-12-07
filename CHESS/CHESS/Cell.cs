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
    class Cell : PictureBox
    {
        private int RowNumber;
        private int ColumnNumber;

        public Cell(int x, int y,Color color)
        {
            RowNumber = x;
            ColumnNumber = y;
            BackColor = color;
        }

        public int returnRowNumber()
        {
            return RowNumber;
        }

        public int returnColumnNumber()
        {
            return ColumnNumber;
        }
        public void setPieces()
        {
            if(ColumnNumber==1)
                this.BackgroundImage= Image.FromFile("../../../pion1.png");
            if(ColumnNumber==6)
                this.BackgroundImage = Image.FromFile("../../../pion2.png");
            if (ColumnNumber == 0)
            {
                if (RowNumber == 0 || RowNumber == 7)
                    this.BackgroundImage = Image.FromFile("../../../tura1.png");

                else if(RowNumber == 1 || RowNumber == 6)
                    this.BackgroundImage = Image.FromFile("../../../cal1.png");

                else if(RowNumber == 2 || RowNumber == 5)
                    this.BackgroundImage = Image.FromFile("../../../nebun1.png");
                else if(RowNumber == 3)
                    this.BackgroundImage = Image.FromFile("../../../regina1.png");
                else
                    this.BackgroundImage = Image.FromFile("../../../rege1.png");
            }

            if(ColumnNumber == 7)
            {
                if (RowNumber == 0 || RowNumber == 7)
                    this.BackgroundImage = Image.FromFile("../../../tura2.png");

                else if (RowNumber == 1 || RowNumber == 6)
                    this.BackgroundImage = Image.FromFile("../../../cal2.png");

                else if (RowNumber == 2 || RowNumber == 5)
                    this.BackgroundImage = Image.FromFile("../../../nebun2.png");
                else if (RowNumber == 3)
                    this.BackgroundImage = Image.FromFile("../../../regina2.png");
                else
                    this.BackgroundImage = Image.FromFile("../../../rege2.png");
            }
            this.BackgroundImageLayout = ImageLayout.Center;
        }

    }
}
