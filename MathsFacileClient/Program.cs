using RestSharp;
using System;

namespace MathsFacileClient
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Type a mathematic expression: (exit to stop)");

                var input = Console.ReadLine();

                if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                var client = new RestClient("http://mathsfacileapi20161107121521.azurewebsites.net");

                var request = new RestRequest("calcul/", Method.POST);

                request.AddJsonBody(input);

                // execute the request
                IRestResponse response = client.Execute(request);
                var content = response.Content; // raw content as string

                Console.WriteLine("= " + response.Content + "\n");
            }
        }
    }
}
