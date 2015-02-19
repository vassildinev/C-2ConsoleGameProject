using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Enemy class creates an enemy entity that
/// will move vertically or horizontaly.
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
    private int distance; // number of steps for movement
    private int steps; //distance  moved by enemy
    private bool right; //direction right or left
    private bool up;   //direction up or down


    //PROPERTIES
    public int ScorePoints { get { return scorePoints; } set { scorePoints = value; } }
    public int HealthPoints { get { return healthPoints; } set { healthPoints = value; } }
    public bool IsDead { get { return isDead; } set { isDead = value; } }
    public int PosX { get { return posX; } set { posX = value; } }
    public int PosY { get { return posY; } set { posY = value; } }
    public EnemySize EnemyTypeSize { get { return enemyTypeSize; } set { enemyTypeSize = value; } }
    public int EnemyWidth { get { return enemyHeight; } set { enemyHeight = value; } }
    public int EnemyHeight { get { return enemyWidth; } set { enemyWidth = value; } }
    public int Distance { get { return distance; } set { distance = value; } }
    public int Steps { get { return steps; } set { steps = value; } }
    public bool Right { get { return right; } set { right = value; } }
    public bool Up { get { return up; } set { up = value; } }

    //CONSTRUCTORS

   /// <summary>
   /// Creates an enemy at the given position and sets it's
   /// distance of movement
   /// </summary>
   /// <param name="score"> the points addedt to the players total score when enemy is dead</param>
   /// <param name="health"> number of hits to be killed</param>
   /// <param name="dead"> returs true if health is less or equal to 0</param>
   /// <param name="posX"> position on x to print the enemy</param>
   /// <param name="posY"> position on y to priont the enemy</param>
   /// <param name="typeSize"> size of the enemy</param>
   /// <param name="distance"> total number of steps enemy will move</param>
    public Enemy(int score, int health, bool dead, int posX, int posY, EnemySize typeSize, int distance)
    {
        ScorePoints = score;
        HealthPoints = health;
        IsDead = dead;
        PosX = posX;
        PosY = posY;
        EnemyTypeSize = typeSize;
        Distance = distance;

        // set height and width for collision checks
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
        Steps = 0;
        Right = false;
        Up = false;
    }

    //METHODS

    /// <summary>
    /// Prints a different enemy style, depending on the Enemy Size
    /// at the given console position.
    /// </summary>
    public void Print()
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
            default://print a small enemy
                Console.CursorTop = PosY;
                Console.CursorLeft = PosX;
                Console.WriteLine("|o`_´o|");
                break;
        }
    }

    /// <summary>
    /// Moves enemy horizontally in a total of steps equals to distance
    /// </summary>
    public void BounceHorizontal()
    {
        if (Steps <= Distance && Right == false)
        {
            Console.CursorLeft = PosX--;
            Steps++;
            if (Steps == Distance)
            {
                Right = true;
            }
        }
       
        if(Steps >= 0 && Right == true)
        {
            Console.CursorLeft = PosX++;
            Steps--;
            if (Steps == 0)
            {
                Right = false;
            }
        }

        Print();
    }
    /// <summary>
    /// Moves enemy vertically in a total of steps equal to distance
    /// </summary>
    public void BounceVertical()
    {
        if (Steps <= Distance && Up == false)
        {
            Console.CursorLeft = PosY--;
            Steps++;
            if (Steps == Distance)
            {
                Up = true;
            }
        }

        if (Steps >= 0 && Up == true)
        {
            Console.CursorLeft = PosY++;
            Steps--;
            if (Steps == 0)
            {
                Up = false;
            }
        }

        Print();
    }
}






