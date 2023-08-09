using DevHobby.Models.Entities;

namespace DevHobby.Models.Repositories
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category
                {
                    CategoryId = 1,
                    Name= "CSHARP"
                },
                new Category
                {
                    CategoryId = 2,
                    Name= "ASP NET CORE"
                },
                new Category
                {
                    CategoryId = 3,
                    Name= "CMS"
                },
                new Category
                {
                    CategoryId = 4,
                    Name= "DOBRE PRAKTYKI"
                },
                new Category
                {
                    CategoryId = 5,
                    Name= "PRAKTYCZNE PROJEKTY"
                },
                new Category
                {
                    CategoryId = 6,
                    Name= "JAVA SCRIPT"
                },
                new Category
                {
                    CategoryId = 7,
                    Name= "ANGULAR"
                },
            };
    }
}
