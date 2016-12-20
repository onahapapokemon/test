using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        /// <summary>
        /// int x - координата точки по х
        /// int y - координата точки на у
        /// char sym - выводимый символ
        /// 
        /// мутод Draw выводит на экран символ в заданных координатах х и у
        /// </summary>

        public int x;
        public int y;
        public char sym;

        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
