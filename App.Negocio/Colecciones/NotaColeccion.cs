using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Datos;

namespace App.Negocio.Colecciones
{
    public class NotaColeccion
    {
        private List<Nota> GenerarListadoNegocio(List<Datos.Notas> listaEntrada)
        {
            List<Nota> lista = new List<Nota>();

            foreach (Datos.Notas item in listaEntrada)
            {

                Nota nueva = new Nota()
                {
                    Id = item.id,
                    Alumno = item.alumno,
                    Calificacion = item.calificacion,
                    Asignatura = item.asignatura,
                    Fecha = new DateTime( (long)item.fecha )
                };

                lista.Add(nueva);
            }
            return lista;
        }

        public List<Nota> ListarTodos()
        {
            var lista = CommonBC.Modelo.Notas; //listado dalc
            return GenerarListadoNegocio(lista.ToList());
        }
    }
}
