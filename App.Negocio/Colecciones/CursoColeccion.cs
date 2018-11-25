using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Datos;

namespace App.Negocio.Colecciones
{
    public class CursoColeccion
    {
        private List<Curso> GenerarListadoNegocio(List<Datos.Cursos> listaEntrada)
        {
            List<Curso> lista = new List<Curso>();

            foreach (Datos.Cursos item in listaEntrada)
            {

                Curso nueva = new Curso()
                {
                    Id = item.id,
                    Codigo = item.codigo,
                    Generacion = item.generacion
                };

                lista.Add(nueva);
            }
            return lista;
        }

        public List<Curso> ListarTodos()
        {
            var lista = CommonBC.Modelo.Cursos; //listado dalc
            return GenerarListadoNegocio(lista.ToList());
        }
    }
}
