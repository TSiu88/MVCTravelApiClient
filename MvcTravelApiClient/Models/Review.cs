using System;
using System.ComponentModel.DataAnnotations;

namespace MvcTravelApiCall.Models
{
  public class Review
  {
    public int ReviewId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public double Rating { get; set; }
    public DateTime Date { get; set; }
    public string UserName { get; set; }
    public int CityId {get; set;}
    public virtual City City {get; set;}

    public static List<Review> GetReviews()
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Review> reviewList = JsonConvert.DeserializeObject<List<Review>>(jsonResponse.ToString());
      return reviewList;
    }
  }
}