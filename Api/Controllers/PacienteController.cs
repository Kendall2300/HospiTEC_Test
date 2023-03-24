using API_Tareadef.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using System;
using Newtonsoft.Json;

namespace API_Tareadef.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PacienteController : ControllerBase
    {
        [HttpPost("agregar_paciente")]
        public async Task<ActionResult<JSON_object>> agregar_Paciente(Paciente nuevo_paciente)
        {
            JSON_object jSON = new JSON_object("okay", nuevo_paciente);
            string jsonString = JsonConvert.SerializeObject(nuevo_paciente);
            Console.WriteLine(jsonString);
            string fileName = "PacienteJson.json";
            string path = @".\\Recursos\\PacienteJson.json";
            using (var tw = new StreamWriter(path, true)) { tw.WriteLine(jsonString.ToString()); tw.Close(); }

            return Ok(jSON);
        }
        [HttpDelete("eliminar_paciente")]
        public async Task<ActionResult<JSON_object>> eliminar_Paciente(Paciente eliminado_paciente)
        {
            JSON_object jSON = new JSON_object("okay", eliminado_paciente);
            return Ok(jSON);
        }
        [HttpPut("modificar_paciente")]
        public async Task<ActionResult<JSON_object>> modificar_Paciente(Paciente modificado_paciente)
        {
            JSON_object jSON = new JSON_object("okay", modificado_paciente);
            return Ok(jSON);
        }
        [HttpGet("mostrar_paciente")]
        public async Task<ActionResult<JSON_object>> mostrar_Paciente(Paciente paciente_mostrado)
        {
            JSON_object jSON = new JSON_object("okay", paciente_mostrado); 
            return Ok(jSON);
        }
        

    }
}
