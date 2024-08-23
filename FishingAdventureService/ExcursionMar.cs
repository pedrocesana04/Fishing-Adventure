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
        public override string ObtenerDescripcion(Embarcacion barco)
        {
            return base.ObtenerDescripcion(barco) + $" - Tipo de excursión: [Excursión en el mar] - Tamaño del barco [{TamañoBarco}]";
        }
    }

}
