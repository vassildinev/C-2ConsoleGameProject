using System;
using System.Threading;

class TestArrowNavigation
{
    static void Main()
    {
        int cursorPosition = 0;

        //   0   1
        //   2   3

        ConsoleKeyInfo pressedKey = Console.ReadKey(true);

        while (pressedKey.Key != ConsoleKey.Enter)
        {
            while (Console.KeyAvailable)
            {
                pressedKey = Console.ReadKey(true);
                if (pressedKey.Key == ConsoleKey.UpArrow)
                {
                    if (cursorPosition == 2 || cursorPosition == 3)
                    {
                        cursorPosition -= 2;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.DownArrow)
                {
                    if (cursorPosition == 0 || cursorPosition == 1)
                    {
                        cursorPosition += 2;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (cursorPosition == 1 || cursorPosition == 3)
                    {
                        cursorPosition--;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (cursorPosition == 0 || cursorPosition == 2)
                    {
                        cursorPosition++;
                    }
                }
            }

            DrawMenu(cursorPosition);
            Thread.Sleep(500);
            Console.Clear();
        }
    }

    static void DrawMenu(int position)
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.SetCursorPosition(20, 5);
        //Console.WriteLine(new string('_', 29));
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write('|');
        Console.Write('|');
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write('|');
        Console.Write('|');
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write('|');
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write('|');
        Console.Write('|');
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write('|');
        Console.Write('|');
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write('|');
        Console.Write('|');
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write('|');
        Console.Write('|');
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write('|');
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write('|');
        Console.Write('|');
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write('|');
        Console.Write('|');
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write('|');
        Console.Write('|');
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write('|');
        Console.Write('|');
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write('|');
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write('|');
        Console.Write('|');
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write('|');
        Console.Write('|');
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write('|');
        Console.Write('|');
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.SetCursorPosition(20, 6);
        Console.Write('|');
        Console.WriteLine("                           |");
        Console.SetCursorPosition(20, 7);
        Console.Write('|');
        Console.WriteLine("                           |");
        Console.SetCursorPosition(20, 8);
        Console.Write('|');
        Console.ForegroundColor = ConsoleColor.DarkMagenta;

        if (position == 0)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("   New Game");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("   New Game");
        }

        if (position == 1)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("   High Score   ");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("   High Score   ");
        }

        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine('|');
        Console.SetCursorPosition(20, 9);
        Console.Write('|');
        Console.WriteLine("                           |");
        Console.SetCursorPosition(20, 10);
        Console.Write('|');
        Console.ForegroundColor = ConsoleColor.DarkMagenta;

        if (position == 2)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("   Options");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("   Options");
        }

        if (position == 3)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("   Instructions  ");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("   Instructions  ");
        }

        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine('|');
        Console.SetCursorPosition(20, 11);
        Console.Write('|');
        Console.WriteLine("                           |");
        Console.SetCursorPosition(20, 12);
        Console.Write('|');
        Console.WriteLine("                           |");
        Console.SetCursorPosition(20, 13);
        //Console.WriteLine(new string('_', 29));
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write('|');
        Console.Write('|');
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write('|');
        Console.Write('|');
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write('|');
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write('|');
        Console.Write('|');
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write('|');
        Console.Write('|');
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write('|');
        Console.Write('|');
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write('|');
        Console.Write('|');
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write('|');
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write('|');
        Console.Write('|');
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write('|');
        Console.Write('|');
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write('|');
        Console.Write('|');
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write('|');
        Console.Write('|');
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write('|');
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write('|');
        Console.Write('|');
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write('|');
        Console.Write('|');
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write('|');
        Console.Write('|');
    }
}
