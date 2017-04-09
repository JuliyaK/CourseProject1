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
       public override void Walk()
        {
            for (CoordinateX = 1; CoordinateX <= 8; CoordinateX++)
            {
                for (CoordinateY = 1; CoordinateY <= 8; CoordinateY++)
                {
                    if ((CoordinateX + 1 == null && (CoordinateX + 1 >= 1 && CoordinateX <= 8)) || (CoordinateX - 1 == null && (CoordinateX + 1 >= 1 && CoordinateX <= 8)) || 
                       (CoordinateY + 1 == null && (CoordinateY + 1 >= 1 && CoordinateY <= 8)) || (CoordinateY-1 && (CoordinateY + 1 >= 1 && CoordinateY <= 8)))
                    {
                        //Фигура может сделать ход
                    }
                }
            }
        }
    }
}
