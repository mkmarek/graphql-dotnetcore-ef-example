using System;
using System.Collections.Generic;

namespace GraphQLCMS.GraphQL
{
    public class GraphQLSchemaInitializer
    {
        private IEnumerable<Type> typesToInitialize;
        private IServiceProvider serviceProvider;

        public GraphQLSchemaInitializer(IServiceProvider serviceProvider, IEnumerable<Type> typesToInitialize)
        {
            this.serviceProvider = serviceProvider;
            this.typesToInitialize = typesToInitialize;
        }

        public void Initialize()
        {
            foreach (var type in this.typesToInitialize)
            {
                this.serviceProvider.GetService(type);
            }
        }
    }
}
