using AutoMapper;
using MovieRent.Dtos;
using MovieRent.Models;

namespace MovieRent.App_Start
{
    public class MappingProfile : Profile
    {
        /// <summary>
        ///  Add a constructor and use mapper that create mathematical to create a mapping configuration between two types
        ///  A generic method that takes two parameters source and target
        ///  Also want to be able to map a customer Dto to a customer when we call this create map method
        ///  automapper uses reflection to scan these types it finds their properties and maps them based on their name
        /// </summary>
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto > ();
            Mapper.CreateMap<CustomerDto, Customer > ();
        }
    }
}