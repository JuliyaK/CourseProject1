using System;
using System.Figure;
using System.Cell;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    class Rook : Figure
    {
       public override void Walk(Cell newCell)
        {
            if (CurrentCell + CoordinateX >= 1 && CurrentCell + CoordinateX <= 8)
            {
                if (CurrentCell + CoordinateX == null)
                {
                    newCell.CoordinateX;
                }
            }
            if (CurrentCell + CoordinateY >= 1 && CurrentCell + CoordinateY <= 8)
            {
                if (CurrentCell + CoordinateY == null)
                {
                    newCell.CoordinateY;
                }
            }
        }
    }
}
