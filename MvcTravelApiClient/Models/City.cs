// using System;
// using System.Collections.Generic;
// using System.ComponentModel.DataAnnotations;
// using Newtonsoft.Json;
// using Newtonsoft.Json.Linq;
// using System.Linq;

// namespace MvcTravelApiCall.Models
// {
//   public class City
//   {
//     public int CityId {get; set;}
//     public string CityName {get; set;}
//     // public virtual ICollection<Review> Reviews{get; set;}
//     public double OverallRating {get; set;}
//     public int CountryId {get; set;}
//     //public virtual Country Country {get; set;}

//     public City()
//     {
//       //this.Reviews = new HashSet<Review>();
//     }

//     public static List<City> GetCities()
//     {
//       var apiCallTask = ApiHelper.GetAll("cities");
//       var result = apiCallTask.Result;

//       JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
//       //City cityList = JsonConvert.DeserializeObject<City>(jsonResponse.ToString());
//       List<City> cityList = JsonConvert.DeserializeObject<List<City>>(jsonResponse.ToString());
//       return cityList;
//     }
//   }
    
// }