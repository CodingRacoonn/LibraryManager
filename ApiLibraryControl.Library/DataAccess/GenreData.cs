using ApiLibraryControl.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiLibraryControl.Library.DataAccess
{
    public class GenreData : IGenreData
    {
        private readonly ISqlDataAccess _dataAccess;

        public GenreData(ISqlDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public void AddGenre(GenreModel model)
        {
            _dataAccess.SaveData("spGenre_AddGenre", model, "LibraryDatabase");
        }
    }
}
