using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temat_12pd
{
    class Firework : IDrawable
    {
        public ConsoleColor Color { get; set; }
        private int x;
        private int y;

        public Firework(int x, ConsoleColor color)
        {
            Color = color;
            this.x = x;
            y = Console.WindowHeight;
        }

        public void Draw()
        {
            Console.ForegroundColor = Color;
            if (y == Console.WindowHeight / 2 - 5)
            {
                Console.SetCursorPosition(x, y);
                Console.WriteLine("@   @");
                Console.SetCursorPosition(x, y + 1);
                Console.WriteLine(" @ @ ");
                Console.SetCursorPosition(x, y + 2);
                Console.WriteLine("@@@@@");
                Console.SetCursorPosition(x, y + 3);
                Console.WriteLine(" @ @ ");
                Console.SetCursorPosition(x, y + 4);
                Console.WriteLine("@   @");
            }
            else if (y > Console.WindowHeight / 2 - 5)
            {
                Console.SetCursorPosition(x + 2, y + 2);
                Console.WriteLine("@");
                Console.SetCursorPosition(x + 2, y + 3);
                Console.WriteLine("@");
            }
        }

        public void Move()
        {
            if (y == 0)
                y = Console.WindowHeight;
            else
                y--;
        }
    }
}
