using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temat_12pd
{
    class Parachutist : IDrawable
    {
        public ConsoleColor Color { get; set; }
        private int x;
        private int y;

        public Parachutist(int x, ConsoleColor color)
        {
            Color = color;
            this.x = x;
            y = 0;
        }

        public void Draw()
        {
            Console.ForegroundColor = Color;
            Console.SetCursorPosition(x + 1, y);
            Console.WriteLine("@@@@@@@");
            Console.SetCursorPosition(x, y + 1);
            Console.WriteLine("@");
            Console.SetCursorPosition(x + 8, y + 1);
            Console.WriteLine("@");
            for (int i = 1; i < 5; i++)
            {
                Console.SetCursorPosition(x + i, y + i + 1);
                Console.WriteLine("@");
                Console.SetCursorPosition(x - i + 8, y + i + 1);
                Console.WriteLine("@");
            }
            Console.SetCursorPosition(x + 4, y + 6);
            Console.WriteLine("@");
        }

        public void Move()
        {
            if (y == 30)
                y = 0;
            else
                y++;
        }
    }
}
