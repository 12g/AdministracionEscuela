using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Negocio
{
    public class Usuario
    {
        private int _id;
        private string _nombre;
        private string _clave;
        private int _rol;

        public Usuario() { }

        public Usuario(int id, string nombre, string clave, int rol)
        {
            Id = id;
            Nombre = nombre;
            Clave = clave;
            Rol = rol;
        }

        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Clave { get => _clave; set => _clave = value; }
        public int Rol { get => _rol; set => _rol = value; }
    }
}
