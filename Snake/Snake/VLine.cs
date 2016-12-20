using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VLine
    {
        /// <summary>
        /// Создаем лист pList который будет хранить наши точки
        /// Добавляем конструктор, который будет отрисовывать горизонтальные линии,
        /// получая начальную, конечную точку отрисовки по у, точку х,которая будет определять уровень линии, и символ отрисовки
        /// Добавляем метод Drow() и прогоняем все точки из листа в цикле foreach, что бы отрисовать их с помощью метода Draw() класса Point
        /// </summary>

        List<Point> pList;

        public VLine(int yUp, int yDown, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = yUp; y <= yDown; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

        public void Drow()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
