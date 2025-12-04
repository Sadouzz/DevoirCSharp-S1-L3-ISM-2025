namespace Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public decimal PrixUnitaire { get; set; }

        public List<ApproArticle> ApproArticles { get; set; } = new List<ApproArticle>();

    }
}