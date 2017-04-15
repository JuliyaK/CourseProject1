using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    abstract class Figure
    {
        protected string Color;
        public Cell CurrentCell;
        public abstract void Walk();
        public abstract void Cheking()
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
        }
    }
}
