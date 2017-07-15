using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLCMS.Models
{
    public class GraphQLInput
    {
        public string OperationName { get; set; }
        public string Query { get; set; }
        public dynamic Variables { get; set; }
    }
}
