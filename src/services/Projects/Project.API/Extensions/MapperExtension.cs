using AutoMapper;
using Project.API.Profiles;

namespace Project.API.Extensions;

public static class MapperExtension
{
    public static IServiceCollection AddMapper(this IServiceCollection services)
    {
        var profiles = new MapperConfiguration(
            _ => { _.AddProfile(new ProjectProfile()); }
        );


        services.AddSingleton(profiles.CreateMapper());
        return services;
    }
}
