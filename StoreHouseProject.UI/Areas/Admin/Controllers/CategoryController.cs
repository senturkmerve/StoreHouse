using StoreHouseProject.Model.Option;
using StoreHouseProject.Service.Option;
using StoreHouseProject.UI.Areas.Admin.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StoreHouseProject.UI.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        CategoryService _categoryService;

        public CategoryController()
        {
            _categoryService = new CategoryService();
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Category data)
        {
            try
            {
                _categoryService.Add(data);
                TempData["Successful"] = "Transaction is successful.";
                return RedirectToAction("List", "Category");
            }
            catch (Exception)
            {
                _categoryService.Add(data);
                TempData["Error"] = "Transaction is fail.";
                return RedirectToAction("Add", "Category");
            }

        }

        public ActionResult List()
        {
            List<Category> model = _categoryService.GetActive();
            return View(model);
        }

        public ActionResult Update(Guid id)
        {
            Category category = _categoryService.GetByID(id);
            CategoryDTO model = new CategoryDTO();
            model.ID = category.ID;
            model.Name = category.Name;
            model.Description = category.Description;
            return View(model);
        }

        [HttpPost]
        public ActionResult Update(CategoryDTO data)
        {
            try
            {
                Category category = _categoryService.GetByID(data.ID);
                category.Name = data.Name;
                category.Description = data.Description;
                _categoryService.Update(category);
                TempData["Successful"] = "Transaction is successful.";
                return Redirect("/Admin/Category/List");
            }
            catch (Exception)
            {
                Category category = _categoryService.GetByID(data.ID);
                category.Name = data.Name;
                category.Description = data.Description;
                _categoryService.Update(category);
                TempData["Error"] = "Transaction is fail.";
                return Redirect("/Admin/Category/List");
            }

        }

        public ActionResult Delete(Guid id)
        {
            try
            {
                _categoryService.Remove(id);
                TempData["Successful"] = "Transaction is successful.";
                return Redirect("/Admin/Category/List");
            }
            catch (Exception)
            {
                _categoryService.Remove(id);
                TempData["Error"] = "Transaction is fail.";
                return Redirect("/Admin/Category/List");
            }

        }
    }
}