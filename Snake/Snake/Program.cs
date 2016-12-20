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
            HLine hLineUp = new HLine(0, 118, 0, '*');
            hLineUp.Drow();

            HLine hLineDown = new HLine(0, 118, 28, '*');
            hLineDown.Drow();

            VLine vLineLeft = new VLine(0, 28, 0, '*');
            vLineLeft.Drow();

            VLine vLineRight = new VLine(0, 28, 118, '*');
            vLineRight.Drow();

            Console.ReadLine();
        }
    }
}
