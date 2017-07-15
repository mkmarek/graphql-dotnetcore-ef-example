using GraphQLCMS.Database.Entities;
using GraphQLCore.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLCMS.GraphQL.ObjectTypes
{
    public class CategorySchemaType : GraphQLObjectType<ArticleViewModel>
    {
        public CategorySchemaType() : base("Category", "Represents a category which groups articles together")
        {
            this.Field("title", e => e.Title);
            this.Field("content", e => e.Content);
        }
    }
}
