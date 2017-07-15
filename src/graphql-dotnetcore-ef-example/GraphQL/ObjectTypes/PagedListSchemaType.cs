namespace GraphQLCMS.GraphQL.ObjectTypes
{
    using GraphQLCore.Type;
    using ViewModels;

    public class PagedListSchemaType<TViewModel>: GraphQLObjectType<PagedListViewModel<TViewModel>>
    {
        public PagedListSchemaType(CMSGraphQLSchema schema, AuthorSchemaType author)
            : base($"PagedListOf{schema.SchemaRepository.GetSchemaTypeFor(typeof(TViewModel)).Name}", "Paged list")
        {
            schema.AddKnownType(this);

            this.Field("hasNextPage", e => e.HasNextPage);
            this.Field("hasPreviousPage", e => e.HasPreviousPage);
            this.Field("indexFrom", e => e.IndexFrom);
            this.Field("items", e => e.Items);
            this.Field("pageIndex", e => e.PageIndex);
            this.Field("pageSize", e => e.PageSize);
            this.Field("totalCount", e => e.TotalCount);
            this.Field("totalPages", e => e.TotalPages);
        }
    }
}
