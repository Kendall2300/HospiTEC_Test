using API_Tareadef.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_Tareadef.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SalonController : ControllerBase
    {
        [HttpPost("agregar_salon")]
        public async Task<ActionResult<JSON_object>> agregar_Salon(Salon nuevo_salon)
        {
            JSON_object jSON = new JSON_object("okay", nuevo_salon);
            return Ok(jSON);
        }
        [HttpDelete("eliminar_salon")]
        public async Task<ActionResult<JSON_object>> eliminar_Salon(Salon salon_eliminado)
        {
            JSON_object jSON = new JSON_object("okay", salon_eliminado);
            return Ok(jSON);
        }
        [HttpPut("modificar_salon")]
        public async Task<ActionResult<JSON_object>> modificar_Salon(Salon salon_modificado)
        {
            JSON_object jSON = new JSON_object("okay", salon_modificado);
            return Ok(jSON);
        }
        [HttpGet("mostrar_salon")]
        public async Task<ActionResult<JSON_object>> mostrar_Salon(Salon salon_mostrado)
        {
            JSON_object jSON = new JSON_object("okay", salon_mostrado);
            return Ok(jSON);
        }
    }
}
