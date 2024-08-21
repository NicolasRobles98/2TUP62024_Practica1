using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
namespace Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Linq2Controller : Controller
    {
        public IActionResult Get(List<string> words) { 
            var listQuery = words.Where(x => x.Length >= 5).Select(x => x.ToUpper());
            var result = listQuery.ToList();
            return Ok(result);
        }
    }
}
