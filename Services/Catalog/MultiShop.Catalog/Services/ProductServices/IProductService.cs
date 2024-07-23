using MultiShop.Catalog.Dtos.ProductDtos;

namespace MultiShop.Catalog.Services.ProductServices
{
    public interface IProductService
    {
        //buraya gelirken ilk adım dto 'ise burda da en önemli yer burası unutma

        Task<List<ResultProductDto>> GettAllProductAsync();
        Task CreateProductAsync(CreateProductDto createProductDto);
        Task UpdateProductAsync(UpdateProductDto updateProductDto);
        Task DeleteProductAsync(string id);
        Task<GetByIdProductDto> GetByIdProductAsync(string id);
        Task<List<ResultProductsWithCategoryDto>> GetProductsWithCategoryAsync();
        Task<List<ResultProductsWithCategoryDto>> GetProductsWithCategoryByCatetegoryIdAsync(string CategoryId);


    }
}
