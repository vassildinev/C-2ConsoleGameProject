using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

class Level
{
    string[] lvl;
    public Level()
    {
        lvl = new string[]{
                "                                                  ",
                "                                                  ",
                "                                       ######     ",
                "                                       ######      ",
                "                                       ######",
                "                                       ######",
                "                                       ######                                                                   ",
                "                                                                                                                ",
                "                                                                                                                ",
                "                                                                                                                ",
                "                                                                                                                ",
                "                                                                                                                ",
                "                                                                                                                ",
                "                                                                                                                ",
                "                                                                                                                ",
                "                                                                                                                ",
                "                                                                                                                ",
                "                                                                                                                ",
                "                                                                                                                ",
                "               █████                                                                                            ",
                "               █████                                                                                            ",
                "               █████                                                                                            ",
                "               █████                                                                                            ",
                "████████████████████████████████████████████████████              ████████████████████████████████████████████████████",
                "████████████████████████████████████████████████████              ████████████████████████████████████████████████████",
                "████████████████████████████████████████████████████              ████████████████████████████████████████████████████",
                };
    }
    public char this[int row, int col]
    {
        get
        {
            return lvl[row][col];
        }
    }

    public int this[int row]
    {
        get
        {
            return lvl[row].Length;
        }
    }

    public void Print()
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        foreach (string row in lvl)
        {
            Console.WriteLine(row);
        }
        Console.ForegroundColor = ConsoleColor.Gray;
    }


}



class Game
{
    public static void SetConsole(int height, int width)
    {
        Console.WindowHeight = height;
        Console.WindowWidth = width;
    }

    static void Main()
    {
        //Particle gg = new Particle(5,5, 'O');

        //for (int i = 0; i < Console.WindowWidth-20; i++)
        //{
            
        //    gg.MoveParticleRight();
        //    gg.Print();
        //    Thread.Sleep(100);
        //    gg.Remove();
        //}

        int counter = 0;
        string sad = string.Empty;
        SetConsole(30, 130);
        Level lvl = new Level();
        lvl.Print();
        Mario m = new Mario(5, 5);
        m.Print();


        bool jumpingRight = false;
        int jumpArc = 0;
        int spotJump = 0;

        while (true)
        {

            ConsoleKeyInfo keyPressed = new ConsoleKeyInfo();
            if (jumpArc == 0 && !m.IsFlying(lvl) && spotJump == 0)
            {
                keyPressed = Console.ReadKey(true);
                while (Console.KeyAvailable)
                {
                    Console.ReadKey(true);

                }
                if (ConsoleKey.Escape == keyPressed.Key)
                {
                    break;
                }

            }


            m.Clear(); // clear the mario

            

            if (spotJump > 0)
            {
                if (spotJump < 8)
                {
                    m.MoveUp(lvl);
                    spotJump++;
                }
                else
                {
                    m.MoveDown(lvl);
                    spotJump++;
                    spotJump %= 16;
                }
            }

            else if (jumpArc > 0)
            {
                if (jumpingRight)
                {
                    if (jumpArc < 8)
                    {
                        m.MoveUp(lvl);
                        m.MoveRight(lvl);
                        jumpArc++;
                    }
                    else
                    {
                        m.MoveDown(lvl);
                        m.MoveRight(lvl);
                        jumpArc++;
                        jumpArc %= 16;
                    }
                }
                else
                {
                    if (jumpArc < 8)
                    {
                        m.MoveUp(lvl);
                        m.MoveLeft(lvl);
                        jumpArc++;
                    }
                    else
                    {
                        m.MoveDown(lvl);
                        m.MoveLeft(lvl);
                        jumpArc++;

                        jumpArc %= 16;
                        jumpingRight = jumpArc == 0;
                    }

                }
            }
            else
            {
                if (m.IsFlying(lvl) && spotJump==0)
                {
                    m.MoveDown(lvl);
                }
                else
                {
                    switch (keyPressed.Key)
                    {
                        case ConsoleKey.LeftArrow: m.MoveLeft(lvl); break;
                        case ConsoleKey.RightArrow: m.MoveRight(lvl); break;
                        case ConsoleKey.DownArrow: m.MoveDown(lvl); break;
                        case ConsoleKey.UpArrow: m.MoveUp(lvl); spotJump++; break;
                        case ConsoleKey.D: m.MoveUp(lvl); jumpArc++; jumpingRight = true; break;
                        case ConsoleKey.A: m.MoveUp(lvl); jumpingRight = false; jumpArc++; break;
                        default: break;
                    }
                }
                
            }
            

            m.Print();
            
            Thread.Sleep(60);
            
        }



    }
}

