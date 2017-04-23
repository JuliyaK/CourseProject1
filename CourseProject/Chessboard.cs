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
            int x = 0;
            int y = 0;

            arrayCells = new Cell[64];
            for (int i = 0; i <= 63; i++)
            {
                arrayCells[i] = new Cell();
                if(i%2 == 0)
                {
                    arrayCells[i].Color = "White";
                }
                else
                {
                    arrayCells[i].Color = "Blak";
                }
                if(i % 8 == 0)
                {
                    y = y + 1;
                    x = 1;
                }
                x++;
                arrayCells[i].CoordinateX = "x";
                arrayCells[i].CoordinateY = "y";
            }
        }
    }
}
