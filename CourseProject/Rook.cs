using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    class Rook
    {
        public int Walk()
        {
            int x, y;
            int [,] field = new int[8, 8]; //задаем поле движения - двумерный массив 8 на 8
            for (x = 1; x <= 8; x++)
            {
                for (y = 1; y = 8; y++)
                {
                    /* Траектория движения Ладьи из начального положения
                       x = 1, y = 1;  x = 2, y = 1;  x = 3, y = 1;  x = 4, y = 1
                       x = 5, y = 1;  x = 6, y = 1;  x = 7, y = 1;  x = 8, y = 1
                       x = 1, y = 1;  x = 1, y = 2;  x = 1, y = 3;  x = 1, y = 4
                       x = 1, y = 5;  x = 1, y = 6;  x = 1, y = 7;  x = 1, y = 8 
                    */
                    if (x == 1 || y == 1 || x + y = 3 || x + y = 4 || x + y = 5 || x + y = 6 || x + y = 7)
                    {
                        field[x, y] = '*';
                    }
                    else
                    {
                        field[x, y] = '0';
                    }
                    if (x == 1 && y == 1)
                    {
                        field[x, y] = 'R';
                    }
                }
            }
            System.Console.WriteLine(field[x, y]);
        }
    }
}
