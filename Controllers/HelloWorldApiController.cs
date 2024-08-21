using Microsoft.AspNetCore.Mvc;
namespace HelloWorldWebApp.Controllers;
[ApiController]
[Route("api/[controller]")]
public class HelloWorldApiController : ControllerBase
{
    // GET: api/helloworldapi
    [HttpGet]
    public ActionResult<string> Get()
    {
        // Gera uma temperatura aleatória entre 20ºC e 40ºC
        Random random = new Random();
        double temperature = random.Next(200, 401) / 10.0;

        // Verifica se a temperatura ultrapassa os 35ºC
        if (temperature > 35.0)
        {
            return $"Alerta: Temperatura elevada! {temperature}ºC";
        }
        else
        {
            return $"Temperatura normal: {temperature}ºC";
        }
    }
}