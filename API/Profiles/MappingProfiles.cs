using System.Security.Cryptography.X509Certificates;
using API.Dtos;
using AutoMapper;
using Domain.Entities;

namespace API.Profiles;

public class MappingProfiles : Profile
{

    public MappingProfiles()
    {
        CreateMap<Orden, OrdenRegDto>().ReverseMap();
        CreateMap<Orden, OrdenSimpleDto>().ReverseMap();
        CreateMap<Orden, OrdenDto>().ReverseMap();
    }

}