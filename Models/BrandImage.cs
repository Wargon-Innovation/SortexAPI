﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SortexAPI.Models
{
    public class BrandImage
    {
        public int Id { get; set; }
        public string Image { get; set; }

        public int BrandId { get; set; }
        public Brand Brand { get; set; }

    }
}