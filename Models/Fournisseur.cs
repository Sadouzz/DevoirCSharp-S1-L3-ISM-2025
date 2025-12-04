namespace Models
{
    public class Fournisseur
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Tel { get; set; }

        public List<Approvisionnement> approvisionnements {get; set;} = new List<Approvisionnement>();
    }
}