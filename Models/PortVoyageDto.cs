using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FerryFinder.Models
{
    public class PortVoyageDto
    {
        public string LinijaTipOznaka { get; set; }
        public string LinijaTipNaziv  { get; set; }
        public string SmjerLinije { get; set; }
        public int RedniBroj { get; set; }
        public string LinijaOznaka { get; set; }
        public string LinijaNaziv { get; set; }
        public string PostajaNaziv { get; set; }
        public DateTime? UkrcajVrijeme { get; set; }
        public DateTime? PolazakVrijeme { get; set; }
        public DateTime? DolazakVrijeme { get; set; }
        public string IndSmjera { get; set; }
        public DateTime? RefDate { get; set; }
        public int IndOznake { get; set; }
        public string LukaPrije { get; set; }
        public string LukaNakon { get; set; }
        public string PrijevoznoSredstvoNaziv { get; set; }
        public string PrijevoznoSredstvoOznaka { get; set; }
        public string PrijevoznoSredstvoTipOznaka { get; set; }
        public string PrijevoznoSredstvoTipNaziv { get; set; }
        public string OtokNaziv { get; set; }
        public string PostajaOtokNaziv { get; set; }
    }
}
