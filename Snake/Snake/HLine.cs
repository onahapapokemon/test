using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HLine : Figure
    {
        /// <summary>
        /// Создаем лист pList который будет хранить наши точки
        /// Добавляем конструктор, который будет отрисовывать горизонтальные линии,
        /// получая начальную, конечную точку отрисовки по х, точку у,которая будет определять уровень линии, и символ отрисовки
        /// </summary>

        public HLine(int xLeft, int xRight, int y, char sym)
        {
            pList = new List<Point>();
            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
    }
}
