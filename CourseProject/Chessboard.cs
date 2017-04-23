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
                if(i%8 == 0)
                {
                    y = y + 1;
                    x = 1;
                }
                x++;
                arrayCells[i].CoordinateX = x;
                arrayCells[i].CoordinateY = y;
            }
        }
        public void LocationFigures()
        {
            arrayCells[i].CoordinateX = x;
            arrayCells[i].CoordinateY = y;
            Figure figure = null;
            for(int i = 0; i <= 63; i++)
            {

                if((x == 1 && y == 1) || (x == 1 && y == 8) || (x == 8 && y == 1) || (x == 8 && y == 8))
                {
                    figure = new Rook();
                }

                if ((x == 1 && y == 2) || (x == 1 && y == 7) || (x == 8 && y == 2) || (x == 8 && y == 7))
                {
                    figure = new Kinght();
                }

                if ((x == 1 && y == 3) || (x == 1 && y == 6) || (x == 8 && y == 3) || (x == 8 && y == 6))
                {
                    figure = new Bishop();
                }

                if ((x == 1 && y == 4) || (x == 8 && y == 4))
                {
                    figure = new Queen();
                }

                if ((x == 1 && y == 5) || (x == 8 && y == 5))
                {
                    figure = new King();
                }

                if ((x == 2 && (y >= 1 && y <= 8)) || (x == 7 && (y >= 1 && y <= 8)))
                {
                    figure = new Pawn();
                }

                if((x == 1 && x == 2) && (y >=1 && y <= 8))
                {
                    Figure.Color = "White";
                }
                if((x == 7 && x == 8) && (y >= 1 && y <= 8))
                {
                    Figure.Color = "Black";
                }

                Figure.Cell = arrayCells[i];
                arrayCells[i].Figure = figure;
            }  
        }
    }
}
