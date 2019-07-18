using System;
using System.Collections.Generic;
using AutoMapper;
using Lab.Application.Interfaces;
using Lab.Application.ViewModels;
using Lab.Domain.Entities;
using Lab.Domain.Entities.Interfaces.Repositories;
using Lab.Domain.Entities.Interfaces.Services;

namespace Lab.Application.ApplicationServices
{
    public class TabelaINSSApplicationService : ITabelaINSSApplicationService
    {
        private readonly ITabelaINSSRepository _repository;
        private readonly ITabelaINSSService _service;
        private readonly IMapper _mapper;
        public TabelaINSSApplicationService(ITabelaINSSRepository repository, ITabelaINSSService service, IMapper mapper)
        {
            _repository = repository;
            _service = service;
            _mapper = mapper;
        }
        public void AddTable(TabelaINSSViewModel tabelaINSS)
        {
            var table = _mapper.Map<TabelaINSS>(tabelaINSS);
            _service.AddTable(table);
        }
        public void Dispose()
        {
            _service.Dispose();
            _repository.Dispose();
        }
        public IEnumerable<TabelaINSSViewModel> GetTabelaINSS()
        {
            return _mapper.Map<IEnumerable<TabelaINSSViewModel>>(_repository.GetAll());
        }
        public TabelaINSSViewModel GetTableById(Guid id)
        {
            return _mapper.Map<TabelaINSSViewModel>(_repository.GetById(id));
        }
        public void RemoveTable(Guid id)
        {
            _service.RemoveTable(id);
        }
        public void UpdateTable(TabelaINSSViewModel tabelaINSS)
        {
            var table = _mapper.Map<TabelaINSS>(tabelaINSS);
            _service.UpdateTable(table);
        }
        ReturnValuesViewModel ITabelaINSSApplicationService.CalculateDiscount(DateTime currentYear, decimal salary)
        {
            return _mapper.Map<ReturnValuesViewModel>(_service.CalcDiscount(currentYear, salary));
        }
    }
}