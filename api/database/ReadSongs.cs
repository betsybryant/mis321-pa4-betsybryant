using api.Interfaces;
using api.Models;
using mis321_pa4_betsybryant;
using MySql;
using System.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System;

namespace api.database
{
    public class ReadSongs
    {
        public List<Song> GetAll()
        {
            List<Song> mySongs = new List<Song>();
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            Song song = new Song();

            string stm = @"SELECT * from songs ORDER BY SongTimestamp DESC";
            using var cmd = new MySqlCommand(stm, con);
            using MySqlDataReader read = cmd.ExecuteReader();
            // Console.Clear();
            while(read.Read())
            {
                mySongs.Add(new Song(){
                    Id = read.GetInt32(0),
                    Title = read.IsDBNull(1) ? null : read.GetString(1),
                    DateAdded = read.IsDBNull(2) ? DateTime.MinValue : read.GetDateTime(2),
                    Deleted = read.GetBoolean(3),
                    Favorited = read.GetBoolean(4)
                    // IsFavorited = new ReadFavorited().Check(read.GetInt32(0))
                });
            }
            return mySongs;
        }
    }
}