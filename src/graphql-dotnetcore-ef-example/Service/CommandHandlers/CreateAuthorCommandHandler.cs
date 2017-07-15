namespace GraphQLCMS.Service.CommandHandlers
{
    using Commands;
    using Core;
    using Microsoft.EntityFrameworkCore;
    using Database.Entities;
    using GraphQLCore.Type.Scalar;

    public class CreateAuthorCommandHandler : CommandHandler<CreateAuthorCommand>
    {
        private readonly IRepository<Author> authorRepository;

        public CreateAuthorCommandHandler(IUnitOfWork unitOfWork)
        {
            this.authorRepository = unitOfWork.GetRepository<Author>();
        }

        public override CommandResult Handle(CreateAuthorCommand command)
        {
            var author = new Author()
            {
                Name = command.Name,
                Surname = command.Surname
            };

            this.authorRepository.Insert(author);

            return new CommandResult()
            {
                GetEntityIdentifier = () => new ID(author.Id.ToString())
            };
        }
    }
}
