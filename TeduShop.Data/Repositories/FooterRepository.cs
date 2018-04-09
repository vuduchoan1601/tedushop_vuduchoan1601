using TeduShop.Data.Infrastructure;
using TeduShop.Model;

namespace TeduShop.Data.Repositories
{
    public interface IFooterRePository : IRepository<Footer>
    {

    }

    public class FooterRepository : RepositoryBase<Footer>,IFooterRePository
    {
        public FooterRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}