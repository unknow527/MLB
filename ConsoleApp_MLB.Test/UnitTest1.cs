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
        public void TestMethod_SelectAllData()
        {
            // 1.查詢賽事

            // 初始化Arrange
            // 執行Act
            uspMLBGamesDataHelper mlb = new uspMLBGamesDataHelper();
            var result = mlb.SelectAllData();

            // 驗證Assert
            Assert.IsNull(result.ex);
            Assert.IsTrue(result.t_games.Any());
            Assert.IsTrue(result.t_kinds.Any());
        }
        [TestMethod]
        public void TestMethod1_Select()
        {
            // 1.查詢賽事

            // 初始化Arrange
            // 執行Act
            uspMLBGamesDataHelper mlb = new uspMLBGamesDataHelper();
            var games = mlb.SelectGames();
            // 驗證Assert
            Assert.IsNotNull(games);
        }
        [TestMethod]
        public void TestMethod2_Create()
        {
            // 2.新增賽事

            // 初始化Arrange
            t_game g = new t_game();
            g.f_gameId = "2023-03-21_26_27";
            g.f_gameDate = "2023-03-21";
            g.f_gameStatus = 1;
            g.f_teamAId = 26;
            g.f_teamBId = 27;
            g.f_ra = 0;
            g.f_rb = 0;
            g.f_playerAId = 65;
            g.f_playerBId = 66;
            g.f_sourceId = 1;
            g.f_desc = "test";
            int expected = 1;
            // 執行Act
            uspMLBGamesDataHelper mlb = new uspMLBGamesDataHelper();
            int return_value = mlb.CreateGame(g);
            // 驗證Assert
            Assert.AreEqual(expected, return_value);
        }
        [TestMethod]
        public void TestMethod3_Delete()
        {
            // 3.刪除賽事
            // 初始化Arrange
            string gid = "2023-03-21_26_27";
            int expected = 1;
            // 執行Act
            uspMLBGamesDataHelper mlb = new uspMLBGamesDataHelper();
            int return_value = mlb.DeleteGame(gid);
            // 驗證Assert
            Assert.AreEqual(expected, return_value);
        }
    }
}