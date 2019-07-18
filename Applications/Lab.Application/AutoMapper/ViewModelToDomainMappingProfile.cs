using AutoMapper;
using Lab.Application.ViewModels;
using Lab.Domain.DTO;
using Lab.Domain.Entities;

namespace Lab.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<TabelaINSSViewModel, TabelaINSS>();
            CreateMap<ReturnValuesViewModel, ReturnValues>();
        }
    }
}