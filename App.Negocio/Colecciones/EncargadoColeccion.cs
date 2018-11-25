using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Datos;

namespace App.Negocio.Colecciones
{
    public class EncargadoColeccion
    {
        private List<Encargado> GenerarListadoNegocio(List<Datos.Encargados> listaEntrada)
        {
            List<Encargado> lista = new List<Encargado>();

            foreach (Datos.Encargados item in listaEntrada)
            {

                Encargado nueva = new Encargado()
                {
                    Id = item.id,
                    Rut = item.rut,
                    Nombres = item.nombres,
                    Apellidos = item.apellidos,
                    Sexo = item.sexo,
                    Tipo = item.tipo
                };

                lista.Add(nueva);
            }
            return lista;
        }

        public List<Encargado> ListarTodos()
        {
            var lista = CommonBC.Modelo.Encargados; //listado dalc
            return GenerarListadoNegocio(lista.ToList());
        }
    }
}
