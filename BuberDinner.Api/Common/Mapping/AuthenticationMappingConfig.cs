using BuberDinner.Application.Authentication.Commands.Register;
using BuberDinner.Application.Authentication.Common;
using BuberDinner.Application.Authentication.Queries.Login;
using BuberDinner.Contracts.Authentication;

using Mapster;

namespace BuberDinner.Api.Common.Mapping;

public class AuthenticationMappingConfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        //var config = TypeAdapterConfig.GlobalSettings;

        //config
        //    .NewConfig<AuthenticationResult, AuthenticationResponse>();

        //config
        //    .ForType<AuthenticationResult, AuthenticationResponse>()
        //    .Map(dest => dest, src => src.User);

        //var config = TypeAdapterConfig<AuthenticationResult, AuthenticationResponse>.NewConfig();

        //config
        //    .BeforeMapping(dest => { })
        //    .Map(dest => dest, src => src.User)
        //    .AfterMapping(dest => { });

        config.NewConfig<LoginRequest, LoginQuery>();
        config.NewConfig<RegisterRequest, RegisterCommand>();

        config.NewConfig<AuthenticationResult, AuthenticationResponse>()
            .Map(dest => dest, src => src.User);
    }
}
