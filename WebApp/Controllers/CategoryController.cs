using IDAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class CategoryController : Controller
    {
        private ICategoryManager _dal;

        public CategoryController(ICategoryManager dal) {

            _dal = dal;
        }
        // GET: Category
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Category category) {
            int num = _dal.CateAdd(category);
            if (num > 0) {
                return Content("<script>'添加成功'</script>");
            }
            else {
                return Content("<script>'添加失败'</script>");
            }
           
        }

    }
}