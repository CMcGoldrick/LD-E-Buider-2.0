using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lethal.Developer.Helpers.HttpResponseMessages
{
    public class PostResponse
    {
        public string Message { get; set; }
    }

    public class Post
    {
        public static PostResponse Success(string input)
        {
            var response = new PostResponse();

            response.Message = $"succesfully created {input}";

            return response;
        }
    }
}
