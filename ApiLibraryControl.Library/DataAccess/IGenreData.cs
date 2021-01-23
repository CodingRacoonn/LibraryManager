using ApiLibraryControl.Library.Models;

namespace ApiLibraryControl.Library.DataAccess
{
    public interface IGenreData
    {
        void AddGenre(GenreModel model);
    }
}