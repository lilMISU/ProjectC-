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
   class Chessboard
    {
        private int Size;
        public Cell[,] theGrid;

        public Chessboard(int Size)
        {
            this.Size = Size;
            theGrid = new Cell[Size, Size];
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    if ((i + j) % 2 == 0)
                        theGrid[i,j]=new Cell(i,j,Color.BurlyWood);
                    else
                        theGrid[i, j] = new Cell(i, j, Color.Aquamarine);
                    theGrid[i, j].setPieces();
                }
            }
        }

        public int returnSize()
        {
            return Size;
        }
    }
}
