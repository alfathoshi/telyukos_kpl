﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telyukos
{
    public class User
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public List<Kos>? Kos { get; set; }
    }

}