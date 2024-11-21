using BeautyShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace BeautyShop.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManagementContext _db;

        public UserController(UserManagementContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<TblUser> objUser = _db.TblUsers;
            return View(objUser);
        }

        // GET
        public IActionResult Create()
        {
            return View();
        }
    }
}
