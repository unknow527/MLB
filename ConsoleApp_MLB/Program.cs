using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Xml;
using Newtonsoft.Json;

using ConsoleApp_MLB.Applibs;
using ConsoleApp_MLB.Model;

namespace ConsoleApp_MLB
{
    class Program
    {
        static void Main(string[] args) 
        {
            //MLBGamesDataHelper mlb = new MLBGamesDataHelper();
            uspMLBGamesDataHelper mlb = new uspMLBGamesDataHelper();

            //1.查詢賽事
            var games = mlb.SelectGames();
            string json = JsonConvert.SerializeObject(games);
            Console.WriteLine(json);

            //2.新增賽事
            //t_game g = new t_game();
            //g.f_gameDate = "2023-03-21";
            //g.f_gameStatus = 1;
            //g.f_teamAId = 26;
            //g.f_teamBId = 27;
            //g.f_ra = 0;
            //g.f_rb = 0;
            //g.f_playerAId = 65;
            //g.f_playerBId = 66;
            //g.f_sourceId = 1;
            //g.f_desc = "test";
            //g.f_gameId = g.f_gameDate + "_" + g.f_teamAId + "_" + g.f_teamBId;
            //int return_value = mlb.CreateGame(g);
            //Console.WriteLine(return_value);

            //3.刪除賽事
            //string gid = "2023-03-21_26_27";
            //int return_value = mlb.DeleteGame(gid);
            //Console.WriteLine(return_value);

            Console.ReadLine();
        }

    }
}

