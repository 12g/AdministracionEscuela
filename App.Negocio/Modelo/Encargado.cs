using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Negocio
{
    public class Encargado
    {
        private int _id;
        private string _rut;
        private string _nombres;
        private string _apellidos;
        private string _sexo;
        private string _tipo;

        public Encargado()
        {

        }

        public int Id { get => _id; set => _id = value; }
        public string Rut { get => _rut; set => _rut = value; }
        public string Nombres { get => _nombres; set => _nombres = value; }
        public string Apellidos { get => _apellidos; set => _apellidos = value; }
        public string Sexo { get => _sexo; set => _sexo = value; }
        public string Tipo { get => _tipo; set => _tipo = value; }
    }
}
