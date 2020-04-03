using System.Threading.Tasks;
using RestSharp;
using System.Collections.Generic;
using System;
using Newtonsoft.Json.Linq;

namespace MvcTravelApiCall.Models
{
  class ApiHelper
  {

    public static async Task<string> GetAll(string controller)
    {
      RestClient client = new RestClient("http://localhost:5000/api/");
      RestRequest request = new RestRequest($"{controller}",Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
  }
}