using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            //размер окна
            Console.SetBufferSize(120, 30);

            //отрисовка линий
            HLine hLineUp = new HLine(0, 118, 0, '*');
            hLineUp.Drow();

            HLine hLineDown = new HLine(0, 118, 29, '*');
            hLineDown.Drow();

            VLine vLineLeft = new VLine(0, 29, 0, '*');
            vLineLeft.Drow();

            VLine vLineRight = new VLine(0, 29, 118, '*');
            vLineRight.Drow();

            Console.ReadLine();
        }
    }
}
