using Microsoft.AspNetCore.Mvc;

namespace FindMyLocation.Controllers
{
    public class LocationController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }

        public IActionResult GetMyLocation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RedirectToGoogleMaps(double latitude, double longitude)
        {
            string googleMapsUrl = $"https://www.google.com/maps?q={latitude},{longitude}";
            return Redirect(googleMapsUrl);
        }
    }
}
