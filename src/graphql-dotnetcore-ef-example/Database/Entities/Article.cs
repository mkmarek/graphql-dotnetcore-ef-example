using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLCMS.Database.Entities
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public Author Author { get; set; }
        public ICollection<ArticleTag> Tags { get; set; }
        public ICollection<Category> Categories { get; set; }
    }
}
