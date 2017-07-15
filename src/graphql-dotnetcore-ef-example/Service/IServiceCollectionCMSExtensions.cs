namespace GraphQLCMS.Service.Queries
{
    using CommandHandlers;
    using CommandHandlers.Core;
    using Commands;
    using Microsoft.Extensions.DependencyInjection;

    public static class IServiceCollectionCMSExtensions
    {
        public static void AddServiceLayer(this IServiceCollection services)
        {
            services.AddScoped<CommandService>();
            services.AddScoped<CommandHandler<CreateAuthorCommand>, CreateAuthorCommandHandler>();
        }
    }
}
