using BSServer.Models;
using BSServer.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace BSServer.Controllers
{
    [ApiController]
    [Microsoft.AspNetCore.Mvc.Route("[action]")]
    public class CharacterController : ControllerBase
    {
        
        [HttpPost]
        public IActionResult CalculateCharacter(Character character)
        {
            return new JsonResult(CharacterCalculate.CalculateModel(character));
        }
    }
}