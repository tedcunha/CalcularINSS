using System;
using System.Linq;
using Lab.Data.Context;
using Lab.Domain.DTO;
using Lab.Domain.Entities;
using Lab.Domain.Entities.Interfaces.Repositories;

namespace Lab.Data.Repositories
{
    public class TabelaINSSRepository : Repository<TabelaINSS>, ITabelaINSSRepository
    {
        public TabelaINSSRepository(LabContext context) : base(context)
        {
        }

        public ReturnValues CalcDiscount(DateTime currentYear, decimal salary)
        {
            decimal percentageValue = 0m;
            decimal calcValue = 0m;
            decimal tetoDoze = 500.00m;
            decimal tetoOnze = 405.86m;

            if ((salary < tetoDoze && currentYear.Year == 2012))
            {
                var cl = Search(c => c.InitialValue >= salary && c.EndValues <= salary && c.Date.Year == currentYear.Year).FirstOrDefault();
                calcValue = ((Decimal)cl.DiscountPercentage / 100) * salary;
                if(calcValue >= tetoDoze)
                   calcValue = tetoDoze;
                percentageValue = calcValue;
            }
            if ((salary < tetoOnze && currentYear.Year == 2011))
            {
                decimal teto = tetoOnze;
                var cl = Search(c => c.InitialValue >= salary && c.EndValues <= salary && c.Date.Year == currentYear.Year).FirstOrDefault();
                calcValue = ((Decimal)cl.DiscountPercentage / 100) * salary;
                if(calcValue >= tetoOnze)
                   calcValue = tetoOnze;
                percentageValue = calcValue;
            }
            var returnValues = new ReturnValues{values = percentageValue};
            return returnValues;
        }
    }
}
