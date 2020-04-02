using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TravelApi.Models;
using Microsoft.EntityFrameworkCore;

namespace MvcTravelApiCall
{
  public class ReviewsController : ControllerBase
  {
    public IActionResult Index()
    {
      var allReviews = Review.GetAll();
      return View(allReviews);
    }
  }
}