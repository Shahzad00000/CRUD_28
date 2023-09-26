using CRUD_28.Context;
using CRUD_28.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CRUD_28.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var Data=_context.Students.ToList();
            return View(Data);
        }
        [HttpGet]
        public IActionResult Create()
        {
             return View();
        }
        [HttpPost]  
        public IActionResult Create(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var data=_context.Students.Where(z=>z.Id==Id).SingleOrDefault();    
            return View(data);
        }
        [HttpPost]  
        public IActionResult Edit(Student student)
        {
            _context.Students.Update(student);
            _context.SaveChanges(); 
            return RedirectToAction("Index");
        }
        public IActionResult Details(int Id)
        {
            var data = _context.Students.Where(z => z.Id == Id).SingleOrDefault();
            return View(data);
        }
        public IActionResult Delete(int Id)
        {
            var Data=_context.Students.Where(x=>x.Id==Id).SingleOrDefault();
            _context.Students.Remove(Data);
            _context.SaveChanges(); 
            return RedirectToAction("Index");
        }
    }
}
