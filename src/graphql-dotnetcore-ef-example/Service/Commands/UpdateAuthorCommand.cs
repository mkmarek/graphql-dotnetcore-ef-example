namespace GraphQLCMS.Service.Commands
{
    using Core;
    using GraphQLCore.Type.Scalar;

    public class UpdateAuthorCommand : Command
    {
        public ID Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public override bool IsValid()
        {
            return !string.IsNullOrWhiteSpace(this.Name) && !string.IsNullOrWhiteSpace(this.Surname);
        }
    }
}
