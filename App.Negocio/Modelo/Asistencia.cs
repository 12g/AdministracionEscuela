using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Negocio
{
    public class Asistencia
    {
        private int _id;
        private int _alumnoAsistenciaID;
        private int _claseAsistenciaID;
        private bool _huboPresencia;

        public Asistencia()
        {

        }

        public int Id { get => _id; set => _id = value; }
        public int Alumno { get => _alumnoAsistenciaID; set => _alumnoAsistenciaID = value; }
        public int Clase { get => _claseAsistenciaID; set => _claseAsistenciaID = value; }
        public bool Presencia { get => _huboPresencia; set => _huboPresencia = value; }
    }
}
