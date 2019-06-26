using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyApp.Dtos;
using VidlyApp.Models;


namespace VidlyApp.App_Start
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            //maping from the source to the target for customers
            Mapper.CreateMap<Customer, CustomersDto>().ForMember(m=>m.Id, opt=>opt.Ignore());
            Mapper.CreateMap<CustomersDto, Customer>().ForMember(m => m.Id, opt => opt.Ignore());

            //mapping from the source to target for movies
            Mapper.CreateMap<Movie, MoviesDto>().ForMember(m=>m.Id, opt=>opt.Ignore());
            Mapper.CreateMap<MoviesDto, Movie>().ForMember(m=>m.Id, opt=>opt.Ignore());
        }
    }
}