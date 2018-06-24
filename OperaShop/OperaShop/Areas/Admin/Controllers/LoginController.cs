using OperaShop.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OperaShop.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        DBTest db = null;
        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }

        public LoginController()
        {
            db = new DBTest();
        }

        public int Login(string username,string password)
        {
            var result = db.NguoiDungs.SingleOrDefault(x => x.TaiKhoan == username);
            if(result==null)
            {
                return 0;
            }
            else
            {
                if (result.MatKhau == password)
                {
                    return 1;
                }
                else
                    return -2;
            }
        }

        public NguoiDung GetById(string id)
        {
            return db.NguoiDungs.SingleOrDefault(x => x.ID_NguoiDung == id);
        }

        [HttpPost]
        public ActionResult Login(Models.LoginModels model)
        {
            if (ModelState.IsValid)
            {

                var result = Login(model.Username, model.Password);
                if (result == 1)
                {
                    return RedirectToAction("Index", "Home");
                }
                else if(result==0)
                {
                    ModelState.AddModelError("", "Thông tin tên tài khoản không chính xác");
                }
                else
                    ModelState.AddModelError("", "Thông tin mật khẩu không chính xác");
            }
            return View("Index");
        }

    }
}