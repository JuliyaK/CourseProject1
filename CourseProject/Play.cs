using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    class Play
    {
        public void NewPlay();
        public Chessboard CreateChessboard()
        {
            return new Chessboard();
        }
    }
}
