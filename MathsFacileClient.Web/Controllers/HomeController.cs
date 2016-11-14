using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MathsFacileClient.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string Calcul(string formula)
        {
            var client = new RestClient("http://mathsfacileapi20161107121521.azurewebsites.net");

            var request = new RestRequest("calcul/", Method.POST);

            request.AddJsonBody(formula);

            // execute the request
            IRestResponse response = client.Execute(request);
            return response.Content; // raw content as string
        }
    }
}