using System;
using System.Reflection;
using System.Text;
using BSServer.Controllers;
using BSServer.Models;
using Microsoft.AspNetCore.Html;

namespace BSServer.Services
{
    public class ActionCalculate
    {
        public static ActionController.FigthResult FightResult(Character player, Character monster)
        {
            var stringBuilder = new StringBuilder();
            for(;;)
            {
                Fight(player, monster, stringBuilder);
                if (player.HitPoints < 0)
                    stringBuilder.Append($"выиграл {monster}");
                if (monster.HitPoints < 0)
                    stringBuilder.Append($"выиграл {player}");
                Fight(monster,player,stringBuilder);
            }

            //return new ActionController.FigthResult(stringBuilder.ToString(),monster);
        }
        public static void Fight(Character player, Character monster, StringBuilder stringBuilder)
        {
            for (int i = 0; i < player.AttackPerRound; i++)
            {
                var rnd = new Random();
                var varb = rnd.Next(20) + 1;
                if (varb == 20)
                    stringBuilder.Append($"критическое значение");
                if (varb + player.AttackModifier <= monster.DamageDiceCount) continue;
                var dmgRandom = 0;
                for (int j = 0; j < player.DamageDiceCount; ++j)
                    dmgRandom = rnd.Next(10);
                stringBuilder.Append(
                    $"{varb}(+{player.AttackModifier}) больше {monster.DamageDiceCount}.{dmgRandom}(+{player.DamageDiceCount} наносит {dmgRandom + player.DamageDiceCount}) врагу {monster.Name} ({monster.HitPoints})");
            }

        }
    }
}