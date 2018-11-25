using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Datos;

namespace App.Negocio
{
    public class CommonBC
    {
        private static EscuelaEntities _modelo;

        public static EscuelaEntities Modelo
        {
            get
            {
                if (_modelo == null)
                {
                    _modelo = new EscuelaEntities();
                }
                return _modelo;
            }
        }
    }
}
