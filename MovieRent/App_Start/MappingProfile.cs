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
            // Domain to Dto
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<Movie, MovieDto>();
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();

            // Dto to Domain
            // Id is the key property for the Movie and Customer class, and a key property should not be changed.
            // To resolve this, Tell AutoMapper to ignore id during mapping of a MovieDto to Movie or CustomerDto to Customer.
            Mapper.CreateMap<CustomerDto, Customer>()
                .ForMember(c => c.Id, opt => opt.Ignore());
            Mapper.CreateMap<MovieDto, Movie>()
                .ForMember(m => m.Id, opt => opt.Ignore());
        }
    }
}