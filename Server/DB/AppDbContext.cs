using Microsoft.EntityFrameworkCore;
using Models;

namespace Server.DB;

public class AppDbContext : DbContext
{
    public DbSet<Monster> Monsters { get; set; } = null;

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var monsterListForDb = new List<Monster>()
        {
            new Monster
            {
                MonsterId = 1,
                Name = "Troll",
                HitPoints = 84,
                AttackModifier = 40,
                AttackPerRound = 1,
                Damage = "8d10",
                DamageModifier = 4,
                ArmorClass = 15
            },
            new Monster
            {
                MonsterId = 2,
                Name = "Bronze Dragon Wyrmling",
                HitPoints = 32,
                AttackModifier = 10,
                AttackPerRound = 1,
                Damage = "5d8",
                DamageModifier = 3,
                ArmorClass = 17
            },
            new Monster
            {
                MonsterId = 3,
                Name = "Salamander",
                HitPoints = 90,
                AttackModifier = 24,
                AttackPerRound = 1,
                Damage = "12d10",
                DamageModifier = 4,
                ArmorClass = 15
            },
            new Monster
            {
                MonsterId = 4,
                Name = "Brown Bear",
                HitPoints = 34,
                AttackModifier = 12,
                AttackPerRound = 1,
                Damage = "4d10",
                DamageModifier = 4,
                ArmorClass = 11
            },
            new Monster
            {
                MonsterId = 5,
                Name = "Cat",
                HitPoints = 12,
                AttackModifier = 1,
                AttackPerRound = 1,
                Damage = "1d4",
                DamageModifier = 1,
                ArmorClass = 12
            },
        };
        modelBuilder.Entity<Monster>().HasData(monsterListForDb);
    }
}