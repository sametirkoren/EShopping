using AutoMapper;
using Catalog.Application.Commands;
using Catalog.Application.Responses;
using Catalog.Core.Entities;

namespace Catalog.Application.Mappers;

public class ProductMappingProfile : Profile
{
    public ProductMappingProfile()
    {
        CreateMap<ProductBrand, ProductResponse>().ReverseMap();
        CreateMap<ProductBrand, CreateProductCommand>().ReverseMap();
        CreateMap<ProductBrand, BrandResponse>().ReverseMap();
        CreateMap<ProductBrand, TypesResponse>().ReverseMap();
    }
}