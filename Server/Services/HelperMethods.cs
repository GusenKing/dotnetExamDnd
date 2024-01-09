using Models.Dto;

namespace Server.Services;

public static class HelperMethods
{
    public static int ParseAndThrowDice(string diceSignature)
    {
        var splitDice = diceSignature.Split("d");
        var throwsAmount = Int32.Parse(splitDice[0]);
        var diceType = Int32.Parse(splitDice[1]);
        
        int resultValue = 0;
        var rnd = new Random();
        
        for (int i = 0; i < throwsAmount; i++)
            resultValue = rnd.Next(0, diceType);

        return resultValue;
    }

    public static HitType DetermineHitType(int attackDiceRoll, int attackModifier, int defendingCreatureArmorClass) =>
        attackDiceRoll switch
        {
            1 => HitType.CriticalMiss,
            20 => HitType.CriticalHit,
            _ => attackDiceRoll + attackModifier >= defendingCreatureArmorClass ? HitType.Hit : HitType.Miss
        };
}