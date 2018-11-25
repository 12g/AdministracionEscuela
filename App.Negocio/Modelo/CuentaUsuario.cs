using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Negocio
{
    public class CuentaUsuario
    {
        private int _id;
        private string _nombre;
        private string _clave;
        private int _rol;
        private int _encargadoUsuarioID;

        public CuentaUsuario()
        {

        }

        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Clave { get => _clave; set => _clave = value; }
        public int Rol { get => _rol; set => _rol = value; }
        public int Encargado { get => _encargadoUsuarioID; set => _encargadoUsuarioID = value; }

        public bool Crear()
        {


            try
            {
                Datos.CuentasUsuario nueva = new Datos.CuentasUsuario
                {
                    usuario = this.Nombre,
                    clave = this.Clave,
                    encargado = this.Encargado
                };

                CommonBC.Modelo.CuentasUsuario.Add(nueva);
                CommonBC.Modelo.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Borrar()
        {
            try
            {
                //Obtiene un objeto del modelo, donde se cumpla la condición (el rut debe coincidir)
                var consulta = CommonBC.Modelo.CuentasUsuario.First(
                    aux => aux.usuario == this.Nombre
                );

                CommonBC.Modelo.CuentasUsuario.Remove(consulta);
                CommonBC.Modelo.SaveChanges();


                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Actualizar()
        {
            try
            {
                //Obtiene un objeto del modelo, donde se cumpla la condición (el rut debe coincidir)
                var consulta = CommonBC.Modelo.CuentasUsuario.First(
                    aux => aux.id == this.Id
                );

                consulta.usuario = this.Nombre;
                consulta.encargado = this.Encargado;

                CommonBC.Modelo.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool SeleccionarUno()
        {
            try
            {
                var consulta = CommonBC.Modelo.CuentasUsuario.First(
                    aux => aux.usuario == this.Nombre
                );

                Datos.Encargados enc = consulta.Encargados;
                this.Nombre = consulta.usuario;
                this.Encargado = consulta.encargado;

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
