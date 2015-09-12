﻿namespace Bowling
{
    public class Frame
    {
        public int FirstTry { get; set; }
        public int SecondTry { get; set; }

        public int Score
        {
            get { return CalculateScore(); }
        }


        public Frame Next { get; set; }

        private int CalculateScore()
        {
            int score= FirstTry + SecondTry;
            if (IsStrike())
            {
                score += (NextBall()+NextToNextBall());
            }
            else if(IsSpare())
            {
                score += NextBall();
            }
            return score;
        }

        private int NextToNextBall()
        {
            if (Next.IsStrike())
            {
               return Next.Next.FirstTry;
            }
            return Next.SecondTry;
        }

        private int NextBall()
        {
            return Next.FirstTry;
        }

        private bool IsSpare()
        {
            return FirstTry+SecondTry==10;
        }

        private bool IsStrike()
        {
            return FirstTry == 10;
        }
    }
}