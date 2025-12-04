using Models;
namespace Fixtures
{


    public static class ArticleFixtures
    {
        public static List<Article> GetArticles()
        {
            return new List<Article>
        {
            new Article { Id = 1, Nom = "Tissu Coton", PrixUnitaire = 1500 },
            new Article { Id = 2, Nom = "Fil Polyester", PrixUnitaire = 500 },
            new Article { Id = 3, Nom = "Boutons Métal", PrixUnitaire = 100 },
            new Article { Id = 4, Nom = "Fermeture Éclair", PrixUnitaire = 300 }
        };
        }
    }

}