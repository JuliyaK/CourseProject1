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
       public override void Walk(Cell CoordinateX, Cell CoordinateY)
        {
            if (CurrentCell + CoordinateX >= 1 && CurrentCell + CoordinateX <= 8)
            {
                if (CurrentCell + CoordinateX == null)
                {
                    Walk(CoordinateX);
                }
            }
            if (CurrentCell + CoordinateY >= 1 && CurrentCell + CoordinateY <= 8)
            {
                if (CurrentCell + CoordinateY == null)
                {
                    Walk(CoordinateY);
                }
            }
        }
    }
}
