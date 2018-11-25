using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Negocio
{
    public class Clase
    {
        private int _id;
        private DateTime _fecha;
        private int _asignaturaClaseID;
        private int _cursoClaseID;
        private int _profesorClaseID;

        public Clase()
        {

        }

        public int Id { get => _id; set => _id = value; }
        public DateTime Fecha { get => _fecha; set => _fecha = value; }
        public int Asignatura { get => _asignaturaClaseID; set => _asignaturaClaseID = value; }
        public int Curso { get => _cursoClaseID; set => _cursoClaseID = value; }
        public int Profesor { get => _profesorClaseID; set => _profesorClaseID = value; }
    }
}
