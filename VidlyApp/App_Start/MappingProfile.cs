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
            //maping from the source to the target
            Mapper.CreateMap<Customer, CustomersDto>();
            Mapper.CreateMap<CustomersDto, Customer>();
        }
    }
}