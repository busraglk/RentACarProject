using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ColorValidator :AbstractValidator<Color>
    {
        public ColorValidator()
        {
            RuleFor(co => co.ColorName).NotEmpty().WithMessage("Renk adı boş geçilemez!");
            RuleFor(co => co.ColorName).MinimumLength(3);
        }
    }
}
