using API_Tareadef.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace API_Tareadef.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Equipo_MedicoController : ControllerBase
    {
        [HttpPost("agregar_eqmed")]
        public async Task<ActionResult<JSON_object>> agregar_Eqmed(Equipo_Medico nuevo_eqmed)
        {
            JSON_object jSON = new JSON_object("okay", nuevo_eqmed);
            //string jsonString = JsonConvert.SerializeObject(nuevo_paciente);
            //Console.WriteLine(jsonString);
            //string fileName = "PacienteJson.json";
            //string path = "C:\\Users\\maxga\\OneDrive\\Documentos\\Cursos CE\\Bases de Datos S1.2023\\API_Tareadef\\Recursos\\PacienteJson.json";
            //using (var tw = new StreamWriter(path, true)) { tw.WriteLine(jsonString.ToString()); tw.Close(); }

            return Ok(jSON);
        }
        [HttpDelete("eliminar_eqmed")]
        public async Task<ActionResult<JSON_object>> eliminar_Eqmed(Equipo_Medico eliminado_eqmed)
        {
            JSON_object jSON = new JSON_object("okay", eliminado_eqmed);
            return Ok(jSON);
        }
        [HttpPut("modificar_eqmed")]
        public async Task<ActionResult<JSON_object>> modificar_Eqmed(Equipo_Medico modificado_eqmed)
        {
            JSON_object jSON = new JSON_object("okay", modificado_eqmed);
            return Ok(jSON);
        }
        [HttpGet("mostrar_eqmed")]
        public async Task<ActionResult<JSON_object>> mostrar_Eqmed(Equipo_Medico eqmed_mostrado)
        {
            JSON_object jSON = new JSON_object("okay", eqmed_mostrado);
            return Ok(jSON);
        }
    }
}
