using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Agenda.Tablas
{
    public class T_Contacto
    {
        [PrimaryKey, AutoIncrement] 
        public int Id { get; set; }
        [MaxLength(100)]
        public string Nombre { get; set; }
        [MaxLength(100)]
        public string Apellido { get; set; }
        [MaxLength(100)]
        public string Telefono { get; set; }

    }
}
