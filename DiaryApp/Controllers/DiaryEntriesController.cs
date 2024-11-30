using DiaryApp.Data;
using DiaryApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DiaryApp.Controllers
{
    public class DiaryEntriesController : Controller
    {
        public IActionResult Index()
        {
            List<DiaryEntry> objDiaryEntriesList = _db.DiaryEntries.ToList();

            return View(objDiaryEntriesList);
        }

        private readonly ApplicationDbContext _db;

        public DiaryEntriesController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Create()
        {


            return View();
        }
        [HttpPost]
        public IActionResult Create(DiaryEntry obj)
        {
            //server side validation
            if (obj != null)
            {
                if (obj.Title.Length < 3)
                {
                    ModelState.AddModelError("Title", "Title too short!");
                }
                else if (obj.Title.Length > 15)
                {
                    ModelState.AddModelError("Title", "Title too long!");
                }

                if (obj.Content.Length < 15)
                {
                    ModelState.AddModelError("Content", "Description is too short!");
                }
                else if (obj.Content.Length > 500)
                {
                    ModelState.AddModelError("Content", "Description is too long!");
                }
            }


            //another server side validation
            if (ModelState.IsValid)
            {
                _db.DiaryEntries.Add(obj);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(obj);
        }

        public IActionResult Edit()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }

            DiaryEntry diaryEntry = _db.DiaryEntries.FirstOrDefault(x => x.Id == id);

            if (diaryEntry == null)
            {
                return NotFound();
            }

            return View(diaryEntry);
        }
        [HttpPost]
        public IActionResult Edit(DiaryEntry obj)
        {
            //server side validation
            if (obj != null)
            {
                if (obj.Title.Length < 3)
                {
                    ModelState.AddModelError("Title", "Title too short!");
                }
                else if (obj.Title.Length > 15)
                {
                    ModelState.AddModelError("Title", "Title too long!");
                }

                if (obj.Content.Length < 15)
                {
                    ModelState.AddModelError("Content", "Description is too short!");
                }
                else if (obj.Content.Length > 500)
                {
                    ModelState.AddModelError("Content", "Description is too long!");
                }
            }


            //another server side validation
            if (ModelState.IsValid)
            {
                _db.DiaryEntries.Update(obj);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(obj);
        }
    }
}
