using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Negocio.Colecciones
{
    public class AlumnoColeccion
    {
        private List<Alumno> GenerarListadoNegocio(List<Datos.Alumnos> listaEntrada)
        {
            List<Alumno> lista = new List<Alumno>();

            foreach (Datos.Alumnos item in listaEntrada)
            {

                Alumno nueva = new Alumno()
                {
                    Id = item.id,
                    Rut = item.rut,
                    Nombres = item.nombres,
                    Apellidos = item.apellidos
                };

                lista.Add(nueva);
            }
            return lista;
        }

        public List<Alumno> ListarTodos()
        {
            var lista = CommonBC.Modelo.Alumnos; //listado dalc
            return GenerarListadoNegocio(lista.ToList());
        }
    }
}
