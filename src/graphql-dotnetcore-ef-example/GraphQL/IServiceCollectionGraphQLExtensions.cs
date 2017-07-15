namespace GraphQLCMS.Service.Queries
{
    using Database.Entities;
    using GraphQL;
    using GraphQL.InputObjectTypes;
    using GraphQL.ObjectTypes;
    using GraphQLCore.Type;
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using System.Collections.Generic;

    public static class IServiceCollectionGraphQLExtensions
    {
        private static Type AddGraphQLType<T>(this IServiceCollection services) where T : GraphQLBaseType
        {
            services.AddScoped<T>();

            return typeof(T);
        }

        public static void AddGraphQL(this IServiceCollection services)
        {
            var graphQLTypes = new List<Type>();

            //Add schema type
            services.AddScoped<CMSGraphQLSchema>();

            //Add root types
            graphQLTypes.Add(services.AddGraphQLType<Query>());
            graphQLTypes.Add(services.AddGraphQLType<Mutation>());

            //Add output object types
            graphQLTypes.Add(services.AddGraphQLType<AuthorSchemaType>());

            //Add input object types
            graphQLTypes.Add(services.AddGraphQLType<CreateAuthorInputType>());

            //Add list types - these types are dependent on basic data types so they have to go last
            graphQLTypes.Add(services.AddGraphQLType<PagedListSchemaType<AuthorViewModel>>());

            services.AddScoped((IServiceProvider serviceProvider) =>
                new GraphQLSchemaInitializer(serviceProvider, graphQLTypes));
        }
    }
}
