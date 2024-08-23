using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingAdventureService
{
    public class Embarcacion
    {
        public int Codigo {  get; set; }
        public string Nombre { get; set; }
        public TiposEmbarcaciones TipoEmbarcacion { get; set; }
        public string NombrePropietario { get; set; }
    }
}
