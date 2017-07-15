namespace GraphQLCMS.Service.CommandHandlers.Core
{
    using System;
    using GraphQLCore.Type.Scalar;

    public class CommandResult
    {
        public Func<ID> GetEntityIdentifier { get; set; }
    }
}