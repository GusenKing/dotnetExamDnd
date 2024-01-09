using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Models;

public class Player : ICharacter
{
    [Required]
    [MaxLength(30, ErrorMessage = "Name can't be longer than 30")]
    [DisplayName("Name")]
    public string Name { get; set; }
    [Required]
    [Range(0, 1000, ErrorMessage = "HP must be in 0 to 1000 range")]
    [DisplayName("Hit Points")]
    public int HitPoints { get; set; }
    [Required]
    [Range(-10, 10, ErrorMessage = "Modifier must be in -10 to 10 range")]
    [DisplayName("Attack Modifier")]
    public int AttackModifier { get; set; }
    [Required]
    [Range(0, 10, ErrorMessage = "Amount of attacks must be in 0 to 10 range")]
    [DisplayName("Attack Per Round")]
    public int AttackPerRound { get; set; }
    [Required]
    [RegularExpression(@"\d+d\d+", ErrorMessage = "Damage must be in format: number of dice rolls|dice type, like 2d4")]
    [DisplayName("Damage")]
    public string Damage { get; set; }
    [Required]
    [Range(-10, 10, ErrorMessage = "Modifier must be in -10 to 10 range")]
    [DisplayName("Damage Modifier")]
    public int DamageModifier { get; set; }
    [Required]
    [Range(0, 1000, ErrorMessage = "AC must be in 0 to 1000 range")]
    [DisplayName("Armor Class")]
    public int ArmorClass { get; set; }
}