using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FullentValidation
{
    public class CarValidator:AbstractValidator<Car>
    {

        public  CarValidator()
        {
            RuleFor(c=>c.DailyPrice).NotEmpty();

            RuleFor(c => c.Description).MinimumLength(2);

           // RuleFor(c => c.Description).Must(StartWithA).WithMessage("Ürünler A Harfi ile başlamalı");



        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
