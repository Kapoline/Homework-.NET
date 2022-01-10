using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BSServer.Models;
using BSServer.Services;
using Microsoft.AspNetCore.DataProtection.Internal;
using Microsoft.AspNetCore.Mvc;
using CalculateCharacter = BSServer.Models.CalculateCharacter;
using Character = Exam.Models.Character;

namespace Exam.Controllers
{
    public class CharacterController : Controller
    {
        private static HttpClient _client;

        public CharacterController()
        {
            var t = new HttpClientHandler();
            t.ServerCertificateCustomValidationCallback = (message, certificate2, arg3, arg4) => true;
            _client = new HttpClient(t);
        }

        private record FigthStatrtingModel(Character Character, Character monster);
        public record FigthModel(CalculateCharacter player,string str, Character monster);

        public record FigthResult(string str, Character Character);
        
        public async Task<IActionResult> Get(Character character)
        {
            var play = await _client.GetAsync("https://localhost:5201/AddCharacter");
            var players = await play.Content.ReadFromJsonAsync<Character>();
            var monst = await _client.GetAsync($"https://localhost:5201/ChooseMonster");
            var monster = await monst.Content.ReadFromJsonAsync<Character>();
            var calc = await _client.PostAsync($"https://localhost:5101/CalculateCharacter", JsonContent.Create(character));
            var calculetedCharacter = await calc.Content.ReadFromJsonAsync<CalculateCharacter>();
            var content = JsonContent.Create(new FigthStatrtingModel(character, monster));
            var figth = await _client.PostAsync($"https://localhost:5101/Result", content);
            var res = await figth.Content.ReadFromJsonAsync<FigthResult>();
            return View(new FigthModel(calculetedCharacter!,res!.str,res.Character));
        }
    }
}