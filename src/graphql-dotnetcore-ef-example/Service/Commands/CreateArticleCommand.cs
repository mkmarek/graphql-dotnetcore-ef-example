namespace GraphQLCMS.Service.Commands
{
    using Core;
    using GraphQLCore.Type.Scalar;

    public class CreateArticleCommand : Command
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public override bool IsValid()
        {
            return !string.IsNullOrWhiteSpace(this.Title) && !string.IsNullOrWhiteSpace(this.Content);
        }
    }
}
