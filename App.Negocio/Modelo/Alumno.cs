using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Negocio
{
    public class Alumno
    {
        private int _id;
        private string _rut;
        private string _nombres;
        private string _apellidos;
        private string _sexo;
        private int _cursoAlumnoID;
        private List<Int32> _asistencias;
        private List<Int32> _notas;

        public Alumno()
        {

        }

        public int Id { get => _id; set => _id = value; }
        public string Rut { get => _rut; set => _rut = value; }
        public string Nombres { get => _nombres; set => _nombres = value; }
        public string Apellidos { get => _apellidos; set => _apellidos = value; }
        public string Sexo { get => _sexo; set => _sexo = value; }
        public int Curso { get => _cursoAlumnoID; set => _cursoAlumnoID = value; }
        public List<Int32> Asistencias { get => _asistencias; set => _asistencias = value; }
        public List<Int32> Notas { get => _notas; set => _notas = value; }
    }
}
