using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_MLB.Model
{
    public class t_game
    {
        public string f_gameId { get; set; } 
        public string f_gameDate { get; set; } 
        public int f_gameStatus { get; set; }
        public int f_teamAId { get; set; }
        public int f_teamBId { get; set; }
        public int f_ra { get; set; }
        public int f_rb { get; set; }
        public int f_playerAId { get; set; }
        public int f_playerBId { get; set; }
        public int f_sourceId { get; set; }
        public string? f_desc { get; set; }
    }
}

