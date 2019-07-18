using AutoMapper;
using Lab.Application.ViewModels;
using Lab.Domain.DTO;
using Lab.Domain.Entities;

namespace Lab.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<TabelaINSS, TabelaINSSViewModel>();
            CreateMap<ReturnValues, ReturnValuesViewModel>();
        }
    }
}