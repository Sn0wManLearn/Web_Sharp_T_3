using AutoMapper;
using Web_Sharp_T_3.Contracts.Requests.Categories;
using Web_Sharp_T_3.Contracts.Requests.Products;
using Web_Sharp_T_3.Contracts.Requests.Store;
using Web_Sharp_T_3.Contracts.Responses;
using Web_Sharp_T_3.Models;

namespace Web_Sharp_T_3.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductResponse>(MemberList.Destination).ReverseMap();

            CreateMap<Product, ProductCreateRequest>(MemberList.Destination).ReverseMap();

            CreateMap<Product, ProductDeleteRequest>(MemberList.Destination).ReverseMap();

            CreateMap<Product, ProductUpdateRequest>(MemberList.Destination).ReverseMap();

            CreateMap<Category, CategoryCreateRequest>(MemberList.Destination).ReverseMap();

            CreateMap<Category, CategoryResponse>(MemberList.Destination).ReverseMap();

            CreateMap<Store, StoreCreateRequest>(MemberList.Destination).ReverseMap();

            CreateMap<Store, StoreResponse>(MemberList.Destination).ReverseMap();
        }
    }
}
