using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Enemy class creates an enemy entity that
/// will attack  player if 
/// </summary>

class Enemy
{
    //FIELDS
    private int scorePoints; // points added to player total score when enemy dies
    private int healthPoints;// number of points to be alive
    private bool isDead; // if true, enemy dispapear
    private int posX, posY; //cursor positon in console for printing the enemy

    //PROPERTIES
    public int ScorePoints { get { return scorePoints; } set { scorePoints = value; } }
    public int HealthPoints { get { return healthPoints; } set { healthPoints = value; } }
    public bool IsDead { get { return isDead; } set { isDead = value; } }
    public int PosX { get { return posX; } set { posX = value; } }
    public int PosY { get { return posY; } set { posY = value; } }


    //CONSTRUCTORS
    public Enemy(int score, int health, bool dead, int posX, int posY)
    {
        ScorePoints = score;
        HealthPoints = health;
        IsDead = dead;
    }

    //METHODS
    public int MoveEnemy(int x, int y);



}


