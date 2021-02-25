﻿using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(p => p.CarName).MinimumLength(2);
            RuleFor(p => p.DailyPrice).GreaterThan(0);
        }
    }
}
