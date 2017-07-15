namespace GraphQLCMS.GraphQL.InputObjectTypes
{
    using GraphQLCMS.Service.Commands;
    using GraphQLCore.Type;

    public class CreateAuthorInputType : GraphQLInputObjectType<CreateAuthorCommand>
    {
        public CreateAuthorInputType(CMSGraphQLSchema schema)
            : base("CreateAuthor", "Model for creating and author")
        {
            schema.AddKnownType(this);

            this.Field("name", e => e.Name);
            this.Field("surname", e => e.Surname);
        }
    }
}
