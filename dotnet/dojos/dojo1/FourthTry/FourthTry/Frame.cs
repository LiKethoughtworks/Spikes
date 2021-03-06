﻿using System;

namespace FourthTry
{
    public class Frame
    {
        public Frame(int firstBall, int secondBall)
        {
            FirstBall = firstBall;
            SecondBall = secondBall;
        }

        public int FirstBall { get; }
        public int SecondBall { get; }

        public int Score
        {
            get
            {
                CheckBallLimit();
                return CalculateScore();
            }
        }

        public Frame Next { get; set; }

        protected virtual void CheckExtra()
        {
            if (FirstBall + SecondBall > 10)
            {
                throw new ArgumentException("two balls sum upper limit is 10");
            }
        }

        protected void CheckSingleBall(int ball, string name)
        {
            if (ball > 10)
            {
                throw new ArgumentOutOfRangeException(name, "ball upper limit is 10");
            }
        }

        protected virtual int CalculateScore()
        {
            return FirstBall + SecondBall + Bonus();
        }

        private void CheckBallLimit()
        {
            CheckSingleBall(FirstBall, nameof(FirstBall));
            CheckSingleBall(SecondBall, nameof(SecondBall));
            CheckExtra();
        }

        private int Bonus()
        {
            var isStrike = FirstBall == 10;
            var isSpare = !isStrike && (FirstBall + SecondBall == 10);
            if (isSpare)
            {
                return Next1Ball();
            }
            if (isStrike)
            {
                return Next1Ball() + Next2Ball();
            }
            return 0;
        }

        private int Next2Ball()
        {
            var nextIsStrike = Next.FirstBall == 10;
            var nextIsNotLast = Next.Next != null;
            if (nextIsStrike && nextIsNotLast)
            {
                return Next.Next.FirstBall;
            }
            return Next.SecondBall;
        }

        private int Next1Ball()
        {
            return Next.FirstBall;
        }
    }
}