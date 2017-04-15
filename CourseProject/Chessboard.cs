using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    class Chessboard : Cell
    {
        public override void MakeCells(Cell ArrayCell)
        {
            int x = ArrayCell.CoordinateX;
            int y = ArrayCell.CoordinateY;
            int[,] arrayCells = new int[8, 8];
            for (x = 1; x <= 8; x++)
            {
                for(y = 1; y <= 8; y++)
                {
                   // if()
                }
            }
        }
    }
}
