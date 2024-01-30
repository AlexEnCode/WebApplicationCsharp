using System.Reflection;
using System.Threading.Channels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationDemo1.Models;

namespace WebApplicationDemo1.Controllers
{
	public class ContactController : Controller
	{
		List<Contact> listeContacts = new List<Contact>()
			{
			new Contact(1, "Jean", "Pleutre", "jp@oui.com"),
			new Contact(2, "Marie", "Curie", "marie@gmail.com"),
			new Contact(3, "Paul", "Dupont", "paul@yahoo.com"),
			new Contact(4, "Alice", "Martin", "alice@yahoo.com"),
			new Contact(5, "Bob", "Johnson", "bob@gmail.com"),
			new Contact(6, "Claire", "Dupuis", "claire@hotmail.com"),
			new Contact(7, "David", "Lefevre", "david@gmail.com"),
			new Contact(8, "Emma", "Leclerc", "emma@yahoo.com"),
			new Contact(9, "Frank", "Bertrand", "frank@hotmail.com"),
			new Contact(10, "Grace", "Lamoureux", "grace@gmail.com"),
			new Contact(11, "Hugo", "Rousseau", "hugo@yahoo.com"),
			new Contact(12, "Isabelle", "Moreau", "isabelle@hotmail.com"),
			new Contact(13, "Jack", "Gagnon", "jack@gmail.com")
			};


		public ActionResult Index()
		{

			return View(listeContacts);
		}


		public ActionResult Details()
		{



			return View();
		}

		public ActionResult Add()
		{
			return View();
		}

		public ActionResult FindbyID(int rechercheid)
		{

			Contact contact = listeContacts.FirstOrDefault(c => c.Id == rechercheid) ??  new Contact(404, "Je n'existe", "Pas", "déso@oui.com");

			if (contact != null)
				return View(contact); //contact.Nom contact.Prenom contact.Email
			else return View();

		}
	}
}