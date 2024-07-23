using AutoMapper;
using MongoDB.Driver;
using MultiShop.Catalog.Dtos.CategoryDtos;
using MultiShop.Catalog.Entites;
using MultiShop.Catalog.Settings;

namespace MultiShop.Catalog.Services.CategoryServices
{
    public class CategoryService : ICategoryService
    {
        private readonly IMongoCollection<Category> _categoryCollection;
        private readonly IMapper _mapper;
        public CategoryService(IMapper mapper, IDatabaseSettings _databaseSettings)
        {
            //ctorda hazır mongodb database gelsin ve maplemede olsun 
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _categoryCollection = database.GetCollection<Category>(_databaseSettings.CategoryCollectionName);
            _mapper = mapper;
        }
        public async Task CreateCategoryAsync(CreateCategoryDto createCategoryDto)
        {
            var value = _mapper.Map<Category>(createCategoryDto);//burda maple entity ile dto arasında
            await _categoryCollection.InsertOneAsync(value);//en son mongodb veritabanına ulaş!
        }

        public async Task DeleteCategoryAsync(string id)
        {
            await _categoryCollection.DeleteOneAsync(x => x.CategoryId == id);//Id'ye göre çek
        }

        public async Task<GetByIdCategoryDto> GetByIdCategoryAsync(string id)
        {
            var values = await _categoryCollection.Find<Category>(x => x.CategoryId == id).FirstOrDefaultAsync();//tek sonuç dönsün
            return _mapper.Map<GetByIdCategoryDto>(values);
        }

        public async Task<List<ResultCategoryDto>> GettAllCategoryAsync()
        {
            var values = await _categoryCollection.Find(x => true).ToListAsync();//listele
            return _mapper.Map<List<ResultCategoryDto>>(values);
        }

        public async Task UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto)
        {
            var values = _mapper.Map<Category>(updateCategoryDto);
            await _categoryCollection.FindOneAndReplaceAsync(x => x.CategoryId == updateCategoryDto.CategoryId, values);//mongodb update için 
        }
    }
}
