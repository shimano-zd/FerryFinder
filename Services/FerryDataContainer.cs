
using FerryFinder.Models;
using System.Collections.Generic;
using System.Linq;

namespace FerryFinder.Services
{
    public class FerryDataContainer
    {
        public FerryDataContainer()
        {
            Ferries = Enumerable.Empty<FerryDto>();
        }
        public IEnumerable<FerryDto> Ferries { get; private set; }

        public void LoadFerries(IEnumerable<FerryDto> ferries)
        {
            Ferries = ferries;
        }
    }
}
