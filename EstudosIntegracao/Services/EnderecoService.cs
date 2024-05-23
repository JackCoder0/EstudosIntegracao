using AutoMapper;
using EstudosIntegracao.Dtos;
using EstudosIntegracao.Interfaces;
using EstudosIntegracao.Models;

namespace EstudosIntegracao.Services;

public class EnderecoService : IEnderecoService
{
    private readonly IMapper _mapper;
    private readonly IBrasilApi _brasilApi;

    public EnderecoService(IMapper mapper, IBrasilApi brasilApi)
    {
        _mapper = mapper;
        _brasilApi = brasilApi;
    }

    public async Task<ResponseGenerico<EnderecoResponse>> BuscarEndereco(string cep)
    {
        var endereco = await _brasilApi.BuscarEnderecoCep(cep);
        return _mapper.Map<ResponseGenerico<EnderecoResponse>>(endereco);
    }
}
