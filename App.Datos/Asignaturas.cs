//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App.Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Asignaturas
    {
        public Asignaturas()
        {
            this.Clases = new HashSet<Clases>();
            this.Notas = new HashSet<Notas>();
        }
    
        public int id { get; set; }
        public string nombre { get; set; }
    
        public virtual ICollection<Clases> Clases { get; set; }
        public virtual ICollection<Notas> Notas { get; set; }
    }
}