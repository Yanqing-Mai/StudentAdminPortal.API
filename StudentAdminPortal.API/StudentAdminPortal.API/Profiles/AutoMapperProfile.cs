using AutoMapper;
using DataModel = StudentAdminPortal.API.DataModels;
using StudentAdminPortal.API.DomainModels;

namespace StudentAdminPortal.API.Profiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<DataModel.Student, Student>()
                .ReverseMap();

            CreateMap<DataModel.Gender, Gender>()
                .ReverseMap();

            CreateMap<DataModel.Address, Address>()
                .ReverseMap();
        }
    }
}
