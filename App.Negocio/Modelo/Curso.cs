using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Negocio
{
    public class Curso
    {
        private int _id;
        private short _generacion;
        private string _codigo;
        private List<Int32> _alumnos;
        private List<Int32> _clases;

        public Curso()
        {

        }

        public int Id { get => _id; set => _id = value; }
        public short Generacion { get => _generacion; set => _generacion = value; }
        public string Codigo { get => _codigo; set => _codigo = value; }
        public List<Int32> Alumnos { get => _alumnos; set => _alumnos = value; }
        public List<Int32> Clases { get => _clases; set => _clases = value; }
    }
}
