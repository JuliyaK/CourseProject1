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
        public int Current_Cell(int _x, int _y);
        abstract public void Walk();
    }
}
