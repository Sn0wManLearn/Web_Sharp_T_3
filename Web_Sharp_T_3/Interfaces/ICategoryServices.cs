using Web_Sharp_T_3.Contracts.Requests.Categories;
using Web_Sharp_T_3.Contracts.Responses;

namespace Web_Sharp_T_3.Interfaces
{
    public interface ICategoryServices
    {
        public int AddCategory(CategoryCreateRequest category);

        public IEnumerable<CategoryResponse> GetCategories();

        public CategoryResponse GetCategoryById(int id);
    }
}
