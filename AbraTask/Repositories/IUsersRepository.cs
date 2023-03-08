using AbraTaskAPI.Models.Domain;

namespace AbraTaskAPI.Repositories
{
    public interface IUsersRepository
    {
        public IEnumerable<User> GetAll();

        Task<User> GetAsync(string i_Gender);

    }
}
