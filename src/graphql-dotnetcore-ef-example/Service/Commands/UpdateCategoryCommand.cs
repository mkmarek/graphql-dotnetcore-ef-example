namespace GraphQLCMS.Service.Commands
{
    using Core;
    using GraphQLCore.Type.Scalar;

    public class UpdateCategoryCommand : Command
    {
        public ID Id { get; set; }
        public string Name { get; set; }
        public ID ParentId { get; set; }

        public override bool IsValid()
        {
            return !string.IsNullOrWhiteSpace(this.Name);
        }
    }
}
