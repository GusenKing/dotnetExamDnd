using Models;
using Models.Dto;

namespace Server.Services;

public class BattleLogic : IBattleLogic
{
    public ICharacter Player { get; set; }
    public ICharacter Monster { get; set; }

    public BattleLogic(){}

    public ResultDto GetFightResult()
    {
        var result = new ResultDto { Logs = new List<TurnLog>() };
        var currentTurn = new Turn { ActionCharacter = Player, DefendingCharacter = Monster };
        while (true)
        {
            var turnLog = ProcessTurn(currentTurn);
            result.Logs.Add(turnLog);
            if (turnLog.DefendingCharacterHp <= 0)
            {
                result.Winner = currentTurn.ActionCharacter is Player ? CharacterType.PLayer : CharacterType.Monster;
                return result;
            }

            currentTurn = new Turn{ActionCharacter = currentTurn.DefendingCharacter, DefendingCharacter = currentTurn.ActionCharacter};
        }
    }

    private TurnLog ProcessTurn(Turn turnToProcess)
    {
        var currentTurnLog = new TurnLog()
        {
            ActionCharacterName = turnToProcess.ActionCharacter.Name,
            DefendingCharacterName = turnToProcess.DefendingCharacter.Name,
            ActionCharacterAttackModifier = turnToProcess.ActionCharacter.AttackModifier,
            ActionCharacterDamageModifier = turnToProcess.ActionCharacter.DamageModifier
        };

        var attackDiceRoll = HelperMethods.ParseAndThrowDice("1d20");
        var hitType = HelperMethods.DetermineHitType(attackDiceRoll,
                turnToProcess.ActionCharacter.AttackModifier,
                turnToProcess.DefendingCharacter.ArmorClass);
        
        currentTurnLog.AttackDiceRoll = attackDiceRoll;
        currentTurnLog.AttachHitType = hitType;

        if (hitType == HitType.CriticalMiss || hitType == HitType.Miss) return currentTurnLog;

        var criticalHitMultiplier = hitType == HitType.CriticalHit ? 2 : 1;
        for (int i = 0; i < turnToProcess.ActionCharacter.AttackPerRound; i++)
        {
            var damageDiceRoll = HelperMethods.ParseAndThrowDice(turnToProcess.ActionCharacter.Damage);

            turnToProcess.DefendingCharacter.HitPoints -= damageDiceRoll + turnToProcess.ActionCharacter.DamageModifier;
            currentTurnLog.DamageDiceRolls.Add(damageDiceRoll);
        }

        currentTurnLog.DefendingCharacterHp = turnToProcess.DefendingCharacter.HitPoints;
        return currentTurnLog;
    }
}