using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;
using Dapper.Contrib;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using QuidditchSimulator2k17.Models;

namespace QuidditchSimulator2k17.DataAccessLayer
{
    public class DAL
    {
        IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["connString"].ConnectionString);

        public List<Player> getPlayers()
        {
            List<Player> Players = new List<Player>(db.Query<Player>("SELECT player_id, name, age, number, position, team_id FROM Player"));

            return Players;
        }

        public List<Team> getTeams()
        {
            List<Team> Teams = new List<Team>(db.Query<Team>("SELECT team_id, name, school, captain, region_id, playercount FROM Team"));

            return Teams;
        }

        public List<Region> getRegions()
        {
            List<Region> Regions = new List<Region>(db.Query<Region>("Select region_id, name, location FROM Region"));

            return Regions;
        }

        public void registerTeam(string Name, string School, string Captain, int Region_id, int Playercount)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["connString"].ConnectionString))
            {
                connection.Open();
                string sql = "INSERT INTO Team(name, school, captain, region_id, playercount) VALUES(@name, @school, @captain, @region_id, @playercount)";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@name", Name);
                cmd.Parameters.AddWithValue("@school", School);
                cmd.Parameters.AddWithValue("@captain", Captain);
                cmd.Parameters.AddWithValue("@region_id", Region_id);
                cmd.Parameters.AddWithValue("@playercount", Playercount);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }
    }
}