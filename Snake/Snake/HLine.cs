using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HLine
    {
        /// <summary>
        /// Создаем лист pList который будет хранить наши точки
        /// Добавляем конструктор, который будет отрисовывать горизонтальные линии,
        /// получая начальную, конечную точку отрисовки по х, точку у,которая будет определять уровень линии, и символ отрисовки
        /// Добавляем метод Drow() и прогоняем все точки из листа в цикле foreach, что бы отрисовать их с помощью метода Draw() класса Point
        /// </summary>

        List<Point> pList;

        public HLine(int xLeft, int xRight, int y, char sym)
        {
            pList = new List<Point>();
            for(int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

        public void Drow()
        {
            foreach(Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
