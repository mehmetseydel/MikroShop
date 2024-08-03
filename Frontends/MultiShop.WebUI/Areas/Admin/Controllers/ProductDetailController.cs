using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MultiShop.DtoLayer.CatalogDtos.ProductDetailDtos;
using MultiShop.WebUI.Services.CatalogServices.ProductDetailServices;
using Newtonsoft.Json;
using System.Text;

namespace MultiShop.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
   // [AllowAnonymous]
    [Route("Admin/ProductDetail")]
    public class ProductDetailController : Controller
    {
        private readonly IProductDetailService _detailService;

        public ProductDetailController(IProductDetailService detailService)
        {
            _detailService = detailService;
        }

        [Route("UpdateProductDetail/{id}")]
        [HttpGet]
        public async Task<IActionResult> UpdateProductDetail(string id)
        {
            ViewBag.v1 = "Ana Sayfa";
            ViewBag.v2 = "Ürünler";
            ViewBag.v3 = "Ürün Açıklama ve Bilgi Güncelleme Sayfası";
            ViewBag.v0 = "Ürün İşlemleri";

            var values = await _detailService.GetByProductIdProductDetailAsync(id);
            return View(values);


            

        }
        [Route("UpdateProductDetail/{id}")]
        [HttpPost]
        public IActionResult UpdateProductDetail(UpdateProductDetailDto updateProductDetailDto)
        {
           
            var values = _detailService.UpdateProductDetailAsync(updateProductDetailDto);
            return RedirectToAction("ProductListWithCategory", "Product", new { area = "Admin" });


        }
    }
}


//await _imageService.UpdateProductImageAsync(updateProductImageDto);
//return RedirectToAction("Index", "Product", new { area = "Admin" });

 
 