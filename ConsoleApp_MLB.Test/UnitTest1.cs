using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp_MLB.Applibs;
using ConsoleApp_MLB.Model;

namespace ConsoleApp_MLB.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // 1.查詢賽事
            MLBGamesDataHelper mlb = new MLBGamesDataHelper();
            var games = mlb.SelectGames();
            Console.WriteLine(games);
            Console.ReadLine();
        }
        [TestMethod]
        public void TestMethod2()
        {
            // 2.新增賽事
            MLBGamesDataHelper mlb = new MLBGamesDataHelper();
            t_game g = new t_game();
            g.f_gameDate = "2023-03-21";
            g.f_gameStatus = 1;
            g.f_teamAId = 5;
            g.f_teamBId = 24;
            g.f_ra = 0;
            g.f_rb = 0;
            g.f_playerAId = 20;
            g.f_playerBId = 21;
            g.f_sourceId = 1;
            g.f_desc = "test";
            g.f_gameId = g.f_gameDate.ToString() + "_" + g.f_teamAId + "_" + g.f_teamBId;
            var games = mlb.CreateGame(g);
            Console.WriteLine(games);
            Console.ReadLine();
        }
        [TestMethod]
        public void TestMethod3()
        {
            // 3.刪除賽事
            MLBGamesDataHelper mlb = new MLBGamesDataHelper();
            string gid = "2023-03-21_8_4";
            var games = mlb.DeleteGame(gid);
            Console.WriteLine(games);
            Console.ReadLine();
        }
    }
}