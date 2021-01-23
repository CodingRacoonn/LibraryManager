using ApiLibraryControl.Library.DataAccess;
using ApiLibraryControl.Library.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLibraryControl.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        private readonly IGenreData _data;

        public GenreController(IGenreData data)
        {
            _data = data;
        }

        [Route("AddGenre")]
        [HttpPost]
        public void AddGenre([FromBody] GenreModel model)
        {
            _data.AddGenre(model);
        }
    }
}
