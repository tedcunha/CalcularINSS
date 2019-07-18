using System;
using Lab.Domain.DTO;
using Lab.Domain.Entities.Interfaces.Repositories;
using Lab.Domain.Entities.Interfaces.Services;

namespace Lab.Domain.Entities.Services
{
    public class TabelaINSSService : ITabelaINSSService
    {
        private readonly ITabelaINSSRepository _Repository;
        public TabelaINSSService(ITabelaINSSRepository Repository)
        {
            _Repository = Repository;
        }
        public void AddTable(TabelaINSS tabelaINSS)
        {
            _Repository.Add(tabelaINSS);
        }
        public TabelaINSS GetTableById(Guid id)
        {
            return _Repository.GetById(id);
        }
        public void RemoveTable(Guid id)
        {
            _Repository.Remove(id);
        }
        public void UpdateTable(TabelaINSS tabelaINSS)
        {
            _Repository.Update(tabelaINSS);
        }
        public void Dispose()
        {
            _Repository.Dispose();
        }
        public ReturnValues CalcDiscount(DateTime currentYear, decimal salary)
        {
            return _Repository.CalcDiscount(currentYear, salary);
        }
    }
}