using NUnit.Framework;
using BoardGame;
using Board_Game;

namespace BoardNUnitTest
{
    public class Tests
    {
        [Test]
        public void TestMMMM()
        {
            BoardGame.Program pgm = new BoardGame.Program();
            
            Board_Game.Play_Board_Game board_Game = new Board_Game.Play_Board_Game();
            var res=board_Game.CreateBoard("MMMM");
            Assert.AreEqual("04N", res);

        }
        [Test]
        public void TestRMMMLMM()
        {
            BoardGame.Program pgm = new BoardGame.Program();

            Board_Game.Play_Board_Game board_Game = new Board_Game.Play_Board_Game();
            var res = board_Game.CreateBoard("RMMMLMM");
            Assert.AreEqual("32N", res);

        }
        [Test]
        public void TestMRMLMRM()
        {
            BoardGame.Program pgm = new BoardGame.Program();

            Board_Game.Play_Board_Game board_Game = new Board_Game.Play_Board_Game();
            var res = board_Game.CreateBoard("MRMLMRM");
            Assert.AreEqual("22E", res);
        }
    }
}