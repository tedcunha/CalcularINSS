using System;
using Lab.Domain.DTO;

namespace Lab.Domain.Entities.Interfaces.Services
{
    public interface ITabelaINSSService : IDisposable
    {
         TabelaINSS GetTableById(Guid id);
         void UpdateTable(TabelaINSS tabelaINSS);
         void AddTable(TabelaINSS tabelaINSS);
         void RemoveTable(Guid id);
         ReturnValues CalcDiscount(DateTime currentYear, decimal salary);
    }
}