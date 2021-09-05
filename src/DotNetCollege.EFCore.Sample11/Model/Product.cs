﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace DotNetCollege.EFCore.Sample11.Model
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Category Category { get; set; }
    }

}
