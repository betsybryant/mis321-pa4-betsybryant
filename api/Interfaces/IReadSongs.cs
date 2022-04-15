using System.Collections.Generic;
using api.database;
using api.Models;

namespace api.Interfaces
{
    public interface IReadSongs
    {
         public List<Song> GetAll();

    }
}