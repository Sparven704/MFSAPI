using MFSAPI.Models;

namespace MFSAPI.Data
{
    public interface ITMDBRepository
    {
        Task<List<Genre>> GetMoviesByGenre(int genreId);
    }
}
