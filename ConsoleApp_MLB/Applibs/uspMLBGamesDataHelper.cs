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
        private readonly string constr;
        public uspMLBGamesDataHelper()
        {
            //this.constr = connectionString;
            // localdb:
            //this.constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Csharp\vs2022\ConsoleApp_MLB\ConsoleApp_MLB\App_Data\db_MLB.mdf;Integrated Security = True";
            // sqlserver:
            this.constr = @"Data Source=.\SQLEXPRESS;Initial Catalog=mlb;User ID=sa;Password=1234";
        }


        /// <summary>
        /// 查詢ALL資料
        /// </summary>
        /// <returns></returns>
        public (Exception ex, IEnumerable<t_game> t_games, IEnumerable<t_kind> t_kinds) SelectAllData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    var results = con.QueryMultiple("spGetAllData", commandType: CommandType.StoredProcedure);
                    var t1 = results.Read<t_game>();
                    var t2 = results.Read<t_kind>();   
                    
                    return (null,t1,t2);
                }
            }
            catch (Exception ex)
            {
                // 處理例外
                Console.WriteLine($"Error: {ex.Message}");
                return (ex,null,null);
            }
        }


        /// <summary>
        /// 查詢賽事資料
        /// </summary>
        /// <returns>賽事列表</returns>
        public IEnumerable<t_game> SelectGames()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    var games = con.Query<t_game>("spSelectGames", commandType: CommandType.StoredProcedure);
                    return games;
                }
            }
            catch (Exception ex)
            {
                // 處理例外
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }

        /// <summary>
        /// 新增賽事資料
        /// </summary>
        /// <returns>RETURN VALUE</returns>
        public int CreateGame(t_game g)
        {
            try
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
                    int return_value = con.Execute("spCreateGame", parameters, commandType: CommandType.StoredProcedure);
               
                    return return_value;
                }
            }
            catch (Exception ex)
            {
                // 處理例外
                Console.WriteLine($"Error: {ex.Message}");
                return -1;
            }

        }
        /// <summary>
        /// 刪除賽事資料
        /// </summary>
        /// <returns>RETURN VALUE</returns>
        public int DeleteGame(string id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    // 準備參數
                    DynamicParameters parameters = new DynamicParameters();
                    // input
                    parameters.Add("@f_gameId", id, DbType.String, ParameterDirection.Input);
                    // 執行預存程序
                    int return_value = con.Execute("spDeleteGame", parameters, commandType: CommandType.StoredProcedure);
                    return return_value;
                }
            }
            catch (Exception ex)
            {
                // 處理例外
                Console.WriteLine($"Error: {ex.Message}");
                return -1;
            }

        }

    }
}
