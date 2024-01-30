namespace WebApplicationDemo1.Models
{
    public class Contact
    {
        public int id; 
        private string nom = "Gontrand";
        private string prenom = "Flibustier";
        private string email = "nomail@flambi.fr";

        public int Id { get => id; set => id = value; }
		public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; } 
        public string Email { get => email; set => email = value; }

        public Contact(int id, string nom, string prenom, string email)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            Email = email;
        }
    }
}
