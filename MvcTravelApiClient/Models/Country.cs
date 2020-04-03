using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;

namespace MvcTravelApiCall.Models
{
  public class Country
  {
    public int CountryId {get; set;}
    public string CountryName {get; set;}
    // public virtual ICollection<City> Cities{get; set;}
    // public virtual ICollection<Review> Reviews {get; set;}
    public Country()
    {
      // this.Cities = new HashSet<City>();
      // this.Reviews = new HashSet<Review>();
    }

    public static List<Country> GetCountries()
    {
      var apiCallTask = ApiHelper.GetAll("countries");
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Country> countryList = JsonConvert.DeserializeObject<List<Country>>(jsonResponse.ToString());
      return countryList;
    }
  }
}