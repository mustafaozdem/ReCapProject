﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        IDataResult<List<Brand>> GetCarsByBrandId(int id);
        IResult Add(Brand brand);
        IDataResult<List<Brand>> GetAll();

    }
}
