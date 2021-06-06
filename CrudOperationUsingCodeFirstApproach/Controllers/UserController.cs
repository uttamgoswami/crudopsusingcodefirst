using DAL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudOperationUsingCodeFirstApproach.Controllers
{
    public class UserController : Controller
    {
        DatabaseContext _db;

        public UserController(DatabaseContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var ListData = _db.Users.Select(x => x).ToList();
            return View(ListData);
        }

        public IActionResult Create()
        {
            ViewBag.CityList = _db.Cities.Select(x => x).ToList();
            ViewBag.CountryList = _db.Countries.Select(y => y).ToList();

            return View();
        }
        [HttpPost]
        public IActionResult Create(User userModel)
        {
            ModelState.Remove("UserId");
           if(ModelState.IsValid)
            {
                _db.Users.Add(userModel);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CityList = _db.Cities.Select(x => x).ToList();
            ViewBag.CountryList = _db.Countries.Select(y => y).ToList();
            return View();
        }

        public IActionResult Edit(int id)
        {
            User usermodel = _db.Users.Find(id);
            ViewBag.CityList = _db.Cities.Select(x => x).ToList();
            ViewBag.CountryList = _db.Countries.Select(y => y).ToList();

            return View("Create", usermodel);
        }
        [HttpPost]
        public IActionResult Edit(User userModel)
        {
            if (ModelState.IsValid)
            {
                _db.Users.Update(userModel);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CityList = _db.Cities.Select(x => x).ToList();
            ViewBag.CountryList = _db.Countries.Select(y => y).ToList();
            return View("Create", userModel);
        }

        public IActionResult Delete(int id)
        {
            User usermodel = _db.Users.Find(id);
            if(usermodel!=null)
            {
                _db.Users.Remove(usermodel);
                _db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
