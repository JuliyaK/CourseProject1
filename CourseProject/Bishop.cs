using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    class Bishop : Figure
    {
        public override void Walk(Cell newCell)
        {
            this.Checking();
            if (CurrentCell.CoordinateX != x && CurrentCell.CoordinateY != y)
            {
                throw new Exception("Фигура 'СЛОН' имеет другой алгоритм движения");
            }
            CurrentCell.CurrentFigure = null;
            CurrentCell = newCell;
            newCell.CurrentFigure = this;
        }
    }
}
