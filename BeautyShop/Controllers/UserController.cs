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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(TblUser user)
        {
            if (ModelState.IsValid)
            {
                _db.TblUsers.Add(user);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(user);
        }

        // GET 
        public IActionResult Edit(string id)
        {
            if (id == null || id == "")
            {
                return NotFound();
            }
            var user = _db.TblUsers.Find(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(TblUser user)
        {
            if (ModelState.IsValid)
            {
                _db.TblUsers.Update(user);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(user);
        }

        public IActionResult Details(string id)
        {
            if (id == null || id == "")
            {
                return NotFound();
            }
            var user = _db.TblUsers.Find(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        public IActionResult Delete(string id)
        {
            if (id == null || id == "")
            {
                return NotFound();
            }
            var user = _db.TblUsers.Find(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }
    }
}
