using AW.UI.Helpers;
using AW.UI.Models;
using AW.UI.Services;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace AW.UI.Controllers
{
    public class HomeController : BaseController
    {
        private readonly IAcccessWebApi _iAcccessWebApi;

        public HomeController() : this(new AcccessWebApi())
        {

        }

        public HomeController(IAcccessWebApi iAcccessWebApi)
        {
            _iAcccessWebApi = iAcccessWebApi;
        }

        [HttpGet]
        public async Task<ActionResult> Index()
        {
            var categories = await _iAcccessWebApi.GetAsync<ProductCategory>(Constants.categoriesLink);

            return View(categories);
        }

        [HttpGet]
        public async Task<JsonResult> GetSubcategories(int categoryId)
        {
            var subcategories = await _iAcccessWebApi.GetAsync<ProductSubcategory>(Constants.subcategoriesLink + categoryId);
            
            return Json(subcategories, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public async Task<JsonResult> GetProducts(int subcategoryId)
        {
            var products = await _iAcccessWebApi.GetAsync<Product>(Constants.subcategoryProductsLink + subcategoryId);
            
            return Json(products, JsonRequestBehavior.AllowGet);
        }
    }
}