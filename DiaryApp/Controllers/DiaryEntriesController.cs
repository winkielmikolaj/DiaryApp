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
    }
}
