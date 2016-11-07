using RestSharp;
using System;

namespace MathsFacileClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new RestClient("http://mathsfacileapi20161107121521.azurewebsites.net");

            var request = new RestRequest("calcul/", Method.POST);

            request.AddJsonBody("4+4*4/12");

            // execute the request
            IRestResponse response = client.Execute(request);
            var content = response.Content; // raw content as string

            Console.WriteLine(response.Content);

            Console.Read();
        }
    }
}
