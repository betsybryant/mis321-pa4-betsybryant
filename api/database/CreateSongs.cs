using api.Interfaces;
using api.Models;
using mis321_pa4_betsybryant;
using MySql;
using System.Data;
using MySql.Data.MySqlClient;

namespace api.database
{
    public class CreateSongs : ICreateSongs
    {
        public static void CreateSongTable()
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"CREATE TABLE songs(ID INTEGER PRIMARY KEY AUTO_INCREMENT, SongTitle TEXT, SongTimestamp DATETIME, Deleted TINYINT, Favorited TINYINT)";

            using var cmd = new MySqlCommand(stm, con);

            cmd.ExecuteNonQuery();
        }
        public void CreateASong(Song mySong)
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();  

            string stm = @"INSERT INTO songs(SongTitle, SongTimeStamp, Deleted, Favorited) VALUES(@SongTitle, @SongTimeStamp, @Deleted, @Favorited)";

            using var cmd = new MySqlCommand(stm, con);
            cmd.Parameters.AddWithValue("@ID", mySong.Id);
            cmd.Parameters.AddWithValue("@SongTitle", mySong.Title);
            cmd.Parameters.AddWithValue("@SongTimestamp", mySong.DateAdded);
            cmd.Parameters.AddWithValue("@Deleted", false);
            cmd.Parameters.AddWithValue("@Favorited", false);

            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }

        public void Create()
        {
            throw new System.NotImplementedException();
        }
    }
}