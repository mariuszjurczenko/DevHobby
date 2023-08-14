using DevHobby.Models.Entities;

namespace DevHobby.Models.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DevHobbyDbContext _devHobbyDbContext;

        public CategoryRepository(DevHobbyDbContext devHobbyDbContext)
        {
            _devHobbyDbContext = devHobbyDbContext;
        }

        public IEnumerable<Category> AllCategories 
            => _devHobbyDbContext.Categories
                .OrderBy(c => c.Name);
    }
}
