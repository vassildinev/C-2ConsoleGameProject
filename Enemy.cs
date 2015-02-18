using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Enemy class creates an enemy entity that
/// will attack  player if 
/// </summary>

public enum EnemySize { SMALL = 0, BIG = 1, BOSS = 2 };

class Enemy
{


    //FIELDS
    private int scorePoints; // points added to player total score when enemy dies
    private int healthPoints;// number of points to be alive
    private bool isDead; // if true, enemy dispapear
    private int posX, posY; //cursor positon in console for printing the enemy
    private EnemySize enemyTypeSize;// will determine which enemy to print
    private int enemyHeight; // enemy printed lines
    private int enemyWidth; // enemy characters length per line
   


    //PROPERTIES
    public int ScorePoints { get { return scorePoints; } set { scorePoints = value; } }
    public int HealthPoints { get { return healthPoints; } set { healthPoints = value; } }
    public bool IsDead { get { return isDead; } set { isDead = value; } }
    public int PosX { get { return posX; } set { posX = value; } }
    public int PosY { get { return posY; } set { posY = value; } }
    public EnemySize EnemyTypeSize { get { return enemyTypeSize; } set { enemyTypeSize = value; } }
    public int EnemyWidth { get { return enemyHeight; } set { enemyHeight = value; } }
    public int EnemyHeight { get { return enemyWidth; } set { enemyWidth = value; } }


    //CONSTRUCTORS
    /// <summary>
    /// Creates a small enemy on teh top left corner of the console
    /// </summary>
    public Enemy()
    {
        ScorePoints = 1;
        HealthPoints = 1;
        IsDead = false;
        PosX = 0;
        PosY = 0;
        EnemyTypeSize = EnemySize.SMALL;
        // set height and width

        EnemyHeight = 1;
        EnemyWidth = 6;

    }
    /// <summary>
    /// Creates any type of enemy, at the given position
    /// </summary>
    /// <param name="score"></param>
    /// <param name="health"></param>
    /// <param name="dead"></param>
    /// <param name="posX"></param>
    /// <param name="posY"></param>
    /// <param name="typeSize"></param>
    public Enemy(int score, int health, bool dead, int posX, int posY, EnemySize typeSize)
    {
        ScorePoints = score;
        HealthPoints = health;
        IsDead = dead;
        PosX = posX;
        PosY = posY;
        EnemyTypeSize = typeSize;

        // set height and width
        if (EnemyTypeSize == EnemySize.SMALL)
        {
            EnemyHeight = 1;
            EnemyWidth = 6;
        }
        else if (EnemyTypeSize == EnemySize.BIG)
        {
            EnemyHeight = 3;
            EnemyWidth = 6;
        }
        else if (EnemyTypeSize == EnemySize.BOSS)
        {
            EnemyHeight = 5;
            EnemyWidth = 8;
        }
        //initialize directions for bounce movement
        
    }

    //METHODS

    /// <summary>
    /// Prints a different enemy style, depending on the Enemy Size
    /// at the given console position if any is given. Else will
    /// print it in the left top corner
    /// </summary>
    public void PrintEnemy()
    {
        switch (EnemyTypeSize)
        {
            case EnemySize.BIG: //print a big enemy
                Console.CursorTop = PosY;
                Console.CursorLeft = PosX;
                Console.WriteLine(" ___ ");
                Console.CursorLeft = PosX;
                Console.WriteLine("/o o\\");
                Console.CursorLeft = PosX;
                Console.WriteLine("V---V ");
                break;
            case EnemySize.BOSS: // print a boss
                Console.CursorTop = PosY;
                Console.CursorLeft = PosX;
                Console.WriteLine(" ?___? ");
                Console.CursorLeft = PosX;
                Console.WriteLine("/o   o\\");
                Console.CursorLeft = PosX;
                Console.WriteLine("|  X  |");
                Console.CursorLeft = PosX;
                Console.WriteLine("|     |");
                Console.CursorLeft = PosX;
                Console.WriteLine("\\/---\\/");
                break;
            default:
                Console.CursorTop = PosY;
                Console.CursorLeft = PosX;
                Console.WriteLine("|o`_´o|");//print a small enemy
                break;
        }
    }

    int steps = 0;
    int right = 0;
    int up = 0;

    public void EnemyBounceHorizontal()
    {
        
        if (steps <= 4 && right == 0)
        {
            Console.CursorLeft = PosX--;
            steps++;
            if (steps == 4)
            {
                right = 1;
            }
        }
       
        
        if(steps >= 0 && right == 1)
        {
            Console.CursorLeft = PosX++;
            steps--;
            if (steps == 0)
            {
                right = 0;
            }
        }

        PrintEnemy();
    }
    public void EnemyBounceVertical()
    {
        if (steps <= 4 && up == 0)
        {
            Console.CursorLeft = PosY--;
            steps++;
            if (steps == 4)
            {
                up = 1;
            }
        }
        if (steps >= 0 && up == 1)
        {
            Console.CursorLeft = PosY++;
            steps--;
            if (steps == 0)
            {
                up = 0;
            }
        }

        PrintEnemy();
    }
}






