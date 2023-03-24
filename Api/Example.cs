using Microsoft.AspNetCore.Mvc;

namespace API_Tareadef
{
    [ApiController]
    [Route("[controller]")]
    public class ExampleController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] ExampleRequest request)
        {
            if (request != null && !string.IsNullOrEmpty(request.Nombre))
            {
                var response = new ExampleResponse
                {
                    Mensaje = $"Hola, {request.Nombre}!"
                };
                return Ok(response);
            }
            else
            {
                return BadRequest();
            }
        }
    }

    public class ExampleRequest
    {
        public string Nombre { get; set; }
    }

    public class ExampleResponse
    {
        public string Mensaje { get; set; }
    }

}
