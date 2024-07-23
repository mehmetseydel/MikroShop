using MultiShop.Catalog.Dtos.CategoryDtos;

namespace MultiShop.Catalog.Services.CategoryServices
{
    public interface ICategoryService
    {
        //buraya gelirken ilk adım dto 'ise burda da en önemli yer burası unutma
        Task<List<ResultCategoryDto>> GettAllCategoryAsync();
        Task CreateCategoryAsync(CreateCategoryDto createCategoryDto);
        Task UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto);
        Task DeleteCategoryAsync(string id);
        Task<GetByIdCategoryDto> GetByIdCategoryAsync(string id);
    }
}
