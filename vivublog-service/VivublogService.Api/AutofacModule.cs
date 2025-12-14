using Autofac;
using VivublogService.Application.Interactors.User;
using VivublogService.Application.Interfaces.Boundaries.User;
using VivublogService.Application.Interfaces.Repositories;
using VivublogService.Application.Interfaces.Services;
using VivublogService.Application.Services;
using VivublogService.Infrastructure.Repositories;

namespace VivublogService.Api
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //User
            builder.RegisterType<GetUserDetail>().As<IGetUserDetail>().InstancePerLifetimeScope();
            builder.RegisterType<UserService>().As<IUserService>().InstancePerLifetimeScope();
            builder.RegisterType<UserRepository>().As<IUserRepository>().InstancePerLifetimeScope();
        }
    }
}
