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
using Dapper;

namespace ConsoleApp_MLB.Applibs
{
    public class uspMLBGamesDataHelper
    {
        // db連線字串
        // localdb:
        //private readonly string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Csharp\vs2022\ConsoleApp_MLB\ConsoleApp_MLB\App_Data\db_MLB.mdf;Integrated Security = True";
        // sqlserver:
        private readonly string constr = @"Data Source = .\SQLEXPRESS; Initial Catalog = DB_MLB; User ID = sa; Password=1234;Integrated Security = True";

        // SelectGames =>> 查詢賽事資料
        public IEnumerable<t_game> SelectGames()
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                //執行查詢預存程序
                var games = con.Query<t_game>("spSelectGames", commandType: CommandType.StoredProcedure);
          
                return games;
            }
        }

        // CreateGame =>> 新增賽事資料
        public int CreateGame(t_game g)
        {
            //Stored Procedure
            using (SqlConnection con = new SqlConnection(constr))
            {

                //準備參數
                DynamicParameters parameters = new DynamicParameters();
                // input
                parameters.Add("@f_gameId", g.f_gameId, DbType.String, ParameterDirection.Input);
                parameters.Add("@f_gameDate", g.f_gameDate, DbType.String, ParameterDirection.Input);
                parameters.Add("@f_gameStatus", g.f_gameStatus, DbType.Int16, ParameterDirection.Input);
                parameters.Add("@f_teamAId", g.f_teamAId, DbType.Int16, ParameterDirection.Input);
                parameters.Add("@f_teamBId", g.f_teamBId, DbType.Int16, ParameterDirection.Input);
                parameters.Add("@f_ra", g.f_ra, DbType.Int16, ParameterDirection.Input);
                parameters.Add("@f_rb", g.f_rb, DbType.Int16, ParameterDirection.Input);
                parameters.Add("@f_playerAId", g.f_playerAId, DbType.Int16, ParameterDirection.Input);
                parameters.Add("@f_playerBId", g.f_playerBId, DbType.Int16, ParameterDirection.Input);
                parameters.Add("@f_sourceId", g.f_sourceId, DbType.Int16, ParameterDirection.Input);
                parameters.Add("@f_desc", g.f_desc, DbType.String, ParameterDirection.Input);
                //執行修改預存程序
                var result = con.Execute("spCreateGame", parameters, commandType: CommandType.StoredProcedure);
                return result;

            }
        }
        // DeleteGame =>> 刪除賽事資料
        public int DeleteGame(string id)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                //準備參數
                DynamicParameters parameters = new DynamicParameters();
                // input
                parameters.Add("@f_gameId", id, DbType.String, ParameterDirection.Input);
                //執行修改預存程序
                var result = con.Execute("spDeleteGame", parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

    }
}
