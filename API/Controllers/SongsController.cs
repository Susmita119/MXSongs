using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Persistence;

namespace DatingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongsController : ControllerBase
    {
        DataContext _context; 

        public SongsController(DataContext context)
        {
                _context = context;
        }

        // GET api/songs
        [HttpGet]
        public ActionResult<IEnumerable<Song>> Get()
        {
            var songs = _context.Songs;
            return songs;
        }

        // GET api/songs/5
        [HttpGet("{id}")]
        public ActionResult<Song> Get(int id)
        {
            var song = _context.Songs.Find(id);
            return song;
        }

        // POST api/songs
        [HttpPost]
        public void Post([FromBody] Song song)
        {
            _context.Songs.Add(song);
            _context.SaveChanges();
        }

        // PUT api/songs/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Song song)
        {
           
            var entity = _context.Songs.FirstOrDefault(e =>e.Id == id);
            entity.Name = song.Name ?? entity.Name;
            entity.Artist = song.Artist ?? entity.Artist;
            entity.Movie= song.Movie ?? entity.Artist;

            _context.SaveChanges();
             
        }

        // DELETE api/songs/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
           _context.Songs.Remove(_context.Songs.FirstOrDefault(e=>e.Id==id));

           _context.SaveChanges();

        }
    }
}