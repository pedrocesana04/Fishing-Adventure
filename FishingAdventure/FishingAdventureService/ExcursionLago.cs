using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingAdventureService
{
    public class ExcursionLago : Excursion
    {
        public EspeciesObjetivos EspecieObjetivo {  get; set; }
        public bool IncluyeGuia { get; set; }

        public override string ObtenerDescripcion()
        {
            return base.ObtenerDescripcion() + $" - Tipo de excursión: [Excursión en el lago.] - ";
        }
    }
}
