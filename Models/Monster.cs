﻿using System.ComponentModel.DataAnnotations;

namespace Models;

public class Monster : ICharacter
{
    [Key]
    public int MonsterId { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public int HitPoints { get; set; }
    [Required]
    public int AttackModifier { get; set; }
    [Required]
    public int AttackPerRound { get; set; }
    [Required]
    public string Damage { get; set; }
    [Required]
    public int DamageModifier { get; set; }
    [Required]
    public int ArmorClass { get; set; }
}