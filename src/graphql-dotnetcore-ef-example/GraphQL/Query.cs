namespace GraphQLCMS.GraphQL
{
    using GraphQLCore.Type;
    using Service.Queries;

    public class Query : GraphQLObjectType
    {
        public Query(
            CMSGraphQLSchema schema,
            AuthorQueries author 
        ) : base("Query", "The root query type")
        {
            schema.AddKnownType(this);
            schema.Query(this);

            this.Field("author", (int? pageIndex, int? pageSize) =>
                author.Get(pageIndex.Value, pageSize.Value))
            .WithDefaultValue("pageIndex", 0)
            .WithDefaultValue("pageSize", 20);
        }
    }
}
