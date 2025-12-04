using Models;

namespace Fixtures
{

    public static class ApprovisionnementFixtures
    {
        public static List<Approvisionnement> GetApprovisionnements()
        {
            return new List<Approvisionnement>
        {
            new Approvisionnement
            {
                Id = 1,
                Reference = "APP-2023-001",
                DateApprovisionnement = new DateTime(2023, 4, 15),
                Commentaires = "",
                IdFournisseur = 1,
                Statut = StatutAppro.RECU
            },
            new Approvisionnement
            {
                Id = 2,
                Reference = "APP-2023-002",
                DateApprovisionnement = new DateTime(2023, 4, 10),
                Commentaires = "",
                IdFournisseur = 2,
                Statut = StatutAppro.RECU
            },
            new Approvisionnement
            {
                Id = 3,
                Reference = "APP-2023-003",
                DateApprovisionnement = new DateTime(2023, 4, 5),
                Commentaires = "",
                IdFournisseur = 3,
                Statut = StatutAppro.EN_ATTENTE
            }
        };
        }
    }

}