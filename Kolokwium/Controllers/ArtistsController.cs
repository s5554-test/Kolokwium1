using Kolokwium.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium.Controllers
{
    [ApiController]
    [Route("api/artists")]
    public class ArtistsController : ControllerBase
    {

        private IArtistDbService _dbService;

        public IConfiguration Configuration { get; set; }

        public ArtistsController(IArtistDbService service, IConfiguration configuration)
        {
            _dbService = service;
            Configuration = configuration;
        }



        [HttpGet]
        public IActionResult GetArtist(int id)
        {
            return Ok(_dbService.GetArtist(id));
        }

        [HttpGet]
        public IActionResult GetArtists()
        {

            return Ok(_dbService.GetArtists());
        }
    }
}
