﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.DataBaseFirst.DAL
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Prices { get; set; }

        public int? Stock { get; set; }
    }
}
