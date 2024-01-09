namespace Models.Dto;

public class ResultDto
{
    public List<TurnLog> Logs { get; set; }
    public CharacterType Winner { get; set; }
}