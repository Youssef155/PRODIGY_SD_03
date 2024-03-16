using ContactManagementSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContactManagementSystem.Controllers
{
    public class ContactController : Controller
    {
        private static List<ContactInfoViewModel> contacts = new List<ContactInfoViewModel>();

        // GET: ContactController
        public ActionResult Index()
        {
            return View(contacts);
        }

        // GET: ContactController/Create
        public ActionResult Create()
        {
            var contVM = new ContactInfoViewModel();
            return View(contVM);
        }

        public ActionResult CreateContact(ContactInfoViewModel contactInfoViewModel)
        {
            contacts.Add(contactInfoViewModel);
            return RedirectToAction(nameof(Index));
        }

        // GET: ContactController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // GET: ContactController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

    }
}
