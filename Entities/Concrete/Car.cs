﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Car : IEntity
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public string ColorId { get; set; }
        public int ModelYear { get; set; }
        public string DailyPrice { get; set; }
        public string Description { get; set; }
    }
}
