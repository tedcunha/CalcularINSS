using System;
using FluentValidation;
using Lab.Domain.Core.Models;

namespace Lab.Domain.Entities
{
    public class TabelaINSS : Entity<TabelaINSS>
    {
        public TabelaINSS(DateTime date, decimal initialValue, decimal endValues, decimal discountPercentage)
        {
            Date = date;
            InitialValue = initialValue;
            EndValues = endValues;
            DiscountPercentage = discountPercentage;
        }
        protected TabelaINSS()
        {
        }
        public DateTime Date { get; private set; }
        public decimal InitialValue { get; private set; }
        public decimal EndValues { get; private set; }
        public decimal DiscountPercentage { get; private set; }
        public override bool IsValid()
        {
            Validate();
            return ValidationResult.IsValid;
        }
        private void Validate()
        {
            ValidateProperty();
            ValidationResult = Validate(this);
        }
        private void ValidateProperty()
        {
            RuleFor(x => x.Date)
            .NotNull()
            .WithMessage("A data deve ser informado");

            RuleFor(x => x.InitialValue)
            .NotNull()
            .WithMessage("Valor Inicial deve ser informado");

            RuleFor(x => x.EndValues)
            .NotNull()
            .WithMessage("Valor Final deve ser informado");

            RuleFor(x => x.DiscountPercentage)
            .NotNull()
            .WithMessage("Valor % deve ser informado");
        }
    }
}