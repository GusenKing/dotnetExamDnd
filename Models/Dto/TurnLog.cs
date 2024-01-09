namespace Models.Dto;

public class TurnLog
{
    public int AttackDiceRoll { get; set; }
    public HitType AttachHitType { get; set; }
    public List<int> DamageDiceRolls { get; set; } = new();
    public int DefendingCharacterHp { get; set; }
    public string ActionCharacterName { get; set; }
    public int ActionCharacterAttackModifier { get; set; }
    public int ActionCharacterDamageModifier { get; set; }
    public string DefendingCharacterName { get; set; }
}