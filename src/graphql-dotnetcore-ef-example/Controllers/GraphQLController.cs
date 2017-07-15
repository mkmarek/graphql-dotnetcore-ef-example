namespace GraphQLCMS.Controllers
{
    using System;
    using Microsoft.AspNetCore.Mvc;
    using GraphQLCore.Type;
    using GraphQLCMS.Models;
    using Newtonsoft.Json;
    using System.Dynamic;
    using GraphQL;

    [Route("api/[controller]")]
    public class GraphQLController : Controller
    {
        private CMSGraphQLSchema schema;

        public GraphQLController(CMSGraphQLSchema schema, GraphQLSchemaInitializer initializer)
        {
            this.schema = schema;

            initializer.Initialize();
        }

        [HttpPost]
        public JsonResult Post([FromBody] GraphQLInput input)
        {
            return this.Json(this.schema.Execute(input.Query, GetVariables(input), input.OperationName));
        }

        private static dynamic GetVariables(GraphQLInput input)
        {
            var variables = input.Variables?.ToString();

            if (string.IsNullOrEmpty(variables))
                return new ExpandoObject();

            return JsonConvert.DeserializeObject<ExpandoObject>(variables);
        }
    }
}
