using Kolokwium.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium.Services
{
    public class SqlServerArtistDbService : IArtistDbService
    {

        public IEnumerable<Artist> GetArtists()
        {
            var db = new ArtistDbContext();

            var artists = db.Artists.ToList();

            return artists;
        }
        public IEnumerable<Artist> GetArtist(int id)
        {
            var db = new ArtistDbContext();

            var artist = db.Artists
                .Where(a => a.IdArtist == id);
                    

            return artist;
        }
    }
}
