using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    class Chessboard
    {
        public string Color;
        public void MakeCells()
        {

            int x;
            int y;
            int[,] arrayCells = new int[8, 8];
            for (x = 1; x <= 8; x++)
            {
                for(y = 8; y >= 1; y--)
                {
                    if(arrayCells[x,y] / 2 == 0 )
                    {
                        arrayCells[x, y] = Color.White;
                    }
                    else
                    {
                        arrayCells[x, y] = Color.Black;
                    }
                }
            }
        }
    }
}
