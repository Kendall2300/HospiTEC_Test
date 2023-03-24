using API_Tareadef.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_Tareadef.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReservacionController : ControllerBase
    {
        [HttpPost("agregar_reservacion")]
        public async Task<ActionResult<JSON_object>> agregar_Reservacion(Reservacion nueva_reservacion)
        {
            JSON_object jSON = new JSON_object("okay", nueva_reservacion);
            return Ok(jSON);
        }
        [HttpDelete("eliminar_reservacion")]
        public async Task<ActionResult<JSON_object>> eliminar_Reservacion(Reservacion reservacion_eliminada)
        {
            JSON_object jSON = new JSON_object("okay", reservacion_eliminada);
            return Ok(jSON);
        }
        [HttpPut("modificar_reservacion")]
        public async Task<ActionResult<JSON_object>> modificar_Reservacion(Reservacion modificada_reservacion)
        {
            JSON_object jSON = new JSON_object("okay", modificada_reservacion);
            return Ok(jSON);
        }
        [HttpGet("mostrar_reservacion")]
        public async Task<ActionResult<JSON_object>> mostrar_Reservacion(Reservacion reservacion_mostrada)
        {
            JSON_object jSON = new JSON_object("okay", reservacion_mostrada);
            return Ok(jSON);
        }
    }
}
