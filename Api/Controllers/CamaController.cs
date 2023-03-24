using API_Tareadef.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace API_Tareadef.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CamaController : ControllerBase
    {
        [HttpPost("agregar_cama")]
        public async Task<ActionResult<JSON_object>> agregar_Cama(Cama nueva_cama)
        {
            JSON_object jSON = new JSON_object("okay", nueva_cama);
            //string jsonString = JsonConvert.SerializeObject(nueva_cama);
            //Console.WriteLine(jsonString);
            //string fileName = "PacienteJson.json";
            //string path = "C:\\Users\\maxga\\OneDrive\\Documentos\\Cursos CE\\Bases de Datos S1.2023\\API_Tareadef\\Recursos\\PacienteJson.json";
            //using (var tw = new StreamWriter(path, true)) { tw.WriteLine(jsonString.ToString()); tw.Close(); }

            return Ok(jSON);
        }
        [HttpDelete("eliminar_cama")]
        public async Task<ActionResult<JSON_object>> eliminar_Cama(Cama eliminado_cama)
        {
            JSON_object jSON = new JSON_object("okay", eliminado_cama);
            return Ok(jSON);
        }
        [HttpPut("modificar_cama")]
        public async Task<ActionResult<JSON_object>> modificar_Cama(Cama modificado_cama)
        {
            JSON_object jSON = new JSON_object("okay", modificado_cama);
            return Ok(jSON);
        }
        [HttpGet("mostrar_cama")]
        public async Task<ActionResult<JSON_object>> mostrar_Cama(Cama cama_mostrado)
        {
            JSON_object jSON = new JSON_object("okay", cama_mostrado);
            return Ok(jSON);
        }
    }
}
