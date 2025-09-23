using CoreProjectVikrantPractice1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Mono.TextTemplating;
using System.Diagnostics;

namespace CoreProjectVikrantPractice1.Controllers
{
    public class HomeController : Controller
    {
        private readonly CandidateDBContext db;
        private readonly IWebHostEnvironment _ev;

        public HomeController(CandidateDBContext _db, IWebHostEnvironment ev)
        {
            db = _db;
            _ev = ev;
        }

      
        public IActionResult Create()
       {
            var row = db.listOfDesingnation();
            ViewBag.Desingnation = new SelectList(row,"JobId", "JobTitle");
            var list = db.GetCountry();
            ViewBag.Country = new SelectList(list,"CountryId", "CountryName");
            return View();
       }

        [HttpPost]
        public JsonResult GetStateName(int countryid)
        {
            var state = db.GetStates(countryid);
            return Json(state);


        }

        [HttpPost]
        public JsonResult GetCityName(int stateid)
        {
            var row = db.GetCity(stateid);
            return Json(row);
        }

        [HttpPost]
        public IActionResult Create(CandidateDBModel candidateDB, IFormFile photoFile)
        {
            if (ModelState.IsValid)
            {
                string fileName = null;

                if (photoFile != null && photoFile.Length > 0)
                {
                    // Generate unique file name
                    fileName = Guid.NewGuid().ToString() + Path.GetExtension(photoFile.FileName);

                    // Create uploads folder if not exists
                    string uploadPath = Path.Combine(_ev.WebRootPath, "Images");
                    if (!Directory.Exists(uploadPath))
                    {
                        Directory.CreateDirectory(uploadPath);
                    }

                    // Full path
                    string filePath = Path.Combine(uploadPath, fileName);

                    // Save file
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        photoFile.CopyTo(stream);
                    }

                    // Assign file name to model property (make sure CandidateDBModel has Photo column)
                    candidateDB.Photo = fileName;
                }

                // Save candidate data with photo name in DB
                db.CreateCandidateData(candidateDB);

                return RedirectToAction("Index");
            }
            // Model state invalid: repopulate dropdown data
            var row = db.listOfDesingnation();
            ViewBag.Desingnation = new SelectList(row, "JobId", "JobTitle");

            var list = db.GetCountry();
            ViewBag.Country = new SelectList(list, "CountryId", "CountryName");
            return View(candidateDB);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
