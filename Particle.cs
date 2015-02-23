using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Particle
    {
        public int row, col;
        public char symbol;

        public Particle(int row, int col, char symbol)
        {
            this.row = row;
            this.col = col;
            this.symbol = symbol;
        }

        //public void SetParticle(int row = 0, int col = 0, char symbol = ' ')
        //{
        //    this.row = row;
        //    this.col = col;
        //    this.symbol = symbol;
        //}

        public Particle()
        {
            row = 0;
            col = 0;
            symbol = ' ';
        }

        public void MoveParticleUp()
        {
            if (row - 1 >= 0)
            {
                this.row--;
            }
        }

        public void MoveParticleDown()
        {
            if (row + 1 <= Console.WindowHeight)
            {
                this.row++;
            }
        }

        public void MoveParticleLeft()
        {
            if (col - 1 >= 0)
            {
                this.col--;
            }
        }

        public void MoveParticleRight()
        {
            
            if (col + 1 <= Console.WindowWidth)
            {
                this.col++;
            }
        }

        public void Print()
        {
            Console.SetCursorPosition(col, row);
            Console.Write(symbol);
        }

        public void Remove()
        {
            Console.SetCursorPosition(col, row);
            Console.Write(" ");
        }
    }

