﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacion_Wizard.Models
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
