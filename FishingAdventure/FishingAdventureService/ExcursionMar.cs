using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingAdventureService
{
    public class ExcursionMar : Excursion
    {
        public int TamañoBarco { get; set; }
        public int ProfundidadPesca { get; set; }
        public bool Catering {  get; set; }
    }
}
