using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    class King : Figure
    {
        public override void Walk(Cell newCell)
        {
            int x = newCell.CoordinateX;
            int y = newCell.CoordinateY;
            if (x < 1 && x > 8 && y < 1 && y > 8)
            {
                throw new Exception("Выбранный диапазон не принадлежит шахматной доске");
            }
            if (newCell.CurrentFigure != null)
            {
                throw new Exception("Клетка не пустая");
            }
            if (CurrentCell.CoordinateX - x != 1)
            {
                throw new Exception("Фигура 'КОРОЛЬ' имеет другой алгоритм движения");
            }
            CurrentCell.CurrentFigure = null;
            CurrentCell = newCell;
            newCell.CurrentFigure = this;
        }
    }
}
