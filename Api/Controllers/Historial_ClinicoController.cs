using API_Tareadef.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_Tareadef.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Historial_ClinicoController : ControllerBase
    {
        [HttpPost("agregar_en_historial")]
        public async Task<ActionResult<JSON_object>> agregar_dato_Historial(Historial_Clinico nuevo_dato)
        {
            JSON_object jSON = new JSON_object("okay", nuevo_dato);
            return Ok(jSON);
        }
        [HttpDelete("eliminar_en_historial")]
        public async Task<ActionResult<JSON_object>> eliminar_dato_Historial(Historial_Clinico dato_eliminado)
        {
            JSON_object jSON = new JSON_object("okay", dato_eliminado);
            return Ok(jSON);
        }
        [HttpPut("modificar_historial")]
        public async Task<ActionResult<JSON_object>> modificar_Historial(Historial_Clinico dato_modificado)
        {
            JSON_object jSON = new JSON_object("okay", dato_modificado);
            return Ok(jSON);
        }
        [HttpGet("mostrar_historial")]
        public async Task<ActionResult<JSON_object>> mostrar_Historial(Historial_Clinico historial_mostrado)
        {
            JSON_object jSON = new JSON_object("okay", historial_mostrado);
            return Ok(jSON);
        }
    }
        
}
