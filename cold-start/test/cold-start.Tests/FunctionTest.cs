using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Xunit;
using Amazon.Lambda.Core;
using Amazon.Lambda.TestUtilities;

using cold_start;

namespace cold_start.Tests
{
    public class FunctionTest
    {
        [Fact]
        public void TestToUpperFunction()
        {

            // Invoke the lambda function wrapped with Thundra and confirm the greeting was returned.
            var function = new Function();
            var context = new TestLambdaContext();
            var response = function.DoHandleRequest("Hello Thundra", context);

            Assert.Equal("Hello Thundra", response);
        }
    }
}
