﻿using Models;
using System;
using System.Collections.Generic;

namespace BakerShopApp.Models
{
    public partial class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid? GroupId { get; set; }

        public virtual Group Group { get; set; }
    }
}
