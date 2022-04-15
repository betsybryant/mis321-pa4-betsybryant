using System.Collections.Generic;
using api.Models;

namespace api.Interfaces
{
    public interface ISongUtil
    {
         public List<Song> playlist { get; set; }
         public void AddSong();
         public void DeleteSong();
         public void EditSong();
         public void PrintPlaylist();
    }
}