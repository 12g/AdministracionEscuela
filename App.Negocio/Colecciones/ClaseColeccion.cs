using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Datos;

namespace App.Negocio.Colecciones
{
    public class ClaseColeccion
    {
        private List<Clase> GenerarListadoNegocio(List<Datos.Clases> listaEntrada)
        {
            List<Clase> lista = new List<Clase>();

            foreach (Datos.Clases item in listaEntrada)
            {

                Clase nueva = new Clase()
                {
                    Id = item.id,
                    Asignatura = item.asignatura,
                    Curso = item.curso,
                    Fecha = item.fecha,
                    Profesor = item.profesor
                };

                lista.Add(nueva);
            }
            return lista;
        }

        public List<Clase> ListarTodos()
        {
            var lista = CommonBC.Modelo.Clases; //listado dalc
            return GenerarListadoNegocio(lista.ToList());
        }
    }
}
