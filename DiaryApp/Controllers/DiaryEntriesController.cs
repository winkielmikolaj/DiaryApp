﻿using DiaryApp.Data;
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
            _db.DiaryEntries.Add(obj);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
