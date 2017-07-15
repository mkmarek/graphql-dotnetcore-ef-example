namespace GraphQLCMS.Database.Entities
{
    using GraphQLCore.Type.Scalar;

    public class AuthorViewModel
    {
        public ID Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
