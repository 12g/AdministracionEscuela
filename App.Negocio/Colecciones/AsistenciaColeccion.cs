using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Datos;

namespace App.Negocio.Colecciones
{
    public class AsistenciaColeccion
    {
        private List<Asistencia> GenerarListadoNegocio(List<Datos.Asistencias> listaEntrada)
        {
            List<Asistencia> lista = new List<Asistencia>();

            foreach (Datos.Asistencias item in listaEntrada)
            {

                Asistencia nueva = new Asistencia()
                {
                    Id = item.id,
                    Alumno = item.alumno,
                    Clase = item.clase,
                    Presencia = item.presencia
                };

                lista.Add(nueva);
            }
            return lista;
        }

        public List<Asistencia> ListarTodos()
        {
            var lista = CommonBC.Modelo.Asistencias; //listado dalc
            return GenerarListadoNegocio(lista.ToList());
        }
    }
}
