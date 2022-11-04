using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Temat_12pd
{
    class Program
	{
        static void Main()
		{
			List<IDrawable> objects = new List<IDrawable>();
			Random rand = new Random();

			foreach (ConsoleColor color in Enum.GetValues(typeof(ConsoleColor)))
			{
				objects.Add(new Parachutist(rand.Next(Console.WindowWidth / 2 - 40, Console.WindowWidth / 2 + 40), color));
				objects.Add(new Firework(rand.Next(Console.WindowWidth / 2 - 40, Console.WindowWidth / 2 + 40), color));
			}

			while (true)
			{
				IDrawable current = objects[rand.Next(0, objects.Count - 1)];
				for (int i = 0; i < 31; i++)
				{
					current.Draw();
					current.Move();
					Console.SetCursorPosition(0, 0);
					Thread.Sleep(100);
					Console.Clear();
				}
			}
        }
    }
}
