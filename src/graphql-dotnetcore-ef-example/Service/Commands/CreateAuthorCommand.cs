namespace GraphQLCMS.Service.Commands
{
    using Core;

    public class CreateAuthorCommand : Command
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public override bool IsValid()
        {
            return !string.IsNullOrWhiteSpace(this.Name) && !string.IsNullOrWhiteSpace(this.Surname);
        }
    }
}
