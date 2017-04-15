using System;
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
            int x = CoordinateX;
            int y = CoordinateY;
            if (x < 1 && x > 8 && y < 1 && y > 8)
            {
                throw new Exception("Выбранный диапазон не принадлежит шахматной доске");
            }
            if (newCell.CurrentFigure != null)
            {
                throw new Exception("Клетка не пустая");
            }
            if (CurrentCell.x != newCell.x || CurrentCell.y != newCell.y)
            {
                throw new Exception("Ладья имеет другой алгоритм движения");
            }
            CurrentCell = newCell;
        }
    }
}
