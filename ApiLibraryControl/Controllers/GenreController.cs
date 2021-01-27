using ApiLibraryControl.Library.DataAccess;
using ApiLibraryControl.Library.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLibraryControl.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        private readonly IGenreData _data;

        public GenreController(IGenreData data)
        {
            _data = data;
        }

        [Authorize(Roles = "Admin,Manager,Librarian")]
        [Route("AddGenre")]
        [HttpPost]
        public void AddGenre(GenreModel model)
        {
            _data.AddGenre(model);
        }
    }
}
