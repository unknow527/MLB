using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ConsoleApp_MLB.Model;
using Newtonsoft.Json;
using static System.Formats.Asn1.AsnWriter;
using System.Xml.Linq;

namespace ConsoleApp_MLB.Applibs
{
    public class MLBGamesDataHelper
    {
        // db連線字串
        // localdb:
        private string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Csharp\vs2022\ConsoleApp_MLB\ConsoleApp_MLB\App_Data\db_MLB.mdf;Integrated Security = True";
        // sqlserver:
        //private string constr = @"Data Source=.\SQLEXPRESS;Initial Catalog=mlb;User ID=sa;Password=1234";

        //executeSql方法可傳入SQL字串來編輯資料表
        private void executeSql(string sql)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = constr;
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //querySql方法可傳入SQL字串並傳回DataTable物件
        private DataTable querySql(string sql)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = constr;
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds.Tables[0];
        }
        // MLB game CRUD==================================================================================================================
        // SelectGames =>> 查詢全部賽事資料
        public DataTable SelectGame(int num)
        {
            // 執行SQL查詢
            string sql = @"SELECT TOP 1
                                g.f_gameId, 
                                g.f_gameDate, 
                                g.f_gameStatus, 
                                ta.f_dataName AS teamA, 
                                tb.f_dataName AS teamB, 
                                pa.f_dataName AS playerA, 
                                pb.f_dataName AS playerB, 
                                g.f_ra, 
                                g.f_rb, 
                                g.f_sourceId, 
                                g.f_desc
                            FROM 
                                t_game g
                                LEFT JOIN t_kindData ta ON g.f_teamAId = ta.f_dataId
                                LEFT JOIN t_kindData tb ON g.f_teamBId = tb.f_dataId
                                LEFT JOIN t_kindData pa ON g.f_playerAId = pa.f_dataId
                                LEFT JOIN t_kindData pb ON g.f_playerBId = pb.f_dataId
                            ORDER BY g.f_gameId desc";
            DataTable dt = querySql(sql);
            // DataTable轉Json
            //var rs = JsonConvert.SerializeObject(dt, Newtonsoft.Json.Formatting.Indented);

            return dt;
        }
        // SelectGames =>> 查詢最新一筆賽事
        public DataTable SelectGames()
        {
            // 執行SQL查詢
            string sql = @"SELECT
                                g.f_gameId, 
                                g.f_gameDate, 
                                g.f_gameStatus, 
                                ta.f_dataName AS teamA, 
                                tb.f_dataName AS teamB, 
                                pa.f_dataName AS playerA, 
                                pb.f_dataName AS playerB, 
                                g.f_ra, 
                                g.f_rb, 
                                g.f_sourceId, 
                                g.f_desc
                            FROM 
                                t_game g
                                LEFT JOIN t_kindData ta ON g.f_teamAId = ta.f_dataId
                                LEFT JOIN t_kindData tb ON g.f_teamBId = tb.f_dataId
                                LEFT JOIN t_kindData pa ON g.f_playerAId = pa.f_dataId
                                LEFT JOIN t_kindData pb ON g.f_playerBId = pb.f_dataId
                            ORDER BY g.f_gameId desc";
            DataTable dt = querySql(sql);
            // DataTable轉Json
            //var rs = JsonConvert.SerializeObject(dt, Newtonsoft.Json.Formatting.Indented);

            return dt;
        }
        // CreateGame =>> 新增賽事資料
        public DataTable CreateGame(t_game g)
        {  
            string sql = $"INSERT INTO t_game(f_gameId, f_gameDate, f_gameStatus, f_teamAId, f_teamBId, f_ra, f_rb, f_playerAId, f_playerBId, f_sourceId, f_desc)VALUES ('{g.f_gameId}','{g.f_gameDate}','{g.f_gameStatus}','{g.f_teamAId}','{g.f_teamBId}','{g.f_ra}','{g.f_rb}','{g.f_playerAId}','{g.f_playerBId}','{g.f_sourceId}','{g.f_desc}')";
            
            executeSql(sql);

            return SelectGame(1);
        }
        // DeleteGame =>> 刪除賽事資料
        public DataTable DeleteGame(string id)
        {
            string sql = "DELETE FROM t_game WHERE f_gameId='"
                + id.Replace("'", "''") + "'";
            executeSql(sql);

            return SelectGame(1);
        }

    }
}
