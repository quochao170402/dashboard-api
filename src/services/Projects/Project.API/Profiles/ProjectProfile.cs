using AutoMapper;
using Project.API.Controllers.Payload;
using Project.API.Models;

namespace Project.API.Profiles;

public class ProjectProfile : Profile
{
    public ProjectProfile()
    {
        CreateMap<Entities.Project, ProjectModel>();
        CreateMap<AddProjectRequest, Entities.Project>();
        CreateMap<UpdateProjectRequest, Entities.Project>();
    }
}
