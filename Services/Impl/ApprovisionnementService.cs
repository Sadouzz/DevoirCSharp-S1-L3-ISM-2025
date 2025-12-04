using Models;
using Data;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;




namespace Services
{

    public class ApprovisionnementService : IApprovisionnementService
    {
        private readonly GesApproDbContext _context;

        private readonly ILogger<ApprovisionnementService> _logger;

        public ApprovisionnementService(GesApproDbContext context, ILogger<ApprovisionnementService> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IEnumerable<Approvisionnement> GetAllApprovisionnements()
        {
            try
            {
                var list = _context.Approvisionnements
           .Include(a => a.Fournisseur)
           .Include(a => a.ApproArticles)
           .ThenInclude(aa => aa.Article)
           .ToList();
                _logger.LogInformation($"Récupération réussie : {list.Count} approvisionnements trouvés.");
                return list;
            }
            catch (Exception)
            {
                _logger.LogError("Erreur lors de la récupération des approvisionnements.000");
                throw;
            }
        }



    }

}