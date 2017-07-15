namespace GraphQLCMS.Service.Queries
{
    using Microsoft.Extensions.DependencyInjection;

    public static class IServiceCollectionQueryExtensions
    {
        public static void AddQueries(this IServiceCollection services)
        {
            services.AddScoped<AuthorQueries>();
        }
    }
}
