using Microsoft.AspNetCore.Mvc;

namespace turbolinks_example
{
  public class EnquiryController : Controller
  {
    public IActionResult Index() => View();

    [HttpPost]
    public IActionResult Receive(Enquiry enquiry) => RedirectToAction(nameof(Received), enquiry);

    public IActionResult Received(Enquiry enquiry) => View(enquiry);

  }

}
