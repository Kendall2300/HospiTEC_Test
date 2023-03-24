using API_Tareadef.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_Tareadef.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonalController : ControllerBase
    {
        [HttpPost("agregar_personal")]
        public async Task<ActionResult<JSON_object>> agregar_Personal(Personal nuevo_personal)
        {
            JSON_object jSON = new JSON_object("okay", nuevo_personal);
            //string jsonString = JsonConvert.SerializeObject(nuevo_paciente);
            //Console.WriteLine(jsonString);
            //string fileName = "PacienteJson.json";
            //string path = "C:\\Users\\maxga\\OneDrive\\Documentos\\Cursos CE\\Bases de Datos S1.2023\\API_Tareadef\\Recursos\\PacienteJson.json";
            //using (var tw = new StreamWriter(path, true)) { tw.WriteLine(jsonString.ToString()); tw.Close(); }

            return Ok(jSON);
        }
        [HttpDelete("eliminar_personal")]
        public async Task<ActionResult<JSON_object>> eliminar_Personal(Personal eliminado_personal)
        {
            JSON_object jSON = new JSON_object("okay", eliminado_personal);
            return Ok(jSON);
        }
        [HttpPut("modificar_personal")]
        public async Task<ActionResult<JSON_object>> modificar_Personal(Personal modificado_personal)
        {
            JSON_object jSON = new JSON_object("okay", modificado_personal);
            return Ok(jSON);
        }
        [HttpGet("mostrar_personal")]
        public async Task<ActionResult<JSON_object>> mostrar_Personal(Personal personal_mostrado)
        {
            JSON_object jSON = new JSON_object("okay", personal_mostrado);
            return Ok(jSON);
        }
    }
}
