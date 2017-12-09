using AW.UI.Helpers;
using AW.UI.Models;
using AW.UI.Services;
using AW.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace AW.UI.Controllers
{
    public class ProductController : Controller
    {

        private readonly IAcccessWebApi _iAcccessWebApi;

        public ProductController() : this(new AcccessWebApi())
        {

        }

        public ProductController(IAcccessWebApi iAcccessWebApi)
        {
            _iAcccessWebApi = iAcccessWebApi;
        }
        
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public async Task<ActionResult> Create(EditProductViewModel product)
        {
            await _iAcccessWebApi.PostAsync<EditProductViewModel>(Constants.createProductLink, product);

            return RedirectToAction("Index", "Home");
        }
    }
}