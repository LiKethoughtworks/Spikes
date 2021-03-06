﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThirdTry;

namespace ThirdTryTest
{
    [TestClass]
    public class ScoreBoardTest
    {
        [TestMethod]
        public void ScoreBoardShouldCountScoreOfNormalGame()
        {
            //given
            var scoreBoard = new ScoreBoard();

            //when
            scoreBoard.Play(1, 2); //3
            scoreBoard.Play(2, 8); //20
            scoreBoard.Play(10, 0); //19
            scoreBoard.Play(4, 5); //9
            scoreBoard.Play(7, 3); //11
            scoreBoard.Play(1, 2); //3
            scoreBoard.Play(10, 0); //13
            scoreBoard.Play(1, 2); //3
            scoreBoard.Play(5, 2); //7
            scoreBoard.Play(1, 2); //3

            //then
            Assert.AreEqual(91, scoreBoard.TotalScore);
        }

        [TestMethod]
        public void ScoreBoardShouldCountScoreWhenLastFrameHas3Balls()
        {
            //given
            var scoreBoard = new ScoreBoard();

            //when
            scoreBoard.Play(1, 2); //3
            scoreBoard.Play(2, 8); //20
            scoreBoard.Play(10, 0); //19
            scoreBoard.Play(4, 5); //9
            scoreBoard.Play(7, 3); //11
            scoreBoard.Play(1, 2); //3
            scoreBoard.Play(10, 0); //13
            scoreBoard.Play(1, 2); //3
            scoreBoard.Play(5, 2); //7
            scoreBoard.Play(1, 9, 3); //13

            //then
            Assert.AreEqual(101, scoreBoard.TotalScore);
        }

        [TestMethod]
        public void ScoreBoardShouldCountScoreWhenLastFrameHasStrike()
        {
            //given
            var scoreBoard = new ScoreBoard();

            //when
            scoreBoard.Play(1, 2); //3
            scoreBoard.Play(2, 8); //20
            scoreBoard.Play(10, 0); //19
            scoreBoard.Play(4, 5); //9
            scoreBoard.Play(7, 3); //11
            scoreBoard.Play(1, 2); //3
            scoreBoard.Play(10, 0); //13
            scoreBoard.Play(1, 2); //3
            scoreBoard.Play(5, 2); //7
            scoreBoard.Play(10, 9, 3); //22

            //then
            Assert.AreEqual(110, scoreBoard.TotalScore);
        }

        [TestMethod]
        public void ScoreBoardShouldCountScoreOfPerfectGame()
        {
            //given
            var scoreBoard = new ScoreBoard();

            //when
            scoreBoard.Play(10, 0);
            scoreBoard.Play(10, 0);
            scoreBoard.Play(10, 0);
            scoreBoard.Play(10, 0);
            scoreBoard.Play(10, 0);
            scoreBoard.Play(10, 0);
            scoreBoard.Play(10, 0);
            scoreBoard.Play(10, 0);
            scoreBoard.Play(10, 0);
            scoreBoard.Play(10, 10, 10);

            //then
            Assert.AreEqual(300, scoreBoard.TotalScore);
        }
    }
}