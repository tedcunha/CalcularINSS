using System;
using Lab.Domain.DTO;
using Lab.Domain.Interfaces.Repositories;

namespace Lab.Domain.Entities.Interfaces.Repositories
{
    public interface ITabelaINSSRepository : IRepository<TabelaINSS>
    {
         ReturnValues CalcDiscount(DateTime currentYear, decimal salary);
    }
}