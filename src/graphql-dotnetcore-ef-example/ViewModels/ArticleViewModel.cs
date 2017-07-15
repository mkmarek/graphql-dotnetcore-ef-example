namespace GraphQLCMS.Database.Entities
{
    using GraphQLCore.Type.Scalar;

    public class ArticleViewModel
    {
        public ID Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
