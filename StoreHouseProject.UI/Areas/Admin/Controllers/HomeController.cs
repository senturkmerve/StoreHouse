using StoreHouseProject.Service.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StoreHouseProject.UI.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult AdminIndex()
        {
            return View();
        }
       
      
        CategoryService _categoryService;
        AppUserService _appUserService;
        ProductService _productService;
       

        public HomeController()
        {
          
            _categoryService = new CategoryService();
            _appUserService = new AppUserService();
            _productService = new ProductService();
           
        }

       
        
    }
}