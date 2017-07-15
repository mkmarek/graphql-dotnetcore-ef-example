namespace GraphQLCMS.Service
{
    using CommandHandlers.Core;
    using Commands.Core;
    using System;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.EntityFrameworkCore;

    public class CommandService
    {
        private IServiceProvider serviceProvider;

        private IUnitOfWork unitOfWork;

        public CommandService(IServiceProvider serviceProvider, IUnitOfWork unitOfWork)
        {
            this.serviceProvider = serviceProvider;
            this.unitOfWork = unitOfWork;
        }

        public CommandResult PerformCommand<TCommand>(TCommand command) where TCommand: Command
        {
            if (command.IsValid())
            {
                var handler = this.serviceProvider.GetService<CommandHandler<TCommand>>();
                var result = handler.Handle(command);

                this.Commit();

                return result;
            }
            else
            {
                throw new InvalidOperationException("Invalid input");
            }
        }

        public void Commit()
        {
            this.unitOfWork.SaveChanges();
        }
    }
}
