using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Mario
{
    Particle center;
    Particle[] body;
    public const int magicNumber = 27;
    public Mario(int row, int col)
    {
        center = new Particle(row, col, '█');

        body = new Particle[30];
        // right arm
        body[0] = new Particle(row, col + 1, '█');
        body[1] = new Particle(row, col + 2, '█');
        body[2] = new Particle(row, col + 3, '█');
        body[3] = new Particle(row + 1, col + 3, '█');
        // left arm
        body[4] = new Particle(row, col - 1, '█');
        body[5] = new Particle(row, col - 2, '█');
        body[6] = new Particle(row, col - 3, '█');
        body[7] = new Particle(row + 1, col - 3, '█');

        // torso
        body[8] = new Particle(row + 1, col, '█');
        body[9] = new Particle(row + 1, col - 1, '█');
        body[10] = new Particle(row + 1, col + 1, '█');

        // lower body

        body[11] = new Particle(row + 2, col, '█');
        body[12] = new Particle(row + 3, col + 1, '\x005C');
        body[13] = new Particle(row + 3, col - 1, '/');

        // head

        body[14] = new Particle(row - 1, col, '"');
        body[15] = new Particle(row - 1, col - 2, '\x005C');
        body[16] = new Particle(row - 1, col + 2, '/');
        body[17] = new Particle(row + 3, col - 1, '/');
        body[18] = new Particle(row + 3, col - 1, '/');
        body[19] = new Particle(row - 2, col + 1, 'o');
        body[20] = new Particle(row - 2, col - 1, 'o');
        body[21] = new Particle(row - 2, col - 2, '/');
        body[22] = new Particle(row - 2, col + 2, '\x005C');
        body[23] = new Particle(row - 3, col - 1, '@');
        body[24] = new Particle(row - 3, col, '@');
        body[25] = new Particle(row - 3, col + 1, '@');
        body[26] = new Particle(row - 4, col, '@');
    }

    public void Print()
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        center.Print();
        for (int i = 0; i < magicNumber; i++)
        {
            body[i].Print();
        }
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.SetCursorPosition(0, 0);
    }

    public void Clear()
    {
        center.Remove();
        for (int i = 0; i < magicNumber; i++)
        {
            body[i].Remove();
        }
    }

    public bool Collision(string direction, Level lvl)
    {
        switch (direction)
        {
            case "up":
                {
                    if (lvl[center.row - 4] > 0)
                        return lvl[center.row - 5, center.col] == '█';
                } break;
            case "down":
                {
                    if (lvl[center.row + 4] > 0)
                        return lvl[center.row + 4, center.col] == '█';
                } break;
            case "left":
                {
                    if (lvl[center.row] > 0)
                        return lvl[center.row, center.col - 4] == '█';
                } break;
            case "right":
                {
                    if (lvl[center.row] > 0)
                        return lvl[center.row, center.col + 4] == '█';
                } break;
            default: return false;
        }
        return false;
    }

    public void MoveUp(Level lvl)
    {
        if (center.row - 4 > 0 && !Collision("up", lvl))
        {
            center.MoveParticleUp();
            for (int i = 0; i < magicNumber; i++)
            {
                body[i].MoveParticleUp();
            }
        }
    }



    public void MoveDown(Level lvl)
    {
        if (center.row + 3 < Console.WindowHeight - 1 && !Collision("down", lvl))
        {
            center.MoveParticleDown();
            for (int i = 0; i < magicNumber; i++)
            {
                body[i].MoveParticleDown();
            }
        }
    }




    public void MoveLeft(Level lvl)
    {
        if (center.col - 3 > 0 && !Collision("left", lvl))
        {
            center.MoveParticleLeft();
            for (int i = 0; i < magicNumber; i++)
            {
                body[i].MoveParticleLeft();
            }
        }

    }

    public void MoveRight(Level lvl)
    {
        if (center.col + 3 < Console.WindowWidth - 1 && !Collision("right", lvl))
        {
            center.MoveParticleRight();
            for (int i = 0; i < magicNumber; i++)
            {
                body[i].MoveParticleRight();
            }
        }
    }



    public bool IsFlying(Level lvl)
    {
        return lvl[center.row + 4, center.col] != '█';
    }

}


