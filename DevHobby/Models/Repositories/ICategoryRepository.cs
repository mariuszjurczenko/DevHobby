using DevHobby.Models.Entities;

namespace DevHobby.Models.Repositories
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
