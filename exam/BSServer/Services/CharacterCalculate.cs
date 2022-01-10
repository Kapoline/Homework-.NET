using BSServer.Models;

namespace BSServer.Services
{
    public class CharacterCalculate
    {
        public static CalculateCharacter CalculateModel(Character character)
        {
            return new CalculateCharacter
            {
                Name = character.Name,
                HitPoints = character.HitPoints,
                AttackModifier = character.AttackModifier,
                AttackPerRound = character.AttackPerRound,
                DamageDiceCount = character.DamageDiceCount,
                DamageDiceType = character.DamageDiceType,
                MinACtoAlwaysHit = character.AttackModifier + 1,
                DamagePerRound = (character.DamageDiceCount + character.DamageDiceType) * character.AttackPerRound
            };
        }
    }
}