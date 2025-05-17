using Web_Sharp_T_3.Models;

namespace Web_Sharp_T_3.Interfaces
{
    public interface ICategoryManager
    {
        IEnumerable<Category> GetCategories();
        int AddCategory(Category categoryDTO);
        bool DeleteCategory(int id);
    }
}
