using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLCMS.Database.Entities
{
    public class ArticleTag
    {
        public int Id { get; set; }
        public string TagName { get; set; }
        public ICollection<ArticleTag> Articles { get; set; }
    }
}
