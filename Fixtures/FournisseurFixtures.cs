using Models;

namespace Fixtures
{

    public static class FournisseursFixture
    {
        public static List<Fournisseur> GetFournisseurs()
        {
            return new List<Fournisseur>
        {
            new Fournisseur { Id = 1, Nom = "Textiles Dakar SARL", Tel = "77 123 45 67" },
            new Fournisseur { Id = 2, Nom = "Mercerie Centrale", Tel = "78 222 33 44" },
            new Fournisseur { Id = 3, Nom = "Tissus Premium", Tel = "76 987 65 43" }
        };
        }
    }

}