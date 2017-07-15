namespace GraphQLCMS.Service.CommandHandlers.Core
{
    using Commands.Core;

    public abstract class CommandHandler<TCommand> where TCommand : Command
    {
        public abstract CommandResult Handle(TCommand command);
    }
}
