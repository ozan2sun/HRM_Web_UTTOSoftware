using ENTITIES.HRM_Web_UTTOSoftware.Entities;
using ENTITIES.HRM_Web_UTTOSoftware.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRM_Web_UTTOSoftware_UI.Areas.Manager
{
    [Area("Manager")]
    public class HomeController : Controller
    {
        // GET: HomeController
        public ActionResult Index()
        {
            Person testPerson = new Person()
            {
                FirstName = "Utku",
                LastName = "Koç",
                Address = "Çayyolu",
                BirthDate = DateTime.Now.AddYears(-27),
                CompanyInfo = "UTTO Software",
                ID = 1,
                HireDate = DateTime.Now,
                DepartmansEnum = DepartmansEnum.Yazilim,
                IsActive = true,
                Job = "Yazılım Backend",
                Mail = "UtkuAskin.Koc@bilgeadam.com",
                PersonelPhoneNumber = "5070271616",
                TC = 1111111111,

            };

            return View(testPerson);
        }

        // GET: HomeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HomeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HomeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HomeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HomeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
