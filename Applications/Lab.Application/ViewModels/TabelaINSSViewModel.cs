using System;

namespace Lab.Application.ViewModels
{
    public class TabelaINSSViewModel
    {
        public TabelaINSSViewModel()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public decimal InitialValue { get; set; }
        public decimal EndValues { get; set; }
        public decimal DiscountPercentage { get; set; }
    }
}