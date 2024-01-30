namespace WebApplicationDemo1.Models
{
    public class NewContact
    {
        private string nom = "Gontrand";
        private string prenom = "Flibustier";
        private string email = "nomail@flambi.fr";

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; } 
        public string Email { get => email; set => email = value; }

        public NewContact(string nom, string prenom, string email)
        {
            Nom = nom;
            Prenom = prenom;
            Email = email;
        }
    }
}
