using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingAdventureService
{
    public abstract class Excursion
    {
        public string Nombre { get; set; }
        public string Ubicacion { get; set; }
        public int Duarcion { get; set; }
        public int Precio { get; set; }
        public int CodigoBarco {  get; set; }
        public virtual string ObtenerDescripcion(Embarcacion barco)
        {
            return $"Ubicacion: [{Ubicacion}]";
        }
    }
}
