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

        public override string ObtenerDescripcion(Embarcacion barco)
        {
            if (IncluyeGuia)
            {
                return base.ObtenerDescripcion(barco) + $" - Tipo de excursión: [Excursión en el lago.] - Tipo de embarcación: {barco.TipoEmbarcacion} - Especie objetivo: [{EspecieObjetivo}] - Incluye guía de pesca : Sí";
            }
            else
            {
                return base.ObtenerDescripcion(barco) + $" - Tipo de excursión: [Excursión en el lago.] - Tipo de embarcación: {barco.TipoEmbarcacion} - Especie objetivo: [{EspecieObjetivo}] - Incluye guía de pesca : No";
            }
        }
    }
}
