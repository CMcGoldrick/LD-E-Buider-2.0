using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lethal.Developer.Helpers.HttpResponseMessages
{
    public class DeleteResponse
    {
        public string Message { get; set; }
    }

    public class Delete
    {
        public static DeleteResponse Success(string input)
        {
            var response = new DeleteResponse();

            response.Message = $"succesfully deleted {input}";

            return response;
        }
    }
}
