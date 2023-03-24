using API_Tareadef.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace API_Tareadef.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PatologiaController : ControllerBase
    {
        [HttpPost("agregar_patologia")]
        public async Task<ActionResult<JSON_object>> agregar_Patologia(Patologia nueva_patologia)
        {
            JSON_object jSON = new JSON_object("okay", nueva_patologia);
            //string jsonString = JsonConvert.SerializeObject(nuevo_paciente);
            //Console.WriteLine(jsonString);
            //string fileName = "PacienteJson.json";
            //string path = "C:\\Users\\maxga\\OneDrive\\Documentos\\Cursos CE\\Bases de Datos S1.2023\\API_Tareadef\\Recursos\\PacienteJson.json";
            //using (var tw = new StreamWriter(path, true)) { tw.WriteLine(jsonString.ToString()); tw.Close(); }

            return Ok(jSON);
        }
        [HttpDelete("eliminar_patologia")]
        public async Task<ActionResult<JSON_object>> eliminar_Patologia(Patologia eliminada_patologia)
        {
            JSON_object jSON = new JSON_object("okay", eliminada_patologia);
            return Ok(jSON);
        }
        [HttpPut("modificar_patologia")]
        public async Task<ActionResult<JSON_object>> modificar_Patologia(Patologia modificado_patologia)
        {
            JSON_object jSON = new JSON_object("okay", modificado_patologia);
            return Ok(jSON);
        }
        [HttpGet("mostrar_patologia")]
        public async Task<ActionResult<JSON_object>> mostrar_Patologia(Patologia patologia_mostrado)
        {
            JSON_object jSON = new JSON_object("okay", patologia_mostrado);
            return Ok(jSON);
        }
    }
}
