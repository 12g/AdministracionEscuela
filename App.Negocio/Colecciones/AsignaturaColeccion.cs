using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Datos;

namespace App.Negocio.Colecciones
{
    public class AsignaturaColeccion
    {
        private List<Asignatura> GenerarListadoNegocio(List<Datos.Asignaturas> listaEntrada)
        {
            List<Asignatura> lista = new List<Asignatura>();

            foreach (Datos.Asignaturas item in listaEntrada)
            {

                Asignatura nueva = new Asignatura()
                {
                    Id = item.id,
                    Nombre = item.nombre
                };

                lista.Add(nueva);
            }
            return lista;
        }

        public List<Asignatura> ListarTodos()
        {
            var lista = CommonBC.Modelo.Asignaturas; //listado dalc
            return GenerarListadoNegocio(lista.ToList());
        }
    }
}
