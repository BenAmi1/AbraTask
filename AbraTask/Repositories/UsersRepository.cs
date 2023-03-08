using AbraTaskAPI.data;
using AbraTaskAPI.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace AbraTaskAPI.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private readonly AbraDbContext r_abraDbContext;

        public UsersRepository(AbraDbContext abraDbContext)
        {
            this.r_abraDbContext = abraDbContext;
        }

        public IEnumerable<User> GetAll()
        {
            return r_abraDbContext.user.ToList();
        }

        public async Task<User> GetAsync(string i_Gender)
        {
            return await r_abraDbContext.user.FirstOrDefaultAsync(x => x.gender == i_Gender);
        }

    }
}
