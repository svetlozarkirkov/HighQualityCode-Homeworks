﻿namespace P3_Game
{
    public class Player
    {
        public Player()
        {
        }

        public Player(string name, int score)
        {
            this.Name = name;
            this.Score = score;
        }

        public string Name { get; set; }

        public int Score { get; set; }
    }
}