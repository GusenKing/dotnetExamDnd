namespace Models.Dto;

public class PlayerMonsterStatsDto
{
    public Player Player { get; set; }
    public Monster Monster { get; set; }

    public PlayerMonsterStatsDto(Player player, Monster monster)
    {
        Player = player;
        Monster = monster;
    }
}