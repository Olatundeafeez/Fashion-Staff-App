﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionStaff.Domain.Model
{
    public class Staff
    {

        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty!;
       
        public int Age { get; set; } 

    }
}
