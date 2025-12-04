using Models;
using System;
using System.Collections.Generic;

namespace Services
{

    public interface IApprovisionnementService
    {
        IEnumerable<Approvisionnement> GetAllApprovisionnements();


    }

}
