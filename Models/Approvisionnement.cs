namespace Models
{
    public enum StatutAppro
    {
        RECU,
        EN_ATTENTE
    }

    public class Approvisionnement
    {
        public int Id { get; set; }
        public string Reference { get; set; }
        public DateTime DateApprovisionnement { get; set; } = DateTime.UtcNow;

        public decimal MontantTotal { get; set; }
        public string Commentaires { get; set; }
        public int FournisseurId { get; set; }
        public Fournisseur Fournisseur { get; set; }
        public StatutAppro Statut { get; set; }
        public List<ApproArticle> ApproArticles { get; set; } = new List<ApproArticle>();
    }
}
