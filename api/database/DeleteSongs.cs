using api.Interfaces;
using api.Models;
using mis321_pa4_betsybryant;
using MySql;
using System.Data;
using MySql.Data.MySqlClient;
using System;
namespace api.database
{
    public class DeleteSongs
    {
        public static void DropSongTable()
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"DROP TABLE IF EXISTS songs";

            using var cmd = new MySqlCommand(stm, con);

            cmd.ExecuteNonQuery();
        }
        public void Delete(int id)
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            Song song = new Song();

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"UPDATE songs set Deleted = true where SongId = @SongId";
            using var cmd = new MySqlCommand(stm, con);
            cmd.Parameters.AddWithValue("SongId", id);
            //cmd.Parameters.AddWithValue("Deleted", true);
            cmd.Prepare();

            cmd.ExecuteNonQuery();
        }
    }
}