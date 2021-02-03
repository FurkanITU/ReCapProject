﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Category:IEntity
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }
    }
}
