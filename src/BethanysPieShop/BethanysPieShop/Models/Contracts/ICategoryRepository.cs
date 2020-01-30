using System.Collections.Generic;

namespace BethanysPieShop.Models.Contracts
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
