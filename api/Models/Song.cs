using System;
namespace api.Models
{
    public class Song
    {
        public int Id {get; set;}
        public string Title {get; set;}
        public DateTime DateAdded {get; set;}
        public bool Deleted {get; set;}
        public bool Favorited {get; set;}
        
    }
}