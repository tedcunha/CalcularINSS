using System;
using System.Collections.Generic;
using Lab.Application.ViewModels;

namespace Lab.Application.Interfaces
{
    public interface ITabelaINSSApplicationService : IDisposable
    {
         TabelaINSSViewModel GetTableById(Guid id);
         void UpdateTable(TabelaINSSViewModel tabelaINSS);
         void AddTable(TabelaINSSViewModel tabelaINSS);
         void RemoveTable(Guid id);
         IEnumerable<TabelaINSSViewModel> GetTabelaINSS();
         ReturnValuesViewModel CalculateDiscount(DateTime currentYear, decimal salary);
    }
}