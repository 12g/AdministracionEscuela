using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Negocio
{
    public class Nota
    {
        private int _id;
        private int _asignaturaNotaID;
        private int _alumnoNotaID;
        private DateTime _fecha;
        private decimal _calificacion;

        public Nota()
        {

        }

        public int Id { get => _id; set => _id = value; }
        public int Asignatura { get => _asignaturaNotaID; set => _asignaturaNotaID = value; }
        public int Alumno { get => _alumnoNotaID; set => _alumnoNotaID = value; }
        public DateTime Fecha { get => _fecha; set => _fecha = value; }
        public decimal Calificacion { get => _calificacion; set => _calificacion = value; }
    }
}
