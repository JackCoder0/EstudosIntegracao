using AutoMapper;
using EstudosIntegracao.Dtos;
using EstudosIntegracao.Models;

namespace EstudosIntegracao.Mappings;

public class BancoMapping : Profile
{
    public BancoMapping()
    {
        CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
        CreateMap<BancoResponse, BancoModel>();
        CreateMap<BancoModel, BancoResponse>();
    }
}
