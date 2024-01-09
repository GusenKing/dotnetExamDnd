using Models;
using Models.Dto;

namespace Server.Services;

public interface IBattleLogic
{
    ICharacter Player { get; set; }
    ICharacter Monster { get; set; }
    ResultDto GetFightResult();
}