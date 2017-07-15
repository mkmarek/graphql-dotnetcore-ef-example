using GraphQLCMS.Database.Entities;
using GraphQLCore.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLCMS.GraphQL.ObjectTypes
{
    public class ArticleTagSchemaType : GraphQLObjectType<ArticleViewModel>
    {
        public ArticleTagSchemaType() : base("Tag", "Represents a tag assignable to article")
        {
            this.Field("title", e => e.Title);
            this.Field("content", e => e.Content);
        }
    }
}
