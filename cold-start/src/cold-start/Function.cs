using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using Amazon.Lambda.Core;
using Microsoft.Extensions.Logging;
using Thundra.Agent.Lambda.Config;
using Thundra.Agent.Lambda.Core;
using Thundra.Agent.Log.AspNetCore;
using System.Linq;
using Newtonsoft.Json.Linq;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace cold_start
{
    public class Function : LambdaRequestHandler<JObject, Hero>
    {

        /// <summary>
        /// Handler class needs to extend `LambdaRequestHandler< Request, Response >`
        /// Please write all code within the DoHandleRequest method
        /// </summary>
        /// <param name="request"></param>
        /// <param name="context"></param>
        /// <returns>/Greeting Message/</returns>
        public override Hero DoHandleRequest(JObject request, ILambdaContext context)
        {
            //Initializing Microsoft Logger with Thundra Logger Provider
            var loggerFactory = new LoggerFactory().AddThundraProvider();
            var logger = loggerFactory.CreateLogger<Function>();
            Services service = new Services();

            var field = (string)request.SelectToken("field");
            JObject payload = (JObject)request.SelectToken("payload");
            Hero res = service.CheckRequest(field, payload);

            string json = payload.ToString(Newtonsoft.Json.Formatting.None);

            logger.LogInformation("Operation being carried out: {0}", field);
            logger.LogInformation("Payload: {0}", json);
            return res;
        }
    }
}
