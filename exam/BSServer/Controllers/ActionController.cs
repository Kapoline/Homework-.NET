using BSServer.Models;
using BSServer.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace BSServer.Controllers
{
    [ApiController]
    [Microsoft.AspNetCore.Mvc.Route("[action]")]
    public class ActionController : Controller
    {
        public record Input(Character player, Character monster);

        public class FigthResult
        {
            public Character Character;
            public string str;
        }
        [HttpPost]
        public IActionResult Result(Input input)
        {
            var (player, monster) = input;
            return new JsonResult(ActionCalculate.FightResult(player, monster));
        }
    }
}