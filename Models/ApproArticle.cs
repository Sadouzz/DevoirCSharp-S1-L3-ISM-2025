namespace Models
{
    public class ApproArticle
    {
        public int Id { get; set; }
        public int Quantite { get; set; }
        public decimal Montant { get; set; }

        public int ApproId { get; set; }  
        public int ArticleId { get; set; }


        public Approvisionnement Appro { get; set; }
        public Article Article { get; set; }
    }

}