using Models;

namespace Fixtures
{

    public static class ApproArticleFixtures
    {
        public static List<ApproArticle> GetApproArticles()
        {
            return new List<ApproArticle>
        {
            new ApproArticle { Id = 1, ApproId = 1, ArticleId = 1, Quantite = 200, Montant = 200 * 1500 },
            new ApproArticle { Id = 2, ApproId = 1, ArticleId = 2, Quantite = 100, Montant = 100 * 500 },

            new ApproArticle { Id = 3, ApproId = 2, ArticleId = 4, Quantite = 50, Montant = 50 * 300 },

            new ApproArticle { Id = 4, ApproId = 3, ArticleId = 3, Quantite = 300, Montant = 300 * 100 },
            new ApproArticle { Id = 5, ApproId = 3, ArticleId = 1, Quantite = 150, Montant = 150 * 1500 }
        };
        }
    }

}