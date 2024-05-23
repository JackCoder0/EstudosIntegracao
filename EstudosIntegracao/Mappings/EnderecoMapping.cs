using AutoMapper;
using EstudosIntegracao.Dtos;
using EstudosIntegracao.Models;

namespace EstudosIntegracao.Mappings;

public class EnderecoMapping : Profile
{
    public EnderecoMapping()
    {
        CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
        CreateMap<EnderecoResponse, EnderecoModel>();
        CreateMap<EnderecoModel, EnderecoResponse>();
    }
}
