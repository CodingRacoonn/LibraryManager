using System.Threading.Tasks;
using WpfInterface.Library.Models;

namespace WpfInterface.Library.API
{
    public interface IGenreEndpoint
    {
        Task AddGenre(GenreModel model);
    }
}