using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.App_Start
{
  public class MappingProfile : Profile
  {
    public MappingProfile()
    {
      var config = new MapperConfiguration(cfg =>
      {
        cfg.CreateMap<Customer, CustomerDto>();
      });
      var configDto = new MapperConfiguration(cfg =>
      {
        cfg.CreateMap<CustomerDto, Customer>();
      });
      var configMT = new MapperConfiguration(cfg =>
      {
        cfg.CreateMap<MembershipType, MembershipTypeDto>();
      });
      var configMTDto = new MapperConfiguration(cfg =>
      {
        cfg.CreateMap<MembershipTypeDto, MembershipType>();
      });
      var genre = new MapperConfiguration(cfg =>
        {
          cfg.CreateMap<Genre, GenreDto>();
        }
      );
      var GenreDto = new MapperConfiguration(cfg =>
        {
          cfg.CreateMap<GenreDto, Genre>();
        }
      );
      var movieConfig = new MapperConfiguration(cfg =>
        {
          cfg.CreateMap<Movie, MovieDto>();
        }
      );
      var movieConfigDto = new MapperConfiguration(cfg =>
        {
          cfg.CreateMap<MovieDto, Movie>();
        }
      );
    }
  }
}