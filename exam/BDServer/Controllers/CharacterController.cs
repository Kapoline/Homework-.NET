using System;
using System.Linq;
using BDServer.Models;
using Microsoft.AspNetCore.Mvc;

namespace BDServer.Controllers
{
    [ApiController]
    [Route("[action]")]
    public class CharacterController : ControllerBase
    {
        private record CharacterIdNameModel(int id, string name);
        
        [HttpGet]
        public IActionResult GetCharacter([FromServices] DbConnection _connection)
        {
            return new JsonResult(_connection.Characters.Select(c => new CharacterIdNameModel(c.Id, c.Name)));
        }

        [HttpGet]
        public IActionResult GetCharacterBy([FromQuery] int id, [FromServices] DbConnection _connection)
        {
            return new JsonResult(_connection.Characters.First(c => c.Id == id));
        }
        public record CharacterAddingModel(
            string Name,
            int HitPoints,
            int AttackModifier,
            int AttackPerRound,
            int DamageDiceCount,
            int DamageDiceType,
            int WeaponModifier);

        [HttpGet]
        public IActionResult AddCharacter([FromBody] CharacterAddingModel characterAddingModel)
        {
            var character = new Character
            {
                Name = characterAddingModel.Name,
                HitPoints = characterAddingModel.HitPoints,
                AttackModifier = characterAddingModel.AttackModifier,
                AttackPerRound = characterAddingModel.AttackPerRound,
                DamageDiceCount = characterAddingModel.DamageDiceCount,
                DamageDiceType = characterAddingModel.DamageDiceType,
                WeaponModifier = characterAddingModel.WeaponModifier
            };
            return Ok(character);
        }

        [HttpGet]
        public IActionResult ChooseMonster([FromServices] DbConnection connection)
        {
            Random rnd = new Random();
            var random = rnd.Next(connection.Monsters.Count());
            var monsters = (random > 0 ? connection.Monsters.Skip(random) : connection.Monsters).First();
            return new JsonResult(monsters);
        }
    }
}