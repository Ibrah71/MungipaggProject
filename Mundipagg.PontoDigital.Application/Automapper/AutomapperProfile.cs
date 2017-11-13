using AutoMapper;
using Mundipagg.PontoDigital.Application.ViewModel;
using Mundipagg.PontoDigital.Domain.Entities;

namespace Mundipagg.PontoDigital.Application.Automapper
{
  public  class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Funcionario, FuncionarioViewModel>();
            CreateMap<FuncionarioViewModel, Funcionario>();
        }
    }
}
