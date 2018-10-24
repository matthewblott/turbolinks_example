using Microsoft.AspNetCore.Mvc;

namespace turbolinks_example
{
  public class HomeController : Controller
  {
    public IActionResult Index() => View();

    public IActionResult About() => View();

  }

}
