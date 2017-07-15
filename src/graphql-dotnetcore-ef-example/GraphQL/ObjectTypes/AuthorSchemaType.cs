using GraphQLCMS.Database.Entities;
using GraphQLCore.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLCMS.GraphQL.ObjectTypes
{
    public class AuthorSchemaType : GraphQLObjectType<AuthorViewModel>
    {
        public AuthorSchemaType(CMSGraphQLSchema schema) : base("Author", "Represents an author that writes articles")
        {
            schema.AddKnownType(this);

            this.Field("id", e => e.Id);
            this.Field("name", e => e.Name);
            this.Field("surname", e => e.Surname);
        }
    }
}
