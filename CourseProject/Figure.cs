using System;
using System.Cell;
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
        abstract public void Walk();
    }
}
