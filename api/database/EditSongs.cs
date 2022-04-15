using System;
using api.Models;
using mis321_pa4_betsybryant;
using MySql.Data.MySqlClient;

namespace api.database
{
    public class EditSongs
    {
        public void Update(int id)
        {
            EditSongs edit = new EditSongs();
            Song song = new Song();
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();
            
            string stm = @"UPDATE songs SET Favorited = true WHERE SongId = @SongId";
            using var cmd = new MySqlCommand(stm, con);
            cmd.Parameters.AddWithValue("@SongId", id);

            cmd.Prepare();
            cmd.ExecuteNonQuery();
            Console.Clear();
        }
    }
}