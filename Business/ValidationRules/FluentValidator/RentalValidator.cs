﻿using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidator
{
    public class RentalValidator : AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(r => r.CarId).NotEmpty();
            //RuleFor(r => r.CustomerId).NotEmpty();
            RuleFor(r => r.RentDate).NotEmpty();
            RuleFor(r => r.ReturnDate).GreaterThanOrEqualTo(r => r.RentDate);
        }
    }
}
