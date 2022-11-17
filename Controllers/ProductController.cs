using Microsoft.AspNetCore.Mvc;

namespace demoapi.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    [HttpGet]
    public ActionResult<List<string>> GetProduct()
    {
        var products = new List<string>();
        products.Add("1");
        products.Add("1");
        products.Add("1");
        products.Add("1");
        return (products);

    }

}
