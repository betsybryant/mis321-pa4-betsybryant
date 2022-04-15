using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using api.Models;
using Microsoft.AspNetCore.Cors;
using api.database;
using api.Interfaces;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongsController : ControllerBase
    {
        // GET: api/Songs -async
        [EnableCors("OpenPolicy")]
        [HttpGet]
        public List<Song> Get()
        {
            ReadSongs readSongs = new ReadSongs();
            return readSongs.GetAll();
        }

        // GET: api/Songs -async/5
        // [EnableCors("OpenPolicy")]
        // [HttpGet("{id}", Name = "Get")]
        // public string Get(int id)
        // {
        //     ReadSongs read = new ReadSongs();
        //     ;
        // }

        // POST: api/Songs -async
        [EnableCors("OpenPolicy")]
        [HttpPost(Name="PostSong")]
        public void Post([FromBody] Song value) //add
        {
            CreateSongs createSongs = new CreateSongs();
            createSongs.CreateASong(value);
            //add song 
        }

        // PUT: api/Songs -async/5
        [EnableCors("OpenPolicy")]
        [HttpPut("{id}")]
        public void Put(int id) //update
        {
            EditSongs edit = new EditSongs();
            edit.Update(id);
            //update 
            // ading favorites
        }

        // DELETE: api/Songs -async/5
        [EnableCors("OpenPolicy")]
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            DeleteSongs deleteSongs = new DeleteSongs();
            deleteSongs.Delete(id);
        }
    }
}
