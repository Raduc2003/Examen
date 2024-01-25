using AutoMapper;
using ReactApp1.Server.DTOs;
using ReactApp1.Server.Entities;

namespace reactapp1.Server.Profiles

{
    public class Profile1:Profile
    {
        public Profile1()
        {
            CreateMap<User, UserDTO>();
            CreateMap<UserDTO,User>();
            CreateMap<Order, OrderDTO>();
            CreateMap<OrderDTO, Order>();
            CreateMap<ProductInOrder, ProductInOrderDTO>();
            CreateMap<ProductInOrderDTO, ProductInOrder>();
            CreateMap<Product, ProductDTO>();
            CreateMap<ProductDTO, Product>();
            
        }
    }
}
