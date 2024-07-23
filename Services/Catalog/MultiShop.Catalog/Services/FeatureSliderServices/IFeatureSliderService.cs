using MultiShop.Catalog.Dtos.FeatureSliderDtos;
using System.Security.AccessControl;

namespace MultiShop.Catalog.Services.FeatureSliderServices
{
    public interface IFeatureSliderService
    {
        Task<List<ResultFeatureSliderDto>> GetAllFeatureSliderAsync();
        Task CreateFeatureSliderAsync(CreateFeatureSliderDto createFeatureSliderDto);
        Task UpdateFeatureSliderAsync(UpdateFeatureSliderDto updateFeatureSliderDto);
        Task DeleteFeatureSliderAsync(string id);
        Task<GetByIdFeatureSliderDto> GetByIdFeatureSliderAsync(string id);
        Task FeatureSliderChageStatusToTrue(string id); //burda duruma bağlı bool status alanı true için
        Task FeatureSliderChageStatusToFalse(string id);//burda duruma bağlı bool status alanı false için
    }
}

 
 
 
//11sk<GetByIdCategoryDto> GetByIdCategoryAsync(string id);
