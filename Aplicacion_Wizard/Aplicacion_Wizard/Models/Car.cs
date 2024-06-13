using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacion_Wizard.Models
{
    public class Car
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int UserID { get; set; }
    }
}
