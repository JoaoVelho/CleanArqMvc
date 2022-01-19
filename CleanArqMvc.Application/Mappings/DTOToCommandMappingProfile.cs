using AutoMapper;
using CleanArqMvc.Application.DTOs;
using CleanArqMvc.Application.Products.Commands;

namespace CleanArqMvc.Application.Mappings
{
    public class DTOToCommandMappingProfile : Profile
    {
        public DTOToCommandMappingProfile()
        {
            CreateMap<ProductDTO, ProductCreateCommand>();
            CreateMap<ProductDTO, ProductUpdateCommand>();
        }
    }
}
