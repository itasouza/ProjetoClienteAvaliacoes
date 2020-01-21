using AutoMapper;
using WebAvaliacoes.ViewModels;
using Generico.Business.Models;

namespace WebAvaliacoes.AutoMapper
{
    public class AutoMapperConfig : Profile
    {

        //configurando a relação do Model com o ViewModels
        public AutoMapperConfig()
        {
            CreateMap<Entity, EntityViewModel>().ReverseMap();
            CreateMap<Avaliacao, AvaliacaoViewModel>().ReverseMap();
            CreateMap<Cidade, CidadeViewModel>().ReverseMap();
            CreateMap<Cliente, ClienteViewModel>().ReverseMap();
            CreateMap<Estado, EstadoViewModel>().ReverseMap();
            CreateMap<Produto, ProdutoViewModel>().ReverseMap();

        }


    }
}
