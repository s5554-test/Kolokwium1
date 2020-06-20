using Kolokwium.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium.Services
{
    public interface IArtistDbService
    {
        IEnumerable<Artist> GetArtist(int id);
        IEnumerable<Artist> GetArtists();
        
    }
}
