using BlazorCRUD.Model;

namespace BlazorCrud.UI.Interfaces
{
    public interface IFilmService
    {
        Task<IEnumerable<Film>> GetAllFilms();
        Task<Film> GetDetails(int id);
        Task<bool> DeleteFilm(int id);
        Task<bool> SaveFilm(Film film);

    }
}
