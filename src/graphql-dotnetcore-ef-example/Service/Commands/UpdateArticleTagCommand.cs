namespace GraphQLCMS.Service.Commands
{
    using Core;
    using GraphQLCore.Type.Scalar;

    public class UpdateArticleTagCommand : Command
    {
        public ID Id { get; set; }
        public string Name { get; set; }

        public override bool IsValid()
        {
            return !string.IsNullOrWhiteSpace(this.Name);
        }
    }
}
