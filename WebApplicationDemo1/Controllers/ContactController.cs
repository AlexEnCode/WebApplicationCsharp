using System.Threading.Channels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationDemo1.Models;

namespace WebApplicationDemo1.Controllers
{
    public class ContactController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Details()
        {
            NewContact nouveauContact = new("Jean", "Pleutre", "jp@oui.com");

            ViewData["Nouveau Contact"] = nouveauContact;
            ViewBag.nouveauContact = nouveauContact;


            return View(nouveauContact);
        }
        public ActionResult Add()
        {
            return View();
        }

    }
}

