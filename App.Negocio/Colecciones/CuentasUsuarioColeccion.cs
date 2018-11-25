using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Datos;

namespace App.Negocio.Colecciones
{
    public class CuentasUsuarioColeccion
    {
        private List<CuentaUsuario> GenerarListadoNegocio(List<Datos.CuentasUsuario> listaEntrada)
        {
            List<CuentaUsuario> lista = new List<CuentaUsuario>();

            foreach (Datos.CuentasUsuario item in listaEntrada)
            {
                
                CuentaUsuario nueva = new CuentaUsuario()
                {
                    Id = item.id,
                    Nombre = item.usuario,
                    Clave = item.clave,
                    Encargado = item.encargado
                };

                lista.Add(nueva);
            }
            return lista;
        }

        public List<CuentaUsuario> ListarTodos()
        {
            var lista = CommonBC.Modelo.CuentasUsuario; //listado dalc
            return GenerarListadoNegocio(lista.ToList());
        }
    }
}
