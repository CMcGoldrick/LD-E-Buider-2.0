using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lethal.Developer.Helpers.HttpResponseMessages
{
    public class PutResponse
    {
        public string Message { get; set; }
    }

    public class Put
    {
        public static PutResponse Success(string input)
        {
            var response = new PutResponse();

            response.Message = $"succesfully updated {input}";

            return response;
        }
    }
}
