using MFSAPI.Models;

namespace MFSAPI.Data
{
    public interface IPersonGenreRepository
    {
        Task Add(PersonGenre personGenre);
    }
}
