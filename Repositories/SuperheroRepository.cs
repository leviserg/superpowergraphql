using superpowergraphql.Data;
using superpowergraphql.Interfaces;

namespace superpowergraphql.Repositories
{
    public class SuperheroRepository : ISuperheroRepository
    {
        private readonly ApplicationDbContext _appDbContext;

        public SuperheroRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
    }
}
