using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    class Chessboard
    {
        public Cell arrayCells;
        public void MakeCells()
        {

            arrayCells = new Cell[64];
            for (int i = 0; i <= 63; i++)
            {
                arrayCells[i] = new Cell();
                if(i%2 == 0)
                {
                    arrayCells[i].Color = string.White;
                }
                else
                {
                    arrayCells[i].Color = string.Black;
                }
            }
            Cell X = new Cell();
            Cell Y = new Cell();
            int x = X.CoordinateX;
            int y = Y.CoordinateY;
            for (int j = 0; j <= 63; j++)
            {
                if (j % 8 == 0)
                {
                    y = y + 1;
                    x = 1;
                }
            }  
        }
    }
}
