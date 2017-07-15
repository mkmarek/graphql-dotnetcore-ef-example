namespace GraphQLCMS.Service.Commands
{
    using Core;

    public class CreateCategoryCommand : Command
    {
        public string Name { get; set; }

        public override bool IsValid()
        {
            return !string.IsNullOrWhiteSpace(this.Name);
        }
    }
}
