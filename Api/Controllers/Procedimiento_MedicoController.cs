using API_Tareadef.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_Tareadef.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Procedimiento_MedicoController : ControllerBase
    {
        [HttpPost("agregar_procedimiento_medico")]
        public async Task<ActionResult<JSON_object>> agregar_Procedimiento_Medico(Procedimiento_Medico nuevo_procedimiento_medico)
        {
            JSON_object jSON = new JSON_object("okay", nuevo_procedimiento_medico);
            return Ok(jSON);
        }
        [HttpDelete("eliminar_procedimiento_medico")]
        public async Task<ActionResult<JSON_object>> eliminar_Procedimiento_Medico(Procedimiento_Medico eliminado_procedimiento_medico)
        {
            JSON_object jSON = new JSON_object("okay", eliminado_procedimiento_medico);
            return Ok(jSON);
        }
        [HttpPut("modificar_procedimiento_medico")]
        public async Task<ActionResult<JSON_object>> modificar_Procedimiento_Medico(Procedimiento_Medico modificado_procedimiento_medico)
        {
            JSON_object jSON = new JSON_object("okay", modificado_procedimiento_medico);
            return Ok(jSON);
        }
        [HttpGet("mostrar_procedimiento_medico")]
        public async Task<ActionResult<JSON_object>> mostrar_Procedimiento_Medico(Procedimiento_Medico mostrado_procedimiento_medico)
        {
            JSON_object jSON = new JSON_object("okay", mostrado_procedimiento_medico);
            return Ok(jSON);
        }
    }
}
