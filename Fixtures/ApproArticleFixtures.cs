using Models;

namespace Fixtures
{

    public static class ApproArticleFixtures
    {
        public static List<ApproArticle> GetApproArticles()
        {
            return new List<ApproArticle>
        {
            new ApproArticle { Id = 1, IdAppro = 1, IdArticle = 1, Quantite = 200, Montant = 200 * 1500 },
            new ApproArticle { Id = 2, IdAppro = 1, IdArticle = 2, Quantite = 100, Montant = 100 * 500 },

            new ApproArticle { Id = 3, IdAppro = 2, IdArticle = 4, Quantite = 50, Montant = 50 * 300 },

            new ApproArticle { Id = 4, IdAppro = 3, IdArticle = 3, Quantite = 300, Montant = 300 * 100 },
            new ApproArticle { Id = 5, IdAppro = 3, IdArticle = 1, Quantite = 150, Montant = 150 * 1500 }
        };
        }
    }

}