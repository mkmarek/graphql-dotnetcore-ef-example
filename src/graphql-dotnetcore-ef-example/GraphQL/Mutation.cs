namespace GraphQLCMS.GraphQL
{
    using Database.Entities;
    using GraphQLCore.Type;
    using Service;
    using Service.Commands;
    using Service.Queries;

    public class Mutation : GraphQLObjectType
    {
        private CommandService commandService;
        private AuthorQueries authorQueries;

        public Mutation(
            CMSGraphQLSchema schema,
            CommandService commandService,
            AuthorQueries authorQueries)
            : base("Mutation", "The root mutation type")
        {
            this.authorQueries = authorQueries;
            this.commandService = commandService;

            schema.AddKnownType(this);
            schema.Mutation(this);

            this.AddFields();
        }

        private void AddFields()
        {
            this.Field("createAuthor",
                (CreateAuthorCommand author) => this.CreateAndReturnAuthor(author));
        }

        private AuthorViewModel CreateAndReturnAuthor(CreateAuthorCommand author)
        {
            var result = this.commandService.PerformCommand(author);

            return authorQueries.GetById(result.GetEntityIdentifier());
        }
    }
}
