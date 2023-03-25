using API_Tareadef.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace API_Tareadef.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PacienteController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] Paciente request)
        {
            if (request != null && !string.IsNullOrEmpty(request.Nombre))
            {
                var response = new Response
                {
                    Mensaje = $"Hola, {request.Nombre}!"
                };
                string jsonString = JsonConvert.SerializeObject(request);
                string path = @".\\Recursos\\PacienteJson.json";
                using (var tw = new StreamWriter(path, true)) { tw.WriteLine(jsonString.ToString()); tw.Close(); }
                return Ok(response);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
