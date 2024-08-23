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
        public List<EquipoPesca> EquiposDePesca { get; set; }
        public Excursion()
        {
            EquiposDePesca = new List<EquipoPesca>();
        }

        public virtual string ObtenerDescripcion()
        {
            return $"Ubicacion: [{Ubicacion}]";
        }
    }
}
