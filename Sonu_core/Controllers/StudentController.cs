using Microsoft.AspNetCore.Mvc;
using Sonu_core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sonu_core.Controllers
{
    public class StudentController : Controller
    {
        private readonly studentContext _db;
        public StudentController(studentContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var res = _db.Studentmodels.ToList();
            return View(res);
        }
        public IActionResult Delete(int id)
        {
            var Dt = _db.Studentmodels.Where(x => x.id == id).FirstOrDefault();
            _db.Studentmodels.Remove(Dt);
            _db.SaveChanges();
            return RedirectToAction("index");
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Studentmodel s)
        {
            _db.Studentmodels.Add(s);
            _db.SaveChanges();
            return RedirectToAction("index");
        }
        public IActionResult Edit(int id)
        {
           var res= _db.Studentmodels.Where(a => a.id == id).FirstOrDefault();
            return View(res);
        }
        [HttpPost]
        public IActionResult Edit(Studentmodel obj)
        {
            _db.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

       

    }
}
