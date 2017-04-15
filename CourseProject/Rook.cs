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
            x = CoordinateX;
            y = CoodinateY;
            if (CurrentCell.x + newCell.x < 1 && CurrentCell.x + newCell.x > 8 && CurrentCell.y + newCell.y < 1 && CurrentCell.y + newCell.y > 8)
            {
                throw new Exception("Выбранный диапазон не принадлежит шахматной доске");
            }
            if (CurrentFigure != null)
            {
                throw new Exception("Клетка не пустая");
            }
            if (CurrentCell.x != newCell.x && CurrentCell.y != newCell.y)
            {
                throw new Exception("Ладья имеет другой алгоритм движения");
            }
            CurrentCell = newCell;
        }
    }
}
