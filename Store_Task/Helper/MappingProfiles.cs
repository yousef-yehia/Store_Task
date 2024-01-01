using AutoMapper;
using Store_Task.Models;
using Store_Task.Models.Dto;



namespace Store_Task.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<CreateProductDto, Product>().ReverseMap();
            CreateMap<UpdateProductDto, Product>().ReverseMap();
            CreateMap<Product, ProductDto>().ForMember(dest => dest.CategorId, opt => opt.MapFrom(src => src.CategoryId)).ReverseMap();

            CreateMap<CreateCategoryDto, Category>().ReverseMap();
            CreateMap<CategoryDto, Category>().ReverseMap();

        }
    }
}
